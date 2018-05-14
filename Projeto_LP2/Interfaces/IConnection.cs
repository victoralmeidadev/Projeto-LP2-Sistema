using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projeto_LP2.Interfaces
{
    interface IConnection : IDisposable
    {
        MySqlConnection Abrir();

        MySqlConnection Buscar();

        void Fechar();
    }
}
