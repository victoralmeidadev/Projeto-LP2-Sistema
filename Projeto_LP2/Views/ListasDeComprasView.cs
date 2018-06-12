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

        private void ListasDeComprasView_Load(object sender, EventArgs e)
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

        private void dataGridViewListas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<ProdutosLista> ProdutosListaDAO = new ProdutosListasDAO(conn);
                    Collection<ProdutosLista> colecao = ProdutosListaDAO.ListarTudo();
                    Collection<ProdutosLista> listaAtual = new Collection<ProdutosLista>();

                    int index = e.RowIndex;
                    DataGridViewRow selectedRow = dataGridViewListas.Rows[index];
                    int value = int.Parse(selectedRow.Cells[0].Value.ToString());
                    IdSelecionado = value;
                    foreach (ProdutosLista p in colecao)
                    {
                        if (p.Id_lista.Equals(value))
                        {
                            listaAtual.Add(p);
                        }
                    }
                    dataGridViewItensLista.DataSource = listaAtual;
                    dataGridViewItensLista.Refresh();
                }
            }

        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            NovaListaForm form = new NovaListaForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Lista> ListasDAO = new ListasDAO(conn);
                Lista lista = new Lista();
                lista.Id = IdSelecionado;
                ListasDAO.Remover(lista);
                
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
    }
    }

