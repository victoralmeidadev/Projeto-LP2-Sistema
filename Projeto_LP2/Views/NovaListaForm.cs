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
    public partial class NovaListaForm : Form
    {
        public NovaListaForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Lista> ListasDAO = new ListasDAO(conn);
                Lista lista= new Lista();
                lista.Nome = txtNomeLista.Text.ToString().Trim();
                ListasDAO.Inserir(lista);

                Dispose();
            }
        }

        private void NovaListaForm_Load(object sender, EventArgs e)
        {

        }
        
    }
}
