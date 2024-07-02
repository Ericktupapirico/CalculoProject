using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
   public class Sinx : Padre
    {
        public Sinx(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double sum = 0.0;
            double potencia = x; 
            double factorial = 1.0;
            double term = 0;

            for (int n = 0; n <= Terminos; n++)
            {
                if (n > 0)
                {
                    factorial *= (2 * n) * (2 * n + 1); 
                    potencia *= x * x; 
                }

                if (n % 2 == 0)
                {
                    term = potencia / factorial;
                }
                else
                {
                    term = -potencia / factorial;
                }

                sum += term;
            }

            return sum;
        }
    }
}
