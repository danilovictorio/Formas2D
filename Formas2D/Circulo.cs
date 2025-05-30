using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Circulo : Elipse
    {
        public double Radio { get; set; }
        public Circulo(double radio) : base(radio, radio)
        {
            Radio = radio;
        }
        public override string ToString()
        {
            return $"Círculo: Radio = {Radio}, {base.ToString()}";
        }
    }
    
    
}
