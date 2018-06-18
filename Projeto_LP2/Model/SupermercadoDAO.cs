using Projeto_LP2.Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projeto_LP2.Model
{
    class SupermercadoDAO : IDAO<Supermercado>, IDisposable
    {
        //conexao com o banco
        private IConnection conn;

        public SupermercadoDAO(IConnection Connection)
        {
            this.conn = Connection;
        }

        public void Atualizar(Supermercado model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            conn.Fechar();
            GC.SuppressFinalize(this);
        }

        public int Inserir(Supermercado model)
        {
            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO supermercado(sup_nome) VALUES (@NOME);";

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

        public Collection<Supermercado> ListarHistoricoPorProduto()
        {
            throw new NotImplementedException();
        }

        public Collection<Supermercado> ListarHistoricoPorProduto(string supermercado)
        {
            throw new NotImplementedException();
        }

        public Collection<Supermercado> ListarHistoricoPorSupermercado()
        {
            throw new NotImplementedException();
        }

        public Collection<Supermercado> ListarTudo()
        {
            Collection<Supermercado> colecao = new Collection<Supermercado>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM supermercado ORDER BY sup_nome";
                
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Supermercado supermercado = new Supermercado
                        {
                            Id = int.Parse(row["id_supermercado"].ToString()),
                            Nome = row["sup_nome"].ToString(),
                            
                        };
                        colecao.Add(supermercado);
                    }
                }
            }
            return colecao;
        }

        public Collection<Supermercado> LocalizarPorCodigo(Supermercado model)
        {
            Collection<Supermercado> colecao = new Collection<Supermercado>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM supermercado WHERE sup_nome like @value;";

                cmd.Parameters.AddWithValue("@value", "%" + model.Nome + "%");

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Supermercado supermercado = new Supermercado
                        {
                            Id = int.Parse(row["id_supermercado"].ToString()),
                            Nome = row["sup_nome"].ToString()
                        };
                        colecao.Add(supermercado);
                    }
                }
                return colecao;
            }
        }

        public bool Remover(Supermercado model)
        {
            throw new NotImplementedException();
        }
    }
}
