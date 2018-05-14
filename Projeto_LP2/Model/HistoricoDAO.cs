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
    class HistoricoDAO : IDAO<Historico>, IDisposable
    {
        //conexao com o banco
        private IConnection conn;

        public HistoricoDAO(IConnection Connection)
        {
            this.conn = Connection;
        }

        public void Atualizar(Historico model)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            conn.Fechar();
            GC.SuppressFinalize(this);
        }

        public int Inserir(Historico model)
        {
            throw new NotImplementedException();
        }

        public Collection<Historico> ListarTudo()
        {
            throw new NotImplementedException();
        }

   

        public Collection<Historico> ListarHistoricoPorSupermercado()
        {
            Collection<Historico> colecao = new Collection<Historico>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select p.prod_nome, s.sup_nome, AVG(his_preco) as Preco_Medio from produto p, supermercado s, historico h " +
                    "WHERE p.prod_codigo = h.his_idProduto AND s.id_supermercado = h.his_idSupermercado " +
                    "GROUP BY h.his_idProduto, h.his_idSupermercado " +
                    "ORDER BY h.his_data;";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Historico historico = new Historico
                        {
                            Nome_produto = row["prod_nome"].ToString(),
                            Preco = Convert.ToDouble(row["Preco_Medio"].ToString()),
                            Nome_supermercado = row["sup_nome"].ToString()
                        };
                        colecao.Add(historico);
                    }
                }
            }
            return colecao;

        }

        public Collection<Historico> ListarHistoricoPorProduto(string id_supermercado)
        {
            Collection<Historico> colecao = new Collection<Historico>();

            using (MySqlCommand cmd = conn.Buscar().CreateCommand())
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "select p.prod_nome, h.his_preco from historico h, produto p, supermercado s " +
                    "where p.prod_codigo = h.his_idProduto and s.id_supermercado = h.his_idSupermercado and h.his_idSupermercado = '"+id_supermercado.ToString()+"'"+
                    "GROUP BY h.his_idProduto;";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);

                    foreach (DataRow row in tabela.Rows)
                    {
                        Historico historico = new Historico
                        {
                            Nome_produto = row["prod_nome"].ToString(),
                            Preco = Convert.ToDouble(row["Preco_Medio"].ToString()),
                            Nome_supermercado = row["sup_nome"].ToString()
                        };
                        colecao.Add(historico);
                    }
                }
            }
            return colecao;

        }


        public Historico LocalizarPorCodigo(params object[] keys)
        {
            throw new NotImplementedException();
        }

        public bool Remover(Historico model)
        {
            throw new NotImplementedException();
        }

    }
}

