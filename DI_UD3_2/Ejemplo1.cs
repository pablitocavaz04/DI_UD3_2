using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD3_2
{
    internal class Program
    {
        public delegate string ObtenerDelegadoTexto(string nombre);
        static void Main(string[] args)
        {
            ObtenerDelegadoTexto miDelegado = delegate (string nombre)
            {
                return "Hola, " + nombre;
            };
            Console.WriteLine(miDelegado("Pablo"));
            Mostrar(miDelegado);
        }
        static void Mostrar (ObtenerDelegadoTexto miDelegado)
        {
            Console.WriteLine(miDelegado("España"));
        }
    }
}
