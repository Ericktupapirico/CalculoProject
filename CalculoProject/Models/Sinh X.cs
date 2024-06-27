using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public class Sinh : Padre
    {
        public Sinh(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double[] Secuencia = new double[Terminos];
            double Factorial = 1.0;
            double Potencia  = 1.0;
            double Sum = 0.0;
            for (int i = 0; i < Terminos; i++)
            {
                if (i > 0)
                {
                    Factorial *= (2*i)+(2*i+1);
                    Potencia *= x*x;
                }
                Secuencia[i] = Potencia / Factorial;
                Sum += Secuencia[i];
            }

            return Sum;
        }
    }
}
