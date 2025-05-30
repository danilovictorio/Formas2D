using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    class Program
    {
        static List<Forma> figuras;
        static void Main(string[] args)
        {
            Diagrama diagrama = new Diagrama();
            string respuesta;
            // Creación de figuras aleatorias
            for (int i = 0; i < 5; i++)
            {
                diagrama.AgregarFormaAleatoria();
            }
            
            CreacionFiguras();

            Console.WriteLine("Resumen de todas las figuras:");
            foreach (var figura in figuras)
            {
                Console.WriteLine(figura);
            }

            do
            {
                Console.Write("¿Quieres ver la lista de figuras generadas? (S/N): ");
                respuesta = Console.ReadLine().Trim().ToUpper();

                if (respuesta == "S")
                {
                    Console.WriteLine("\n→ Lista de figuras:");
                    Console.WriteLine(diagrama);
                }
                else if (respuesta != "N")
                {
                    Console.WriteLine("Entrada no válida. Por favor, escribe 'S' o 'N'.");
                }

            } while (respuesta != "S" && respuesta != "N");

            Console.WriteLine("\nPrograma finalizado. Presiona una tecla para salir...");
            Console.ReadKey();
        }

        private static void CreacionFiguras()
        {
            // Instanciando un rectángulo
            Rectangulo rect = new Rectangulo(10, 7);

            // Instanciando un triángulo
            Triangulo tri = new Triangulo(3, 4, 5);

            //Intanciando un cuadrado
            Cuadrado cuadrado = new Cuadrado(10);

            // Instanciando una circulo
            var circulo = new Circulo(5);
            Console.WriteLine(circulo);

            figuras = new List<Forma>
            {
                rect,
                tri,
                cuadrado
            };

        }
    }
}
