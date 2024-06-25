using System;

namespace CalculoProject.Models
{
    public class ExCos : Ex
    {
        public ExCos(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x)
        {
            double cosX = CalculateCos(x, Terminos);
            double eCosX = CalculateExpCos(cosX, Terminos);

            return eCosX;
        }

     
        static double CalculateCos(double x, int Terms)
        {
            double cosX = 1.0;
            double signo = -1.0;
            double Exponente = x;
            double factorial = 1.0;

            for (int n = 1; n < Terms; n++)
            {
                    Exponente *= x * x;
                    factorial *= (2 * n - 1) * (2 * n);
                    double term = signo * (Exponente / factorial);
                    cosX += term;
                    signo = -signo;
                
            }

            return cosX;
        }

   
        static double CalculateExpCos(double cosX, int Terms)
        {
            double eCosX = 1.0;
            double Exponente = 1.0;
            double factorial = 1.0;

            for (int n = 1; n < Terms; n++)
            {  
                    Exponente *= cosX;
                    factorial *= n;
                    eCosX += Exponente / factorial;
                
            }

            return eCosX;
        }
    }
}
