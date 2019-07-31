using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdeoDal.Mapper
{
    //ES UNA PLANTILLA , CON FUNCIONALIDAD
    //NO PUEDE HEREDAR DE N CLASES O INTERFACES
    //EN ESO DIFIERE CON LA INTERFAZ
    //PUEDE TENER FUNCIONALIDAD\
    //T ==> Generico, es decir puede procesar cualquier clase
    //O modelo para lo que este hecho.
    abstract class MapperBase<T>
    {
        protected abstract T Map(IDataRecord registro);
        //Retornar la informacino ya mapeada
        public Collection<T> MapAll(IDataReader lector)
        {
            Collection<T> coleccion = new Collection<T>();
            //Validar cada propiedad del objeto
            while (lector.Read())
            {
                //agregar el objeto a la colleccion ya mapeado
                coleccion.Add(Map(lector));
            }
            return coleccion;
        }
    }
}





















