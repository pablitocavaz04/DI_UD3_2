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
        ContarCaracteres contar = delegate (string cadena)
        {
            int contador = 0;
            foreach (char c in cadena)
            {
                contador++;
            }
            return contador;
        };

        string palabra1 = "mundo";
        string palabra2 = "programa";

        Console.WriteLine($"La palabra '{palabra1}' tiene {contar(palabra1)} caracteres");
            Console.WriteLine($"La palabra '{palabra2}' tiene {contar(palabra2)} caracteres");
        }
}
}
