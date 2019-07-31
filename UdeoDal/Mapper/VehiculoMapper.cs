using Modelos.Vehiculo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeoDal.Mapper
{
    internal class VehiculoMapper: MapperBase<Vehiculo>
    {
        public object DBnull { get; private set; }

        protected override Vehiculo Map(IDataRecord registro)
        {
            try
            {
                //mapeo mi modelo con los datos de la base de datos
                Vehiculo vehiculo1 = new Vehiculo
                {
                    IdVehiculo = registro["IdVehiculo"] == DBNull.Value ? 0 : (int)registro["IdVehiculo"],
                    TipodeVehiculo = registro["TipodeVehiculo"] == DBNull.Value ? string.Empty : (string)registro["TipodeVehiculo"],
                    Marca = registro["Marca"] == DBNull.Value ? string.Empty : (string)registro["Marca"],
                    Linea = registro["Linea"] == DBNull.Value ? string.Empty : (string)registro["Linea"],
                    Modelo = registro["Modelo"] == DBNull.Value ? string.Empty : (string)registro["Modelo"],
                    Transmision = registro["Transmision"] == DBNull.Value ? string.Empty : (string)registro["Transmision"],
                    Color = registro["Color"] == DBNull.Value ? string.Empty : (string)registro["Color"],




                };
                return vehiculo1;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
    }
}
