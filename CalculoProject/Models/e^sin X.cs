using System;

namespace CalculoProject.Models
{
    public class ExSenX : Padre
    {
        public ExSenX(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double sinX = CalculateSin(x, Terminos);
            double eSinX = CalculateExpSin(sinX, Terminos);

            return eSinX;
        }

 
        static double CalculateSin(double x, int nTerms)
        {
            double sinX = 1.0;
            double signo = -1.0;
            double Exponente = x;
            double factorial = 1.0;

            for (int n = 1; n < nTerms; n++)
            {
                Exponente *= x * x;
                factorial *= (2 * n) * (2 * n + 1);
                double term = signo  * (Exponente / factorial);
                sinX += term;
                signo = -signo; 
            }

            return sinX;
        }

       
        static double CalculateExpSin(double sinX, int Terms)
        {
            double eSinX = 1.0;
            double exponente = 1.0;
            double factorial = 1.0;

            for (int n = 1; n < Terms; n++)
            {
                exponente *= sinX;
                factorial *= n;
                eSinX += exponente / factorial;
            }

            return eSinX;
        }
    }
}
