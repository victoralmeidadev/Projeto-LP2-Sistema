using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_LP2.Model;
using Projeto_LP2.Interfaces;

namespace Projeto_LP2.Views
{
    public partial class CadastroSupermercadoForm : Form
    {
        public CadastroSupermercadoForm()
        {
            InitializeComponent();
        }

        private void CadastroSupermercadoForm_Load(object sender, EventArgs e)
        {

        }


        private void BtnCadastraSupermercado_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Supermercado> SupermercadoDAO = new SupermercadoDAO(conn);

                Supermercado supermercado = new Supermercado();

                supermercado.Nome = txtNomeSupermercado.Text;

                SupermercadoDAO.Inserir(supermercado);
                Dispose();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
