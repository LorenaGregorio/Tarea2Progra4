using Modelos;
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
    class PersonaReader : ObjectReaderWithConection<PersonaModel>
    {
        protected override string CommandText => "SELECT * FROM  persona";

        // flecha indica retorno =>
        protected override CommandType CommandType => CommandType.Text;

        protected override MapperBase<PersonaModel> GetMapper()
        {
            MapperBase<PersonaModel> mapper = new PersonaMapper();
            return mapper;
        }

        protected override Collection<IDataParameter> GetParameters(IDbCommand command)
        {
            Collection<IDataParameter> dataParameters = new Collection<IDataParameter>();
            return dataParameters;

        } 
    }
}
