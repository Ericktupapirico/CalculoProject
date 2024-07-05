using System;

namespace CalculoProject.Models
{
    public class Cosh : Padre
    {
        public Cosh(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int terms)
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

                term = potencia / factorial;

                sum += term;
                factorial = 1.0;
            }

            return sum;
        }
    }
    }

