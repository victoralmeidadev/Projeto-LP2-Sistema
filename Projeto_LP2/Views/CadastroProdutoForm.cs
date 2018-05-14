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
    public partial class CadastroProdutoForm : Form
    {
        public CadastroProdutoForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnCadastraProduto_click(object sender, EventArgs e)
        {
           using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutoDAO = new ProdutoDAO(conn);

                Produto produto = new Produto();

                produto.NomeProduto = cBoxProduto.Text.ToString();
                produto.Supermercado = cBoxSupermercado.SelectedValue.ToString();
                produto.Codigo = cBoxProduto.SelectedValue.ToString();
                produto.Preco = double.Parse(txtPrecoProduto.Text.ToString());

                ProdutoDAO.Inserir(produto);
                Dispose();
            }
            
        }

        private void CBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroProdutoLoad(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                IDAO<Supermercado> SupermercadoDAO = new SupermercadoDAO(conn);

                Produto produto = new Produto();
                Supermercado supermercado = new Supermercado();

                cBoxProduto.DisplayMember = "nomeProduto";
                cBoxProduto.ValueMember = "codigo";
                
                cBoxProduto.DataSource = ProdutosDAO.ListarTudo();

                cBoxSupermercado.DisplayMember = "nome";
                cBoxSupermercado.ValueMember = "id";
                cBoxSupermercado.DataSource = SupermercadoDAO.ListarTudo();
                conn.Fechar();
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void cBoxProduto_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
