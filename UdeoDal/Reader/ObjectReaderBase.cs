using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdeoDal.Mapper;

namespace UdeoDal.Reader
{
    abstract class ObjectReaderBase<T>
    {
        protected abstract IDbConnection GetConnection();
        protected abstract string CommandText { get; }
        protected abstract CommandType CommandType { get; }
        protected abstract Collection<IDataParameter> GetParameters(IDbCommand command);
        protected abstract MapperBase<T> GetMapper();
        public Collection<T> Execute()
        {
            Collection<T> coleccion = new Collection<T>();
            using (IDbConnection connection = GetConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = this.CommandText;
                command.CommandType = this.CommandType;
                //Agregando parametros al comando
                foreach (IDbDataParameter parametro in this.GetParameters(command))
                {
                    command.Parameters.Add(parametro);
                }
                try
                {
                    connection.Open();
                    //Leyendo la informacion
                    using (IDataReader lector = command.ExecuteReader())
                    {
                        try
                        {
                            MapperBase<T> mapper = GetMapper();
                            coleccion = mapper.MapAll(lector);
                            return coleccion;
                        }
                        catch (Exception)
                        {
                            //cerramos la conexion
                            connection.Close();
                            //cerramos el lector
                            lector.Close();
                            throw;
                        }
                    }
                }
                catch (Exception)
                {

                    throw;
                }

            }

        }
    }
}









