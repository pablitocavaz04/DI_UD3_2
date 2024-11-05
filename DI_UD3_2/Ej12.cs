using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DI_UD3_2
{
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int AnioFabricacion { get; set; }

        public Vehiculo(string marca, string modelo, int anioFabricacion)
        {
            Marca = marca;
            Modelo = modelo;
            AnioFabricacion = anioFabricacion;
        }
    }

    internal class Program
    {
        public delegate bool FiltroVehiculo(Vehiculo vehiculo);

        public static void MostrarVehiculosAntiguos(List<Vehiculo> vehiculos, FiltroVehiculo filtro)
        {
            Console.WriteLine("Vehículos fabricados antes de 2010:");
            foreach (var vehiculo in vehiculos)
            {
                if (filtro(vehiculo))
                {
                    Console.WriteLine($"- {vehiculo.Marca} {vehiculo.Modelo} ({vehiculo.AnioFabricacion})");
                }
            }
        }

        public static void Main()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>
            {
                new Vehiculo("Toyota", "Corolla", 2005),
                new Vehiculo("Seat", "Ibiza", 2003),
                new Vehiculo("Ford", "Focus", 2012),
                new Vehiculo("Honda", "Civic", 2015)
            };

            FiltroVehiculo filtroAntiguos = delegate (Vehiculo vehiculo)
            {
                return vehiculo.AnioFabricacion < 2010;
            };

            MostrarVehiculosAntiguos(vehiculos, filtroAntiguos);
        }
    }
}
