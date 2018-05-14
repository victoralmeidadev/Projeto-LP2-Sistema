using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_LP2.Interfaces;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LP2.Model
{
    class ProdutoDAO:IDAO<Produto>, IDisposable
    {
        //conexao com o banco
        private IConnection conn;

        public ProdutoDAO(IConnection Connection)
        {
            this.conn = Connection;
        }

        public void Atualizar(Produto model)
        {
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "UPDATE produtos SET prod_nome=@nome, prod_codigo=@codigo, prod_preco=@preco, prod_supermercado=@supermercado where" +
                "id_produtos=@id;";

            cmd.Parameters.AddWithValue("@nome", model.NomeProduto);
            cmd.Parameters.AddWithValue("@codigo", model.Codigo);
            cmd.Parameters.AddWithValue("@preco", model.Preco);
            cmd.Parameters.AddWithValue("@supermercado", model.Supermercado);
            cmd.Parameters.AddWithValue("@id", model.Id);
            conn.Buscar();
            cmd.ExecuteNonQuery();           
            conn.Fechar();
            

        }

        public int Inserir(Produto model)
        {

            using(MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO produto(prod_nome, prod_codigo, prod_preco, prod_supermercado) " +
                "VALUES(@nome, @codigo, @preco, @supermercado);";

                cmd.Parameters.AddWithValue("@nome", model.NomeProduto);
                cmd.Parameters.AddWithValue("@codigo", model.Codigo);
                cmd.Parameters.AddWithValue("@preco", model.Preco);
                cmd.Parameters.AddWithValue("@supermercado", model.Supermercado);

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

        public Collection<Produto> ListarTudo()
        {
            Collection<Produto> colecao = new Collection<Produto>();

            using(MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM produto GROUP BY prod_codigo ORDER BY prod_nome";

                using(MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach(DataRow row in tabela.Rows)
                    {
                        Produto produto = new Produto
                        {
                            Id = int.Parse(row["id_produto"].ToString()),
                            NomeProduto = row["prod_nome"].ToString(),
                            Preco = Convert.ToDouble(row["prod_preco"].ToString()),
                            Supermercado = row["prod_supermercado"].ToString(),
                            Codigo = row["prod_codigo"].ToString()
                        };
                        colecao.Add(produto);
                    }
                }
            }
            return colecao;
        }

        public Produto LocalizarPorCodigo(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public bool Remover(Produto model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            conn.Fechar();
            GC.SuppressFinalize(this);
        }

        public Collection<Produto> ListarHistoricoPorSupermercado()
        {
            throw new NotImplementedException();
        }

        public Collection<Produto> ListarHistoricoPorProduto()
        {
            throw new NotImplementedException();
        }

        public Collection<Produto> ListarHistoricoPorProduto(string supermercado)
        {
            throw new NotImplementedException();
        }
    }
}
