using System;

namespace CalculoProject.Models
{
    public class Sinh : Padre
    {
        public Sinh(double x, int terminos) : base(x, terminos)
        {
        }



        public override double calcularSucesion(double x, int terminos)
        {
            double sum = 0.0;
            double potencia = x; 
            double factorial = 1.0;

            for (int n = 0; n <= terminos; n++)
            {
                if (n > 0)
                {
                    factorial *= (2 * n) * (2 * n + 1); 
                    potencia *= x * x; 
                }

                double term = potencia / factorial;
                sum += term;
            }

            return sum;
        }
    }
}
