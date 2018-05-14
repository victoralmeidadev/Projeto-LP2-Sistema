using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LP2.Model
{
    class Historico
    {
        private string nome_produto, nome_supermercado, data, hora;
        private double preco;

        public string Nome_produto { get => nome_produto; set => nome_produto = value; }
        public string Nome_supermercado { get => nome_supermercado; set => nome_supermercado = value; }
        public string Data { get => data; set => data = value; }
        public string Hora { get => hora; set => hora = value; }
        public double Preco { get => preco; set => preco = value; }
    }
}
