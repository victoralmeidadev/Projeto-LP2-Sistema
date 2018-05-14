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
                conn.Abrir();
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
                cBoxSupermercadoProduto.DataSource = SupermercadoDAO.ListarTudo();

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

    

        private void CBoxEscolheVisualizacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBoxEscolheVisualizacao.Text.Equals("Produtos"))
            {
                //true para campos por tipo produto, false para mercado
                mostraCamposVisualizacao(true);
            }
            else
            {
                mostraCamposVisualizacao(false);
            }
        }

        private void mostraCamposVisualizacao(bool visible)
        {
            
            lblProduto.Visible = visible;
            lblSupermercadoProduto.Visible = visible;
            cBoxProduto.Visible = visible;
            cBoxSupermercadoProduto.Visible = visible;
            lblSupermercado1.Visible = !visible;
            lblSupermercado2.Visible = !visible;
            cBoxSupermercado1.Visible = !visible;
            cBoxSupermercado2.Visible = !visible;
            btnVisualizarHistorico.Visible = true;
            
        }

        private void btnVisualizarHistorico_Click(object sender, EventArgs e)
        {
            if (lblProduto.Visible)
            {
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<Historico> HistoricoDAO = new HistoricoDAO(conn);

                    
                   
                    graficoHistorico.DataSource = HistoricoDAO.ListarHistoricoPorProduto(cBoxSupermercadoProduto.Text.ToString());
                    graficoHistorico.DataBind();
                    conn.Fechar();
                }
            }
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
    }
}
