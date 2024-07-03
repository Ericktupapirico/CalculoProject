using System;

namespace CalculoProject.Models
{
    public class ExSenX : Padre
    {
        public ExSenX(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int terms)
        {
            double sinX = CalculateSine(x, terms);
            double eSinX = CalculateESinX(sinX, terms);
            return eSinX;
        }

        static double CalculateSine(double x, int terms)
        {
            double sum = 0.0;
            double potencia = x;
            double factorial = 1.0;
            double term = 0;

            for (int n = 0; n <= terms; n++)
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

        static double CalculateESinX(double sinX, int n)
        {
            double result = 0.0;
            double term = 1.0;

            for (int i = 0; i < n; i++)
            {
                result += term;
                term *= (sinX / (i + 1));
            }

            return result;
        }
    }
}
