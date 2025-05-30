using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Triangulo : Poligono
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public Triangulo(double a, double b, double c)
        {
            LadoA = a;
            LadoB = b;
            LadoC = c;
            NumeroLados = 3;
        }

        public override double Perimetro => LadoA + LadoB + LadoC;

        public override double Area
        {
            get
            {
                double s = Perimetro / 2;
                return Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
            }
        }

        public override string ToString()
        {
            return $"Triángulo: lados = {LadoA}, {LadoB}, {LadoC}, {base.ToString()}";
        }
    }
}
