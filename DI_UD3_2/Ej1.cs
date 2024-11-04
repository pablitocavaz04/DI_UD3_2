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
        public delegate double CambiarTemp(double celsius);

        public static void Main()
        {
            CambiarTemp GradosDist = delegate (double celsius)
            {
                return (celsius * 9 / 5) + 32;
            };

            Console.WriteLine($"0ºC -> {GradosDist(0)}ºF");
            Console.WriteLine($"30ºC -> {GradosDist(30)}ºF");
        }
    }
}

