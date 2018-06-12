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
    public partial class ProdutosView : Form
    {
        public ProdutosView()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProdutosView_Load(object sender, EventArgs e)
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

        private void dataGridViewProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }
    }
}
