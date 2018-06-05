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
    public partial class NovoProdutoListaForm : Form
    {
        public NovoProdutoListaForm()
        {
            InitializeComponent();
        }
        public NovoProdutoListaForm(string id_lista)
        {
            InitializeComponent();
            txtIdLista.Text = id_lista.ToString();
        }

        private void NovoProdutoListaForm_Load(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<Produto> ProdutosDAO = new ProdutoDAO(conn);
                Produto produto = new Produto();
                cBoxProduto.DisplayMember = "nomeProduto";
                cBoxProduto.ValueMember = "codigo";
                cBoxProduto.DataSource = ProdutosDAO.ListarTudo();
                
            }
        }

        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            using (IConnection conn = new Connection())
            {
                conn.Abrir();
                IDAO<ProdutosLista> ProdutosListasDAO = new ProdutosListasDAO(conn);
                ProdutosLista produto = new ProdutosLista();
                produto.Nome = cBoxProduto.Text.ToString().Trim();
                produto.Id_lista = int.Parse(txtIdLista.Text.ToString().Trim());
                produto.Id_produto = cBoxProduto.SelectedValue.ToString();
                produto.Quantidade = int.Parse(txtQuantidade.Text.ToString().Trim());
                ProdutosListasDAO.Inserir(produto);
                Dispose();
            }
        }

        private void txtIdLista_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
