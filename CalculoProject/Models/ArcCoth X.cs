using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public class ArcCoth : Padre
    {
        public ArcCoth(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double[] Secuencia = new double[Terminos];
            double Divisor = 1.0;
            double Potencia = 1.0;
            double Sum = 0.0;
            for (int i = 0; i < Terminos; i++)
            {
                Divisor = 2 * i + 1;
                if (i > 0)
                {

                    Potencia *= x * x;
                }
                Secuencia[i] = 1 / (Potencia * Divisor);
                Sum += Secuencia[i];
            }

            return Sum;
        }
    }
}
