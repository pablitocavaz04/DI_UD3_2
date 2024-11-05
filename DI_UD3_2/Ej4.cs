using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DI_UD3_2
{
    internal class Program
    {
        public delegate bool CompararLongitud(string cadena1, string cadena2);

        public static void Main()
        {
            CompararLongitud mismaLongitud = delegate (string cadena1, string cadena2)
            {
                return cadena1.Length == cadena2.Length;
            };

            string palabra1 = "gato";
            string palabra2 = "perro";

            Console.WriteLine($"Las palabras '{palabra1}' y '{palabra2}' tienen la misma longitud = {mismaLongitud(palabra1, palabra2)}");
        }
    }
}
