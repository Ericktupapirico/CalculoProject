using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public class LN : Ex
    {
        public LN(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x)
        {
            double[] Secuencia = new double[Terminos];
            double Factorial = 1.0;
            double Potencia = 1.0;
            double Sum = 0.0;
            for (int i = 0; i < Terminos; i++)
            {
                if (i > 0)
                {
                    Factorial *= i;
                    Potencia *= x;
                }
                Sum += Secuencia[i];
            }

            return Sum;
        }
    }
}
