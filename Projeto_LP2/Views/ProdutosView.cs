using Projeto_LP2.Interfaces;
using Projeto_LP2.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_LP2.Views
{
    public partial class ProdutosView : Form
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

        public ProdutosView()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProdutosView_Load(object sender, EventArgs e)
        {
            this.loadDataGridProdutos();
        }

        public void loadDataGridProdutos()
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                Produto produto = new Produto();
                dataGridViewProdutos.Refresh();
                dataGridViewProdutos.DataSource = ProdutosDAO.ListarTudo();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            CadastroNovoProduto form = new CadastroNovoProduto();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
            this.loadDataGridProdutos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                Produto p = new Produto();
                p.Id = this.idSelecionado;
                Collection<Produto> colecao = ProdutosDAO.ListarTudo();
                
                foreach(Produto prod in colecao)
                {
                    if(prod.Id == this.idSelecionado)
                    {
                        CadastroNovoProduto form = new CadastroNovoProduto(prod, 1);
                        form.StartPosition = FormStartPosition.CenterParent;
                        form.ShowDialog();
                        this.loadDataGridProdutos();
                        break;
                    }
                }


            }
        }

        private void dataGridViewProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridViewProdutos.Rows[index];
                    int value = int.Parse(selectedRow.Cells[1].Value.ToString());
                    IdSelecionado = value;
            }
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                Produto p = new Produto();
                p.Id = this.idSelecionado;
                Collection<Produto> colecao = ProdutosDAO.LocalizarPorCodigo(p);

                foreach (Produto prod in colecao)
                {
                    if (prod.Id == this.idSelecionado)
                    {
                        CadastroNovoProduto form = new CadastroNovoProduto(prod, 2);
                        form.StartPosition = FormStartPosition.CenterParent;
                        form.ShowDialog();
                        break;
                    }
                }


            }
        }

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewProdutos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridViewProdutos.Rows[index];
                int value = int.Parse(selectedRow.Cells[1].Value.ToString());
                IdSelecionado = value;
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                    Produto p = new Produto();
                    p.Id = this.idSelecionado;
                    Collection<Produto> colecao = ProdutosDAO.LocalizarPorCodigo(p);

                    foreach (Produto prod in colecao)
                    {
                        if (prod.Id == this.idSelecionado)
                        {
                            CadastroNovoProduto form = new CadastroNovoProduto(prod, 1);
                            form.StartPosition = FormStartPosition.CenterParent;
                            form.ShowDialog();
                            break;
                        }
                    }


                }
            }
        }

        private void txtFiltroProdutos_TextChanged(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                Produto produto = new Produto();
                produto.NomeProduto = txtFiltroProdutos.Text;
                dataGridViewProdutos.DataSource = ProdutosDAO.LocalizarPorCodigo(produto);
                dataGridViewProdutos.Refresh();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (this.idSelecionado > 0)
            {
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                    Produto produto = new Produto();
                    produto.Id = this.idSelecionado;
                    try
                    {
                        ProdutosDAO.Remover(produto);
                        dataGridViewProdutos.DataSource = ProdutosDAO.ListarTudo();
                        dataGridViewProdutos.Refresh();
                        MessageBox.Show("Produto deletado!", "Linguagem de programação II",
                                       MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel remover este produto", "Linguagem de programação II",
                                       MessageBoxButtons.OK, MessageBoxIcon.None);
                    }

                }

            }
            else
            {
                MessageBox.Show("Selecione um produto!", "Linguagem de programação II",
                                   MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

    }
}
