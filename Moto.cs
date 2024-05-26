using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Moto : Vehiculo
    {
        public override void RealizarMantenimeinto()
        {
            Console.WriteLine("Realizando Mantenimento de la moto: lubricantes de cadenas y revision de neumatico");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 100.0;
        }
        public override int ObtenerTiempoEstimadoMantenimiento()
        {
            return 45;
        }
    }
}
