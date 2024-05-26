using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Coche : Vehiculo
    {
        public override void RealizarMantenimeinto()
        {
            Console.WriteLine("Realizando Mantenimento al coche: cambio de aceite y revision de frenos");
        }
        public override double ObtenerCostoMantenimiento()
        {
            return 150.0;
        }

        public new void lavar()
        {
            Console.WriteLine("lavando el coche con cera y shampoo");
       
        }
        public override int ObtenerTiempoEstimadoMantenimiento()
        {
            return 90;
        }

    }
}
