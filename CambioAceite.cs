using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class CambioAceite : Servicio
    {
        public override void RealizarServicio()
        {
            Console.WriteLine("realizando cambio de aceite");
        }
        public override double CalculaCosto()
        {
            return 50.0;
        }
    }
}
