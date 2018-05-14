using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LP2.Model
{
    class Produto
    {
        private int id;
        private string nomeProduto, supermercado, codigo;
        private double preco;

        public int Id { get => id; set => id = value; }
        public string NomeProduto { get => nomeProduto; set => nomeProduto = value; }
        public string Supermercado { get => supermercado; set => supermercado = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public double Preco { get => preco; set => preco = value; }
    }
}
