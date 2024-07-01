using CalculoProject.Models;
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
            double sum = 0.0;
            double sinX = Sin(x, terms);

            for (int n = 0; n <= terms; n++)
            {
                double term = Elevar(sinX, n) / Factorial(n);
                sum += term;
            }

            return sum;
        }

        static double Sin(double x, int terms)
        {
            double sum = 0.0;

            for (int n = 0; n < terms; n++)
            {
                double term = Elevar(-1, n) * Elevar(x, 2 * n + 1) / Factorial(2 * n + 1);
                sum += term;
            }

            return sum;
        }

        static double Elevar(double baseNum, int exp)
        {
            if (exp == 0) return 1.0;
            double result = 1.0;
            for (int i = 0; i < exp; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        static double Factorial(int n)
        {
            if (n == 0) return 1.0;
            double result = 1.0;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
