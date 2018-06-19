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
        private int idSelecionado;
        public int IdSelecionado
        {
            get
            {
                return idSelecionado;
            }

            set
            {
                idSelecionado = value;
            }
        }
        public CadastroSupermercadoForm()
        {
            InitializeComponent();
        }
        public CadastroSupermercadoForm(Supermercado supermercado)
        {
            InitializeComponent();
            txtNomeSupermercado.Text = supermercado.Nome;
            this.idSelecionado = supermercado.Id;
            btnCadastraSupermercado.Text = "Finalizar Edição";
            
        }

        private void CadastroSupermercadoForm_Load(object sender, EventArgs e)
        {

        }


        private void BtnCadastraSupermercado_Click(object sender, EventArgs e)
        {
            if(btnCadastraSupermercado.Text.Equals("Finalizar Edição"))
            {
                using (IConnection conn = new Connection())
                {
                    conn.Abrir();
                    IDAO<Supermercado> SupermercadoDAO = new SupermercadoDAO(conn);
                    Supermercado supermercado = new Supermercado();
                    supermercado.Nome = txtNomeSupermercado.Text;
                    supermercado.Id = this.idSelecionado;
                    SupermercadoDAO.Atualizar(supermercado);
                    Dispose();
                }

            }
            else
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

            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
