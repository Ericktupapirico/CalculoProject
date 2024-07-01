using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public  class Exp : Padre
    {
       
        public Exp(double X, int Terminos) : base(X, Terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double sum = 0.0;
            double term = 1.0;

            for (int n = 0; n <= Terminos; n++)
            {
                sum += term;
                term *= x / (n + 1); 
            }

            return sum;
        }
    }
}
