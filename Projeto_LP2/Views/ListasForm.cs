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
    public partial class ListasForm : Form
    {
        public ListasForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                
                IDAO<ProdutosLista> ProdutosListaDAO = new ProdutosListasDAO(conn);
                Collection<ProdutosLista> colecao = ProdutosListaDAO.ListarTudo();
                Collection<ProdutosLista> listaAtual = new Collection<ProdutosLista>();
                foreach (ProdutosLista p in colecao)
                {
                    if (p.Id_lista.Equals(cBoxListas.SelectedValue))
                    {
                        listaAtual.Add(p);
                    }

                }
                
                
                dataGridView.DataSource = listaAtual;
                dataGridView.Refresh();


            }

        }

        private void ListasForm_Load(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Lista> ListasDAO = new ListasDAO(conn);
                Lista lista = new Lista();
                cBoxListas.DisplayMember = "nome";
                cBoxListas.ValueMember = "id";
                cBoxListas.DataSource = ListasDAO.ListarTudo();

                IDAO<ProdutosLista> ProdutosListaDAO = new ProdutosListasDAO(conn);
                Collection<ProdutosLista> colecao = ProdutosListaDAO.ListarTudo();
                Collection<ProdutosLista> listaAtual = new Collection<ProdutosLista>();
                foreach(ProdutosLista p in colecao)
                {
                    if (p.Id_lista.Equals(cBoxListas.SelectedValue))
                    {
                        listaAtual.Add(p);
                    }

                }
                
                dataGridView.DataSource = listaAtual;
               
              
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            NovaListaForm form = new NovaListaForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void btnAtualizarListas_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Lista> ListasDAO = new ListasDAO(conn);
                Lista lista = new Lista();

                
                cBoxListas.DisplayMember = "nome";
                cBoxListas.ValueMember = "id";
                cBoxListas.DataSource = ListasDAO.ListarTudo();
                cBoxListas.Refresh();


            }

        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            NovoProdutoListaForm form = new NovoProdutoListaForm(cBoxListas.SelectedValue.ToString());
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);

        }
    }
}
