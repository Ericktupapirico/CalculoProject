using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public class ArcTan : Padre
    {
        public ArcTan(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            if (x < -1 || x > 1)
            {
                throw new ArgumentException("x debe estar en el intervalo -1 < x < 1 para la función arctan.");
            }

            double sum = 0.0;
            double potencia = x; 
            double denominador = 1.0;
            double term = 0;

            for (int n = 0; n <= Terminos; n++)
            {
                if (n > 0)
                {
                    denominador = ((2 * n) + 1); 
                    potencia *= x * x; 
                }

                if (n % 2 == 0)
                {
                    term = potencia / denominador;
                }
                else
                {
                    term = -potencia / denominador;
                }

                sum += term;
            }

            return sum;
        }
    }
}
