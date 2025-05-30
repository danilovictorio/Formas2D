using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formas2D
{
    public class Elipse : Forma
    {

        public double SemiEjeMayor { get; set; }
        public double SemiEjeMenor { get; set; }
        public Elipse(double semiEjeMayor, double semiEjeMenor)
        {
            SemiEjeMayor = semiEjeMayor;
            SemiEjeMenor = semiEjeMenor;
        }
        public override double Area => Math.PI * SemiEjeMayor * SemiEjeMenor;
        public override double Perimetro
        {
            get
            {
                // Aproximación de Ramanujan para el perímetro de una elipse
                return Math.PI * (3 * (SemiEjeMayor + SemiEjeMenor) - Math.Sqrt((3 * SemiEjeMayor + SemiEjeMenor) * (SemiEjeMayor + 3 * SemiEjeMenor)));
            }
        }
        public override string ToString()
        {
            return $"Elipse: Semi-eje mayor = {SemiEjeMayor}, Semi-eje menor = {SemiEjeMenor}, {base.ToString()}";
        }   
    }
}
