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
    public partial class SupermercadosView : Form
    {
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
    }
}
