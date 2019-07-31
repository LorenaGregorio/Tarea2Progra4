using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeoDal.Reader
{
    abstract class ObjectReaderWithConection<T> : ObjectReaderBase<T>
    {
        private static string ConnectionString = @"Server=localhost;DataBase=odeodal;Uid=root";
        //Sobre Escribir un metodo ya existente
        protected override IDbConnection GetConnection()
        {
            IDbConnection connection = new MySqlConnection(ConnectionString);
            return connection;
        }
    }
}
