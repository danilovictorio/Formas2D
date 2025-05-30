using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando un rectángulo
            Rectangulo rect = new Rectangulo(10, 7);
            Console.WriteLine(rect);

            // Instanciando un triángulo
            Triangulo tri = new Triangulo(3, 4, 5);
            Console.WriteLine(tri);

            // Puedes guardar todo en una lista si quieres recorrerlas
            List<Forma> figuras = new List<Forma>
            {
                rect,
                tri
            };

            Console.WriteLine("\nResumen de todas las figuras:");
            foreach (var figura in figuras)
            {
                Console.WriteLine(figura);
            }

            // Pausa al final (útil si corres en consola)
            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
