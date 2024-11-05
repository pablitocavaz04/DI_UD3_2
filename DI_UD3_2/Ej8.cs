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
        public delegate bool Operacion(int numero);

        public static void ProcesarNumero(int numero, Operacion operacion)
        {
            bool resultado = operacion(numero);
            Console.WriteLine($"El número {numero} es par: {resultado}");
        }

        public static void Main()
        {
            Operacion esPar = delegate (int numero)
            {
                return numero % 2 == 0;
            };

            ProcesarNumero(4, esPar);
            ProcesarNumero(7, esPar);
        }
    }
}
