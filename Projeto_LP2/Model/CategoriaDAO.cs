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
    class CategoriaDAO : IDAO<Categoria>, IDisposable
    {
        private IConnection conn;

        public CategoriaDAO(IConnection conn)
        {
            this.conn = conn;
        }

        public void Atualizar(Categoria model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Inserir(Categoria model)
        {
            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO categoria(cat_nome) VALUES (@nome);";

                cmd.Parameters.AddWithValue("@nome", model.Nome);

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

        public Collection<Categoria> ListarHistoricoPorProduto(string supermercado)
        {
            throw new NotImplementedException();
        }

        public Collection<Categoria> ListarHistoricoPorSupermercado()
        {
            throw new NotImplementedException();
        }

        public Collection<Categoria> ListarTudo()
        {
            Collection<Categoria> colecao = new Collection<Categoria>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM categoria ORDER BY cat_nome";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Categoria categoria = new Categoria
                        {
                            Id = int.Parse(row["id_categoria"].ToString()),
                            Nome = row["cat_nome"].ToString(),

                        };
                        colecao.Add(categoria);
                    }
                }
            }
            return colecao;
        }

        public Collection<Categoria> LocalizarPorCodigo(Categoria model)
        {
            throw new NotImplementedException();
        }

        public bool Remover(Categoria model)
        {
            throw new NotImplementedException();
        }
    }
}
