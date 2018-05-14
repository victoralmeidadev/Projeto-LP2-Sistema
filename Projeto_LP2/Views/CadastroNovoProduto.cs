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
    public partial class CadastroNovoProduto : Form
    {
        public CadastroNovoProduto()
        {
            InitializeComponent();
        }

        private void BtnCadastrarNovoProduto_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutoDAO = new ProdutoDAO(conn);

                if(radioButtonNao.Checked || radioButtonSim.Checked)
                {
                    Produto produto = new Produto();

                    produto.NomeProduto = txtNomeNovoProduto.Text.ToString().Trim();
                    produto.Supermercado = cBoxSupermercadoNovoProduto1.SelectedValue.ToString().Trim();
                    produto.Codigo = txtCodigoNovoProduto.Text.ToString().Trim();
                    produto.Preco = double.Parse(txtPrecoNovoProduto1.Text.ToString().Trim());
                    ProdutoDAO.Inserir(produto);

                    if (txtPrecoNovoProduto2.Enabled)
                    {
                        Produto produtoConcorrente = new Produto();
                        produtoConcorrente.NomeProduto = txtNomeNovoProduto.Text.ToString().Trim();
                        produtoConcorrente.Supermercado = cBoxSupermercadoNovoProduto2.SelectedValue.ToString().Trim();
                        produtoConcorrente.Codigo = txtCodigoNovoProduto.Text.ToString().Trim();
                        produtoConcorrente.Preco = double.Parse(txtPrecoNovoProduto2.Text.ToString().Trim());
                        ProdutoDAO.Inserir(produtoConcorrente);
                    }

                    Dispose();

                }
            }
        }
        private void OpcaoProdutoConcorrente(bool opcao)
        {
            txtPrecoNovoProduto2.Enabled = opcao;
            cBoxSupermercadoNovoProduto2.Enabled = opcao;

        }

        private void RadioButtonSim_Click(object sender, EventArgs e)
        {
            OpcaoProdutoConcorrente(true);
            
        }

        private void RadioButtonNao_Click(object sender, EventArgs e)
        {
            OpcaoProdutoConcorrente(false);

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void CadastroNovoProduto_Load(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Supermercado> SupermercadoDAO = new SupermercadoDAO(conn);
                Supermercado supermercado = new Supermercado();
                cBoxSupermercadoNovoProduto1.DisplayMember = "nome";
                cBoxSupermercadoNovoProduto1.ValueMember = "id";
                cBoxSupermercadoNovoProduto2.DisplayMember = "nome";
                cBoxSupermercadoNovoProduto2.ValueMember = "id";
                cBoxSupermercadoNovoProduto1.DataSource = SupermercadoDAO.ListarTudo();
                cBoxSupermercadoNovoProduto2.DataSource = SupermercadoDAO.ListarTudo();
                
            }
        }

        private void radioButtonSim_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
