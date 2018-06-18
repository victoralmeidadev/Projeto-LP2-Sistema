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
    public partial class NovoProdutoListaForm : Form
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

        public NovoProdutoListaForm()
        {
            InitializeComponent();
        }
        public NovoProdutoListaForm(int id_lista)
        {
            InitializeComponent();
            this.idSelecionado = id_lista;
        }

        private void NovoProdutoListaForm_Load(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                Produto produto = new Produto();
                cBoxProduto.DisplayMember = "nomeProduto";
                cBoxProduto.ValueMember = "id";
                cBoxProduto.DataSource = ProdutosDAO.ListarTudo();
                
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            if (txtQuantidade.Text.Equals(""))
            {
                MessageBox.Show("Insira quantidade!", "Linguagem de programação II",
                               MessageBoxButtons.OK, MessageBoxIcon.None);
            }else if (cBoxProduto.SelectedValue.ToString().Equals(""))
            {
                MessageBox.Show("Selecione um produto!", "Linguagem de programação II",
                               MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            else
            {
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<ProdutosLista> ProdutosListasDAO = new ProdutosListasDAO(conn);
                    ProdutosLista produto = new ProdutosLista();
                    produto.Nome = cBoxProduto.Text.ToString().Trim();
                    produto.Id_lista = this.idSelecionado;
                    produto.Id_produto = cBoxProduto.SelectedValue.ToString();
                    produto.Quantidade = int.Parse(txtQuantidade.Text.ToString().Trim());

                    try
                    {
                        ProdutosListasDAO.Inserir(produto);
                        MessageBox.Show("Produto adicionado!", "Linguagem de programação II",
                                   MessageBoxButtons.OK, MessageBoxIcon.None);
                        Dispose();
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel adicionar item na lista!", "Linguagem de programação II",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtIdLista_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            //verifica se oque foi digitado é numeroo
            if (!char.IsDigit(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))

            {

                e.Handled = true;
                MessageBox.Show("Este campo aceita somente numeros");

            }

        }
    }
}
