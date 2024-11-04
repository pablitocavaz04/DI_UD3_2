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
        public delegate bool EsMayorQueDiez(string texto);

        public static void Main()
        {
            EsMayorQueDiez esPalindromo = delegate (string texto)
            {
                string limpio = Regex.Replace(texto, "[^a-zA-Z0-9]", "").ToLower();
                string invertido = new string(limpio.Reverse().ToArray());
                return limpio == invertido;
            };

            string palabra1 = "radar";
            string palabra2 = "puerta";
            string frase = "dabale arroz a la zorra el abad";

            Console.WriteLine($"{palabra1} es un palíndromo = {esPalindromo(palabra1)}");
            Console.WriteLine($"{palabra2} es un palíndromo = {esPalindromo(palabra2)}");
            Console.WriteLine($"{frase} es un palíndromo = {esPalindromo(frase)}");
        }
    }
}
