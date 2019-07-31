using System;
using System.Data;
using Modelos;
using UdeoDal.Mapper;

namespace UdeoDal.Reader
{
    internal class PersonaMapper : MapperBase<PersonaModel>
    {
        public object DBnull { get; private set; }

        protected override PersonaModel Map(IDataRecord registro)
        {
            try
            {
                //mapeo mi modelo con los datos de la base de datos
                PersonaModel persona = new PersonaModel
                {
                    IdPersona = registro ["IdPersona"] == DBNull.Value ?  0 : (int) registro ["IdPersona"],
                    Nombre= registro ["Nombre"] == DBNull.Value ? string.Empty : (string) registro ["Nombre"],
                    Apellido = registro["Apellido"] == DBNull.Value ? string.Empty : (string)registro["Apellido"],
                    Direccion = registro["Direccion"] == DBNull.Value ? string.Empty : (string)registro["Direccion"],



                };
                return persona;
            }
            catch (System.Exception)
            {

                throw;
            } 
        }
    }
}