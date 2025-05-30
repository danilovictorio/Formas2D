using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public abstract class Poligono : Forma
    {
        public int NumeroLados { get; protected set; }

        public override string ToString()
        {
            return $"Polígono de {NumeroLados} lados, {base.ToString()}";
        }
    }
}

