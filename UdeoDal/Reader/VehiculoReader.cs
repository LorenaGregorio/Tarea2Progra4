using Modelos.Vehiculo;
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
    class VehiculoReader : ObjectReaderWithConection<Vehiculo>
    {
        protected override string CommandText => "SELECT * FROM  vehiculotbl";

        protected override CommandType CommandType => CommandType.Text;

        protected override MapperBase<Vehiculo> GetMapper()
        {
            MapperBase<Vehiculo> mapper = new VehiculoMapper();
            return mapper;
        }

        protected override Collection<IDataParameter> GetParameters(IDbCommand command)
        {
            Collection<IDataParameter> dataParameters = new Collection<IDataParameter>();
            return dataParameters;
        }
    }
}
