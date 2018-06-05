using Projeto_LP2.Views;
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

namespace Projeto_LP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void preçosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CadastroNovoProduto_Click(object sender, EventArgs e)
        {
            CadastroNovoProduto form = new CadastroNovoProduto();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
                        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                /*conn.Abrir();
                IDAO<Supermercado> SupermercadoDAO = new SupermercadoDAO(conn);
                IDAO<Produto> ProdutoDAO = new ProdutoDAO(conn);

                Supermercado supermercado = new Supermercado();
                Produto produto = new Produto();

                cBoxSupermercado1.DisplayMember = "nome";
                cBoxSupermercado1.ValueMember = "id";
                cBoxSupermercado2.DisplayMember = "nome";
                cBoxSupermercado2.ValueMember = "id";
                cBoxSupermercadoProduto.DisplayMember = "nome";
                cBoxSupermercadoProduto.ValueMember = "id";
                cBoxProduto.DisplayMember = "nomeProduto";
                cBoxProduto.ValueMember = "codigo";

                cBoxProduto.DataSource = ProdutoDAO.ListarTudo();
                cBoxSupermercado1.DataSource = SupermercadoDAO.ListarTudo();
                cBoxSupermercado2.DataSource = SupermercadoDAO.ListarTudo();
                cBoxSupermercadoProduto.DataSource = SupermercadoDAO.ListarTudo();*/

            }

        }

        private void graficoLoad()
        {

        }

        private void NovoSupermercadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroSupermercadoForm form = new CadastroSupermercadoForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);


        }

        private void NovoPreçoProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Cria um form para cadastro de novo livro
            CadastroProdutoForm form = new CadastroProdutoForm();
            //Ajusta a abertura do form para o centro do form que o invocou (parent)
            form.StartPosition = FormStartPosition.CenterParent;
            //Usa o método ShowDialog para abrir o Form como modal, ou seja, 
            //bloqueado o form parent que o invocou (this)
            form.ShowDialog(this);
            //Fill é um método criado por nós para atualizar o datagridview
            //com o conteúdo do dicionário
        }

        private void verListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListasForm form = new ListasForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void novaListaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaListaForm form = new NovaListaForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog(this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
                    }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if(panelSideMenu.Height == 641 && panelSideMenu.Width == 235)
            {
                panelSideMenu.Height = 641;
                panelSideMenu.Width = 32;
                btnMore.Left = 0;

            }
            else
            {
                panelSideMenu.Height = 641;
                panelSideMenu.Width = 235;
                btnMore.Left = 202;

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProdutosView newMDIChild = new ProdutosView();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            newMDIChild.StartPosition = FormStartPosition.CenterScreen;
            newMDIChild.Dock = DockStyle.Fill; 
            // Display the new form.  
            newMDIChild.Show();
            lblTitleScreen.Text = "Produtos";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SupermercadosView newMDIChild = new SupermercadosView();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            newMDIChild.StartPosition = FormStartPosition.CenterScreen;
            newMDIChild.Dock = DockStyle.Fill;
            // Display the new form.  
            newMDIChild.Show();
            lblTitleScreen.Text = "Supermercados";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ListasDeComprasView newMDIChild = new ListasDeComprasView();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            newMDIChild.StartPosition = FormStartPosition.CenterScreen;
            newMDIChild.Dock = DockStyle.Fill;
            // Display the new form.  
            newMDIChild.Show();
            lblTitleScreen.Text = "Listas de compras";
        }
    }
}
