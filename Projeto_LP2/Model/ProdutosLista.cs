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

        public int Id { get => id; set => id = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Id_produto { get => id_produto; set => id_produto = value; }
        public int Id_lista { get => id_lista; set => id_lista = value; }
    }
}
