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
        public delegate bool Filtro(Producto producto);

        public static void MostrarProductosFiltrados(List<Producto> productos, Filtro filtro)
        {
            Console.WriteLine("Productos con cantidad mayor a 5:");
            foreach (var producto in productos)
            {
                if (filtro(producto))
                {
                    Console.WriteLine($"- {producto.Nombre} (Cantidad: {producto.Cantidad})");
                }
            }
        }

        public static void Main()
        {
            List<Producto> productos = new List<Producto>
            {
                new Producto("Televisor", 10),
                new Producto("Refrigerador", 7),
                new Producto("Microondas", 3),
                new Producto("Licuadora", 5)
            };

            Filtro filtroCantidad = delegate (Producto producto)
            {
                return producto.Cantidad > 5;
            };

            MostrarProductosFiltrados(productos, filtroCantidad);
        }
    }
}
