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
    public partial class ListasDeComprasView : Form
    {
        public ListasDeComprasView()
        {
            InitializeComponent();
        }
        private int idSelecionado, idProdutoSelecionado;

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

        public int IdProdutoSelecionado
        {
            get
            {
                return IdProdutoSelecionado;
            }

            set
            {
                IdProdutoSelecionado = value;
            }
        }

        private void ListasDeComprasView_Load(object sender, EventArgs e)
        {
            this.atualizarDataGrid();
        }

        private void dataGridViewListas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridViewListas.Rows[index];
                int value = int.Parse(selectedRow.Cells[0].Value.ToString());
                this.IdSelecionado = value;

                this.atualizarDataGrid(this.idSelecionado);
            }

        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            NovaListaForm form = new NovaListaForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
            this.atualizarDataGrid();
            
        }

        //funcao para atualizar datagrid listas
        private void atualizarDataGrid()
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Lista> ListasDAO = new ListasDAO(conn);
                Lista lista = new Lista();
                dataGridViewListas.Refresh();
                dataGridViewListas.DataSource = ListasDAO.ListarTudo();
            }
        }
        //funcao para atualizar datagrid itens da lista selecioanda
        private void atualizarDataGrid(int lista_selecionada)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<ProdutosLista> ProdutosListaDAO = new ProdutosListasDAO(conn);
                Collection<ProdutosLista> colecao = ProdutosListaDAO.ListarTudo();
                Collection<ProdutosLista> listaAtual = new Collection<ProdutosLista>();


                foreach (ProdutosLista p in colecao)
                {
                    if (p.Id_lista.Equals(lista_selecionada))
                    {
                        listaAtual.Add(p);
                    }
                }
                dataGridViewItensLista.DataSource = listaAtual;
                dataGridViewItensLista.Refresh();
            }
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (this.idSelecionado > 0)
            {
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<Lista> ListasDAO = new ListasDAO(conn);
                    Lista lista = new Lista();
                    lista.Id = IdSelecionado;
                    try
                    {
                        ListasDAO.Remover(lista);
                        dataGridViewListas.DataSource = ListasDAO.ListarTudo();
                        this.atualizarDataGrid(this.idSelecionado);
                        MessageBox.Show("Lista deletada!", "Linguagem de programação II",
                                   MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    catch
                    {
                        MessageBox.Show("Falha ao deletar lista!", "Linguagem de programação II",
                                   MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Lista> ListasDAO = new ListasDAO(conn);
                Lista lista = new Lista();
                lista.Nome = txtFiltro.Text;
                dataGridViewListas.DataSource = ListasDAO.LocalizarPorCodigo(lista);
                dataGridViewListas.Refresh();
            }

        }

        private void dataGridViewListas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdicionarProdutoLista_Click(object sender, EventArgs e)
        {
            
            if(this.idSelecionado > 0)
            {
                NovoProdutoListaForm form = new NovoProdutoListaForm(this.idSelecionado);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog();
                this.atualizarDataGrid(this.idSelecionado);
            }
        }

        private void btnRemoverProduto_Click(object sender, EventArgs e)
        {
            if (this.idProdutoSelecionado > 0)
            {
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<ProdutosLista> ProdutosListasDAO = new ProdutosListasDAO(conn);
                    ProdutosLista produto = new ProdutosLista();
                    produto.Id = this.idProdutoSelecionado;
                    try
                    {
                        ProdutosListasDAO.Remover(produto);
                        MessageBox.Show("Produto removido!", "Linguagem de programação II",
                                   MessageBoxButtons.OK, MessageBoxIcon.None);
                        this.atualizarDataGrid(this.idSelecionado);
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel remover item na lista!", "Linguagem de programação II",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um produto!", "Linguagem de programação II",
                                   MessageBoxButtons.OK, MessageBoxIcon.None);
            }

        }

        private void dataGridViewItensLista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridViewItensLista.Rows[index];
                int value = int.Parse(selectedRow.Cells[0].Value.ToString());
                this.idProdutoSelecionado = value;
            }
        }
    }
    }

