using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo miCoche = new Coche();
            miCoche.RealizarMantenimeinto();
            miCoche.ObtenerTiempoEstimadoMantenimiento();
            Console.WriteLine("Costo del mantenimento del coche: $" + miCoche.ObtenerCostoMantenimiento());
            Console.WriteLine("El timpo del mantenimiento es: " + miCoche.ObtenerTiempoEstimadoMantenimiento());

            miCoche.lavar();
            Coche miCocheReal = new Coche();
            miCocheReal.lavar();

            Vehiculo miMoto = new Moto();
            miMoto.RealizarMantenimeinto();
            Console.WriteLine("Costo del mantenimiento de la moto: $" + miMoto.ObtenerCostoMantenimiento());
            Console.WriteLine("El timpo del mantenimiento es: " + miMoto.ObtenerTiempoEstimadoMantenimiento());

            Servicio servicioAceite = new CambioAceite();
            servicioAceite.RealizarServicio(); // Output: Realizando cambio de aceite.
            Console.WriteLine("Costo del cambio de aceite: $" + servicioAceite.CalculaCosto());

            Servicio servicioFrenos = new ReparacionFrenos();
            servicioFrenos.RealizarServicio(); // Output: Realizando reparación de frenos.
            Console.WriteLine("Costo de la reparación de frenos: $" + servicioFrenos.CalculaCosto());


            //Servicio ser = new Servicio();  bueno hasta donde yo se no se puede instanciar una clase abstrata por eso nos da error pero la
            // podemos instancia mediante sus clase hijas 

        }
    }
}

