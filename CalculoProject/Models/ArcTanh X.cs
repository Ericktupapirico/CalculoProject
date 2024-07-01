using System;

namespace CalculoProject.Models
{
    public class ArcTanh : Padre
    {
        public ArcTanh(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int terminos)
        {
            double seriesSum = 0;
            double currentPower = x;

            for (int i = 0; i <= terminos; i++)
            {
                double term = currentPower / (2 * i + 1);
                seriesSum += term;
                currentPower *= x * x; 
            }
            return seriesSum;
        }
    }
    }

