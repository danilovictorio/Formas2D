using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public abstract class Forma
    {
        public abstract double Area { get; }
        public abstract double Perimetro { get; }

        public override string ToString()
        {
            return $"Área: {Area}, Perímetro: {Perimetro}";
        }
    }
}

