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
            double sum = 0.0;
            double potencia = 1; 
            double factorial = 1.0;
            double term = 0;

            for (int n = 0; n <= Terminos; n++)
            {
                if (n > 0)
                {
                    for (int i = 1; i <= 2 * n; i++){
                        factorial *= i;
                    } 
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
                factorial = 1.0;
            }

            return sum;
        }
    }
}
