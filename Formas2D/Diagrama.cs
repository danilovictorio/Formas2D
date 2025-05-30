using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Formas2D
{
    public class Diagrama : Forma
    {
        public List<Forma> Formas { get; set; }
        private static Random random = new Random();

        public Diagrama()
        {
            Formas = new List<Forma>();
        }

        public void AgregarForma(Forma forma)
        {
            Formas.Add(forma);
        }

        public Forma AgregarFormaAleatoria()
        {
            //Pilla numero random
            int tipo = random.Next(0, 4);
            Forma nueva = null;

            switch (tipo)
            {
                case 0:
                    //Genera figura con medidas randoms
                    double baseR = random.Next(1, 11);
                    double altura = random.Next(1, 11);
                    nueva = new Rectangulo(baseR, altura);
                    break;

                case 1:
                    double a, b, c;
                    do
                    {
                        a = random.Next(1, 11);
                        b = random.Next(1, 11);
                        c = random.Next(1, 11);
                    } while (!EsTrianguloValido(a, b, c));
                    nueva = new Triangulo(a, b, c);
                    break;

                case 2:
                    double ejeMayor = random.Next(2, 11);
                    double ejeMenor = random.Next(1, (int)ejeMayor);
                    nueva = new Elipse(ejeMayor, ejeMenor);
                    break;

                case 3:
                    double radio = random.Next(1, 11);
                    nueva = new Circulo(radio);
                    break;
            }

            if (nueva != null)
            {
                AgregarForma(nueva);
            }

            return nueva;
        }
        private bool EsTrianguloValido(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        public override double Area => Formas.Sum(f => f.Area);
        public override double Perimetro => Formas.Sum(f => f.Perimetro);

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Diagrama de Formas:");
            foreach (var forma in Formas)
            {
                sb.AppendLine(forma.ToString());
            }
            sb.AppendLine($"Área total: {Area}, Perímetro total: {Perimetro}");
            return sb.ToString();
        }
    }
}
