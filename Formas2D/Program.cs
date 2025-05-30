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

            // Instanciando un triángulo
            Triangulo tri = new Triangulo(3, 4, 5);

            //Intanciando un cuadrado
            Cuadrado cuadrado = new Cuadrado(5);

            // Puedes guardar todo en una lista si quieres recorrerlas
            List<Forma> figuras = new List<Forma>
            {
                rect,
                tri,
                cuadrado
            };

            Console.WriteLine("\nResumen de todas las figuras:");
            foreach (var figura in figuras)
            {
                Console.WriteLine(figura);
            }

            Console.WriteLine("\nPresiona una tecla para salir...");
            Console.ReadKey();
        }
    }
}
