﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD3_2
{
    internal class Program
    {
        public delegate bool ValidarEdades(int x);
        public static void Main()
        {
            ValidarEdades validate = delegate (int x)
            {
                return x >= 18;
            };
            ImprimirConsola(validate,19);
        }
        public static void ImprimirConsola(ValidarEdades validate, int x)
        {
            Console.WriteLine(validate(x));
        }
    }
}
