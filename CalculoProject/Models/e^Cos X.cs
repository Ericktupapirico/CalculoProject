using System;

namespace CalculoProject.Models
{
    public class ExCos : Padre
    {
        public ExCos(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int terms)
        {
            double cosx = CalculateCose(x, terms);
            double eCosX = CalculateECosx(cosx, terms);
            return eCosX;
        }

        // Método de instancia para calcular la serie de coseno
        private double CalculateCose(double x, int terms)
        {
            double seriesSum = 0;
            double currentPower = 1;
            long factorial = 1;

            for (int i = 0; i <= terms; i++)
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

        // Método de instancia para calcular la serie de e^cos(x)
        private double CalculateECosx(double cosx, int n)
        {
            double result = 0.0;
            double term = 1.0;

            for (int i = 0; i < n; i++)
            {
                result += term;
                term *= cosx / (i + 1);
            }

            return result;
        }
    }
}
