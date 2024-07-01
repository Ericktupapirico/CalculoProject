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
            double seriesSum = 0;
            double currentPower = 1; 
            long factorial = 1; 

            for (int i = 0; i <= terms; i++)
            {
                double term = currentPower / factorial;
                seriesSum += term;

               
                currentPower *= x * x;

                factorial *= (2 * i + 1) * (2 * i + 2);
            }
            return seriesSum;
        }
    }
    }

