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
    public partial class SupermercadosView : Form
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

        public SupermercadosView()
        {
            InitializeComponent();
        }

        private void SupermercadosView_Load(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Supermercado> SupermercadoDAO = new SupermercadoDAO(conn);
                Supermercado supermercado = new Supermercado();
                dataGridViewSupermercados.Refresh();
                dataGridViewSupermercados.DataSource = SupermercadoDAO.ListarTudo();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFiltroSupermercado_TextChanged(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Supermercado> SupermercadosDAO = new SupermercadoDAO(conn);
                Supermercado supermercado = new Supermercado();
                supermercado.Nome = txtFiltroSupermercado.Text;
                dataGridViewSupermercados.DataSource = SupermercadosDAO.LocalizarPorCodigo(supermercado);
                dataGridViewSupermercados.Refresh();
            }
        }

        private void btnCadastrarSupermercado_Click(object sender, EventArgs e)
        {
            CadastroSupermercadoForm form = new CadastroSupermercadoForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }

        private void btnEditarSupermercado_Click(object sender, EventArgs e)
        {
            if (this.idSelecionado > 0)
            {
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<Supermercado> SupermercadosDAO = new SupermercadoDAO(conn);
                    Supermercado s = new Supermercado();
                    s.Id = this.idSelecionado;
                    Collection<Supermercado> colecao = SupermercadosDAO.ListarTudo();

                    foreach (Supermercado sup in colecao)
                    {
                        if (sup.Id == this.idSelecionado)
                        {
                            CadastroSupermercadoForm form = new CadastroSupermercadoForm(sup);
                            form.StartPosition = FormStartPosition.CenterParent;
                            form.ShowDialog();
                            dataGridViewSupermercados.DataSource = SupermercadosDAO.ListarTudo();
                            dataGridViewSupermercados.Refresh();
                            break;
                        }
                    }


                }

            }
            else
            {
                MessageBox.Show("Selecione um supermercado!", "Linguagem de programação II",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void dataGridViewSupermercados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int index = e.RowIndex;
                DataGridViewRow selectedRow = dataGridViewSupermercados.Rows[index];
                int value = int.Parse(selectedRow.Cells[0].Value.ToString());
                IdSelecionado = value;
            }
        }
    }
}
