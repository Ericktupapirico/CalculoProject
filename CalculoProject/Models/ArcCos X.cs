using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public class ArcCos : Padre
    {
        public ArcCos(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double contadorImpar = 1;
            double multiplicador = 1;
            double factorial = 1.0;
            double potencia = x;
            double sum = 0.0;
            
            for (int n = 0; n <= Terminos; n++)
            {
                if (n > 0)
                {
                    factorial *= (2 * n) * (2 * n + 1); 
                    potencia *= x * x; 
                }

                
                sum += (potencia*multiplicador)/factorial;

                if (n > 0){
                    contadorImpar += 2;
                    multiplicador *= contadorImpar;
                }
            }

            return (3.141592653589793/2)-(sum);
        }
    }
}
