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
        public delegate bool EsMayorQueDiez(int numero);

        public static void Main()
        {
            // Método anónimo que verifica si un número es mayor que 10
            EsMayorQueDiez esMayor = delegate (int numero)
            {
                return numero > 10;
            };

            // Pruebas con los números 8 y 15
            int numero1 = 8;
            int numero2 = 15;

            Console.WriteLine($"{numero1} es mayor que 10: {esMayor(numero1)}");
            Console.WriteLine($"{numero2} es mayor que 10: {esMayor(numero2)}");
        }
    }
}