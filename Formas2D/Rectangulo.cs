using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Rectangulo : Poligono
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double baseRect, double altura)
        {
            Base = baseRect;
            Altura = altura;
        }

        public override double Area => Base * Altura;
        public override double Perimetro => 2 * (Base + Altura);

        public override string ToString()
        {
            return $"Rectángulo: Base = {Base}, Altura = {Altura}, {base.ToString()}";
        }
    }
}

