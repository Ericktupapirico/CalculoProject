using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public class CosX : Padre
    {
        public CosX(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double seriesSum = 0;
            double currentPower = 1; 
            long factorial = 1; 

            for (int i = 0; i <= Terminos; i++)
            {
                double term = currentPower / factorial;

                if (i % 2 == 0)
                {
                    seriesSum += term;
                }
                else
                {
                    seriesSum -= term;
                }

                currentPower *= x * x;

                factorial *= (2 * i + 1) * (2 * i + 2);
            }
            return seriesSum;
        }
    }
}
