using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LP2.Model
{
    class ProdutosLista
    {
        private int id, quantidade, id_lista;
        private string nome, id_produto;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Id_lista
        {
            get
            {
                return id_lista;
            }

            set
            {
                id_lista = value;
            }
        }

        public string Id_produto
        {
            get
            {
                return id_produto;
            }

            set
            {
                id_produto = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return quantidade;
            }

            set
            {
                quantidade = value;
            }
        }
    }
}
