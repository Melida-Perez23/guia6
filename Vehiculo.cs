using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Vehiculo
    {
        public virtual void RealizarMantenimeinto()
        {
            Console.WriteLine("Realizando Mantenimento general del vehiculo");
        }


        public virtual double ObtenerCostoMantenimiento()
        {
            return 50.0;
        }
        public void lavar()
        {
            Console.WriteLine("lavando el coche");
        }
        public virtual int ObtenerTiempoEstimadoMantenimiento()
        {
            return 60; 
        }
    }

}

