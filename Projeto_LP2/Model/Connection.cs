using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Projeto_LP2.Interfaces;

namespace Projeto_LP2.Model
{
    class Connection : IConnection, IDisposable
    {
        private MySqlConnection conn;

        public Connection()
        {
            conn = new MySqlConnection();
            conn.ConnectionString = "Server=localhost; Database=projeto; Uid=root; Pwd=ifsp;";
        }
        
        public MySqlConnection Abrir()
        {
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
            }

            return conn;
        }

        public MySqlConnection Buscar()
        {
            return this.Abrir();

        }

        public void Fechar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }

        }


        public void Dispose()
        {
            this.Fechar();
            GC.SuppressFinalize(this);
        }
    }
}
