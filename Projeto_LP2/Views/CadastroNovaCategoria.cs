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
    public partial class CadastroNovaCategoria : Form
    {
        public CadastroNovaCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Categoria> CategoriaDAO = new CategoriaDAO(conn);

                Categoria categoria = new Categoria();

                categoria.Nome = txtNomeCategoria.Text;

                CategoriaDAO.Inserir(categoria);
                Dispose();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
