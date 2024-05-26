using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class ReparacionFrenos : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("reparando los frenos");
        }
        public override double CalculaCosto()
        {
            return 100.0;
        }
    }
}
