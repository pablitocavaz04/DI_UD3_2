using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DI_UD3_2
{
    public class Libro
    {
        public string Titulo { get; set; }
        public string Categoria { get; set; }

        public Libro(string titulo, string categoria)
        {
            Titulo = titulo;
            Categoria = categoria;
        }
    }

    internal class Program
    {
        public delegate bool FiltroLibros(Libro libro);

        public static void MostrarLibrosPorCategoria(List<Libro> libros, FiltroLibros filtro)
        {
            Console.WriteLine("Libros de la categoría Ficción:");
            foreach (var libro in libros)
            {
                if (filtro(libro))
                {
                    Console.WriteLine($"- {libro.Titulo}");
                }
            }
        }

        public static void Main()
        {
            List<Libro> libros = new List<Libro>
            {
                new Libro("El Hobbit", "Ficción"),
                new Libro("Harry Potter", "Ficción"),
                new Libro("Ciencias Naturales", "Educativo"),
                new Libro("Matemáticas Avanzadas", "Educativo")
            };

            FiltroLibros filtroFiccion = delegate (Libro libro)
            {
                return libro.Categoria == "Ficción";
            };

            MostrarLibrosPorCategoria(libros, filtroFiccion);
        }
    }
}
