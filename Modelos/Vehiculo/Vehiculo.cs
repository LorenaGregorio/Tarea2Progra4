using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Vehiculo
{
    public class Vehiculo
    {
        public int?  IdVehiculo { get; set; }
        public string TipodeVehiculo { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Modelo { get; set; }
        public string Transmision { get; set; }
        public string Color { get; set; }
    }
}
