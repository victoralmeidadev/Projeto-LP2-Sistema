using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections.ObjectModel;

namespace Projeto_LP2.Interfaces
{
    interface IDAO<T>:IDisposable
        where T: class, new()
    {
        //metodo para inserir
        int Inserir(T model);

        //metodo para atualizar
        void Atualizar(T model);

        //metodo para remover
        bool Remover(T model);

        //metodo para procurar um registro especifico
        T LocalizarPorCodigo(params Object[] keys);

        //metodo para encontrar tudo
        Collection<T> ListarTudo();

        //funcao para historico
        Collection<T> ListarHistoricoPorSupermercado();
        
        Collection<T> ListarHistoricoPorProduto(string supermercado);




    }
}
