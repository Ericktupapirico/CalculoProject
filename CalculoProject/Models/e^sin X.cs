using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public class ExSen : Ex
    {
        public ExSen(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x)
        {
            double[] Secuencia = new double[Terminos];
            double Factorial = 1.0;
            double Exp = 1.0;
            double Sum = 0.0;
            for (int i = 0; i < Terminos; i++)
            {
                if (i > 0)
                {

                }
                Sum += Secuencia[i];
            }

            return Sum;
        }
    }
}
