using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Cuadrado : Poligono
    {
        public double Lado { get; set; }
        public Cuadrado(double lado)
        {
            Lado = lado;
            NumeroLados = 4;
        }
        public override double Area => Lado * Lado;
        public override double Perimetro => 4 * Lado;
        public override string ToString()
        {
            return $"Cuadrado: Lado = {Lado}, {base.ToString()}";
        }
    }
    
}
