using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
   public class Sinx : Padre
    {
        public Sinx(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int Terminos)
        {
            double[] Secuencia = new double[Terminos];
            double Factorial = 1.0;
            double Potencia  = x;
            double Sum = 0.0;
            for (int i = 0; i < Terminos; i++)
            {

                for (int j = 1; j < (2*i)+1; j++)
                {
                    // Console.WriteLine("2n+1: " + ((2*i)+1));
                    Factorial *= j+1;
                    Potencia *= x;
                    // Console.WriteLine("Factorial " + i + " : " + Factorial);
                    // Console.WriteLine("Potencia " + i + " : " + Potencia);
                }
                

                if(i % 2 == 0)
                {
                    Secuencia[i] = Potencia / Factorial;
                }
                else
                {
                    Secuencia[i] = -Potencia / Factorial;
                }
                // Console.WriteLine("Secuencia " + i + " : " + Secuencia[i]);
                Sum += Secuencia[i];

                Factorial = 1.0;
                Potencia = x;
            }

            return Sum;
        }
    }
}
