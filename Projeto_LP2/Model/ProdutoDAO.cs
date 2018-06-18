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
            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE produto SET prod_nome= @nome, prod_preco= @preco, prod_categoria = @categoria, prod_codigo = @codigo where id_produto= @id;";
                cmd.Parameters.AddWithValue("@nome", model.NomeProduto);
                cmd.Parameters.AddWithValue("@preco", model.Preco);
                cmd.Parameters.AddWithValue("@id", model.Id);
                cmd.Parameters.AddWithValue("@categoria", model.Categoria);
                cmd.Parameters.AddWithValue("@codigo", model.Codigo);

                try
                {
                    cmd.ExecuteNonQuery();
                   
                }
                catch
                {
                    Dispose();
                }

            }
            

        }

        public int Inserir(Produto model)
        {

            using(MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO produto(prod_nome, prod_codigo, prod_preco, prod_supermercado, prod_categoria) " +
                "VALUES(@nome, @codigo, @preco, @supermercado, @categoria);";

                cmd.Parameters.AddWithValue("@nome", model.NomeProduto);
                cmd.Parameters.AddWithValue("@codigo", model.Codigo);
                cmd.Parameters.AddWithValue("@preco", model.Preco);
                cmd.Parameters.AddWithValue("@supermercado", int.Parse(model.Supermercado));
                cmd.Parameters.AddWithValue("@categoria", int.Parse(model.Categoria));

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
                cmd.CommandText = "SELECT p.*, s.sup_nome, c.cat_nome FROM produto p, supermercado s, categoria c " +
                    "WHERE p.prod_supermercado = s.id_supermercado and p.prod_categoria = c.id_categoria " +
                    "ORDER BY p.prod_nome";

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
                            Supermercado = row["sup_nome"].ToString(),
                            Codigo = row["prod_codigo"].ToString(),
                            Categoria = row["cat_nome"].ToString()
                        };
                        colecao.Add(produto);
                    }
                }
            }
            return colecao;
        }

        public Collection<Produto> LocalizarPorCodigo(Produto model)
        {
            Collection<Produto> colecao = new Collection<Produto>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT p.*, s.sup_nome, c.cat_nome FROM produto p, supermercado s, categoria c " +
                    "WHERE p.prod_nome like @value and p.prod_supermercado = s.id_supermercado and p.prod_categoria = c.id_categoria " +
                    "ORDER BY p.prod_nome;";

                cmd.Parameters.AddWithValue("@value", "%"+ model.NomeProduto + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Produto produto = new Produto
                        {
                            Id = int.Parse(row["id_produto"].ToString()),
                            NomeProduto = row["prod_nome"].ToString(),
                            Codigo = row["prod_codigo"].ToString(),
                            Preco = double.Parse(row["prod_preco"].ToString()),
                            Supermercado = row["sup_nome"].ToString(),
                            Categoria = row["cat_nome"].ToString()
                        };
                        colecao.Add(produto);
                    }
                }
                return colecao;
            }
        }

        public bool Remover(Produto model)
        {
            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "DELETE FROM produto WHERE id_produto = @id";

                cmd.Parameters.AddWithValue("@id", model.Id);

                try
                {
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch
                {
                    return false;
                }

            }

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
