using Projeto_LP2.Interfaces;
using Projeto_LP2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LP2.Views
{
    public partial class CadastroNovoProduto : Form
    {
        private int idSelecionado;
        public int IdSelecionado
        {
            get
            {
                return idSelecionado;
            }

            set
            {
                idSelecionado = value;
            }
        }

        public CadastroNovoProduto()
        {
            InitializeComponent();
        }

        public CadastroNovoProduto(Produto p, int modo)
        {

            //modos
            // 0 --> cadastro de outro produto
            // 1 --> edição de produto
            // 2 --> visualizar produto
            // sem contrutor --> cadastro normal de produto
            if(modo == 0)
            {
                InitializeComponent();
                txtNomeNovoProduto.Text = p.NomeProduto;
                txtCodigoNovoProduto.Text = p.Codigo;
                txtNomeNovoProduto.ReadOnly = true;
                txtCodigoNovoProduto.ReadOnly = true;
                cBoxCategoriaNovoProduto.Enabled = false;

            }else if(modo == 1)
            {
                InitializeComponent();
                this.idSelecionado = p.Id;
                txtNomeNovoProduto.Text = p.NomeProduto;
                txtCodigoNovoProduto.Text = p.Codigo;
                txtPrecoNovoProduto.Text = p.Preco.ToString().Trim();
                cBoxSupermercadoNovoProduto.Enabled = false;
                cBoxCategoriaNovoProduto.Enabled = false;
                txtCodigoNovoProduto.ReadOnly = false;
                lblNovaCategoria.Visible = false;
                BtnCadastraNovoProduto.Text = "Finalizar Edição";
                

            }else if(modo == 2)
            {
                InitializeComponent();
                txtNomeNovoProduto.Text = p.NomeProduto;
                txtCodigoNovoProduto.Text = p.Codigo;
                txtPrecoNovoProduto.Text = p.Preco.ToString().Trim();
                txtNomeNovoProduto.ReadOnly = true;
                txtCodigoNovoProduto.ReadOnly = true;
                txtPrecoNovoProduto.ReadOnly = true;
                cBoxSupermercadoNovoProduto.Enabled = false;
                BtnCadastraNovoProduto.Visible = false;
                lblNovaCategoria.Visible = false;

            }            
            
        }

        private void BtnCadastrarNovoProduto_Click(object sender, EventArgs e)
        {
             if (txtNomeNovoProduto.Text.Equals("") || txtPrecoNovoProduto.Text.Equals(""))
            {
                MessageBox.Show("Preencha os campos!", "Linguagem de programação II",
                                MessageBoxButtons.OK, MessageBoxIcon.None);
            }else if (txtCodigoNovoProduto.Text.Length != 7)
            {
                MessageBox.Show("O código deve ter 7 numeros!", "Linguagem de programação II",
                                MessageBoxButtons.OK, MessageBoxIcon.None);

            }else
            {
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<Produto> ProdutoDAO = new ProdutoDAO(conn);


                    Produto produto = new Produto();
                    produto.NomeProduto = txtNomeNovoProduto.Text.ToString().Trim();
                    produto.Supermercado = cBoxSupermercadoNovoProduto.SelectedValue.ToString();
                    produto.Codigo = txtCodigoNovoProduto.Text.ToString().Trim();
                    produto.Preco = double.Parse(txtPrecoNovoProduto.Text.ToString().Trim());
                    produto.Categoria = cBoxCategoriaNovoProduto.SelectedValue.ToString();

                    if (BtnCadastraNovoProduto.Text.Equals("Finalizar Edição"))
                    {

                        produto.Id = this.idSelecionado;
                        try
                        {
                            ProdutoDAO.Atualizar(produto);
                            Dispose();
                            MessageBox.Show("Edição realizada com sucesso!", "Linguagem de programação II",
                                MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                        catch
                        {
                            MessageBox.Show("Não foi possivel realizar edição", "Linguagem de programação II",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }

                    }
                    else
                    {

                        try
                        {
                            if (ProdutoDAO.Inserir(produto) == 1)
                            {

                                if (MessageBox.Show("Cadastro realizado com sucesso, deseja cadastrar outro produto com o mesmo código?", "Linguagem de programação II",
                                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                                 == DialogResult.Yes)
                                {
                                    Dispose();
                                    CadastroNovoProduto form = new CadastroNovoProduto(produto, 0);
                                    form.StartPosition = FormStartPosition.CenterParent;
                                    form.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("Cadastro realizado com sucesso!", "Linguagem de programação II",
                                    MessageBoxButtons.OK, MessageBoxIcon.None);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possivel realizar cadastro", "Linguagem de programação II",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    Dispose();

                }
            }
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CadastroNovoProduto_Load(object sender, EventArgs e)
        {
            txtCodigoNovoProduto.MaxLength = 7;
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                //carregar supermercados no combo box
                IDAO<Supermercado> SupermercadoDAO = new SupermercadoDAO(conn);
                Supermercado supermercado = new Supermercado();
                cBoxSupermercadoNovoProduto.DisplayMember = "nome";
                cBoxSupermercadoNovoProduto.ValueMember = "id";
                cBoxSupermercadoNovoProduto.DataSource = SupermercadoDAO.ListarTudo();

                //carregar categorias no combobox
                IDAO<Categoria> CategoriaDAO = new CategoriaDAO(conn);
                Categoria categoria = new Categoria();
                cBoxCategoriaNovoProduto.DisplayMember = "nome";
                cBoxCategoriaNovoProduto.ValueMember = "id";
                cBoxCategoriaNovoProduto.DataSource = CategoriaDAO.ListarTudo();

            }
        }

        private void cBoxSupermercadoNovoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoNovoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica se oque foi digitado é numeroo
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))

            {

                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numeros");

            }
        }

        

        private void txtPrecoNovoProduto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';

                //Verifica se já existe alguma vírgula na string
                if (txtPrecoNovoProduto.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }

            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void lblNovaCategoria_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroNovaCategoria form = new CadastroNovaCategoria();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void txtCodigoNovoProduto_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomeNovoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

