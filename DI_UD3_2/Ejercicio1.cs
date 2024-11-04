using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_UD3_2
{
    internal class Program
    {
        public delegate int Multiplicar(int x, int y);
        public static void Main()
        {
            
            Multiplicar validate = delegate (int x, int y)
            {
                return x * y;
            };
            Console.WriteLine("20 * 2 = "+validate(20,2));
        }
    }
}
