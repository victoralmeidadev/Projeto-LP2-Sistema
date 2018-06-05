using MySql.Data.MySqlClient;
using Projeto_LP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_LP2.Model
{
    class ProdutosListasDAO : IDAO<ProdutosLista>, IDisposable
    {
        //conexao com o banco
        private IConnection conn;

        public ProdutosListasDAO(IConnection Connection)
        {
            this.conn = Connection;
        }

        public void Atualizar(ProdutosLista model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Inserir(ProdutosLista model)
        {
            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO produtos_listas(pro_lista, pro_nome, pro_idProduto, pro_quantidade) " +
                "VALUES(@pro_lista, @pro_nome, @pro_idProduto, @pro_quantidade);";

                cmd.Parameters.AddWithValue("@pro_lista", model.Id_lista);
                cmd.Parameters.AddWithValue("@pro_nome", model.Nome);
                cmd.Parameters.AddWithValue("@pro_idProduto", model.Id_produto);
                cmd.Parameters.AddWithValue("@pro_quantidade", model.Quantidade);


                try
                {
                    cmd.ExecuteNonQuery();
                    return 1;
                }
                catch
                {
                    return 0;
                }

            }
        }

        public Collection<ProdutosLista> ListarHistoricoPorProduto(string supermercado)
        {
            throw new NotImplementedException();
        }

        public Collection<ProdutosLista> ListarHistoricoPorSupermercado()
        {
            throw new NotImplementedException();
        }

        public Collection<ProdutosLista> ListarTudo()
        {
            Collection<ProdutosLista> colecao = new Collection<ProdutosLista>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select * from produtos_listas;";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        ProdutosLista produto = new ProdutosLista
                        {
                            Id = int.Parse(row["id_produtolistas"].ToString()),
                            Id_produto = row["pro_idProduto"].ToString(),
                            Nome = row["pro_nome"].ToString(),
                            Quantidade = int.Parse(row["pro_quantidade"].ToString()),
                            Id_lista = int.Parse(row["pro_lista"].ToString())
                        };
                        colecao.Add(produto);
                    }

                }
            }
            return colecao;
        }

        public Collection<ProdutosLista> LocalizarPorCodigo(ProdutosLista model)
        {
            throw new NotImplementedException();
        }

        public bool Remover(ProdutosLista model)
        {
            throw new NotImplementedException();
        }
    }
}
