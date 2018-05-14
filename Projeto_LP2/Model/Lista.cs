using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LP2.Model
{
    class Lista
    {
        private int id;
        private string nome;
        private List<ProdutosLista> produtosLista = new List<ProdutosLista>();

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        internal List<ProdutosLista> ProdutosLista { get => produtosLista; set => produtosLista = value; }
    }
}
