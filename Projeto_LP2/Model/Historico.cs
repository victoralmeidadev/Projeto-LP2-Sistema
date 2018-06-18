using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LP2.Model
{
    public class Historico
    {
        private string nome_produto, nome_supermercado, data, hora;
        private double preco;

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public string Hora
        {
            get
            {
                return hora;
            }

            set
            {
                hora = value;
            }
        }

        public string Nome_produto
        {
            get
            {
                return nome_produto;
            }

            set
            {
                nome_produto = value;
            }
        }

        public string Nome_supermercado
        {
            get
            {
                return nome_supermercado;
            }

            set
            {
                nome_supermercado = value;
            }
        }

        public double Preco
        {
            get
            {
                return preco;
            }

            set
            {
                preco = value;
            }
        }
    }
}
