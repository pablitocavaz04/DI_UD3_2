using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DI_UD3_2
{
    public class Empleado
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Empleado(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }
    }
    internal class Program
    {

        public delegate bool FiltroEmpleado(Empleado empleado);

        public static void FiltrarEmpleados(List<Empleado> empleados, FiltroEmpleado filtro)
        {
            Console.WriteLine("Empleados mayores de 30 años:");
            foreach (var empleado in empleados)
            {
                if (filtro(empleado))
                {
                    Console.WriteLine($"- {empleado.Nombre} (Edad: {empleado.Edad})");
                }
            }
        }

        public static void Main()
        {
            List<Empleado> empleados = new List<Empleado>
            {
                new Empleado("Ana", 35),
                new Empleado("Luis", 42),
                new Empleado("Carlos", 28),
                new Empleado("Marta", 25)
            };

            FiltroEmpleado filtroEdad = delegate (Empleado empleado)
            {
                return empleado.Edad > 30;
            };

            FiltrarEmpleados(empleados, filtroEdad);
        }
    }
}
