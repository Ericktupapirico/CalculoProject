using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public class LN : Padre
    {
        public LN(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double total = 0.0;
            double potencia = x;
            double denominador = 1;

            for (int n = 0; n <= Terminos; n++)
            {
                if (n % 2 == 0)
                {
                    total += potencia / denominador;
                }
                else
                {
                    total -= potencia / denominador;
                }
                potencia *= x;
                denominador = n + 2;

            }

            return total;
        }
    }
}
