using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public abstract class Ex
    {
        public  double x { get; set; }
        public int Terminos { get; set; }
        public Ex(double x, int terminos)
        {
            this.x = x;
            this.Terminos = Terminos;
        }
        public virtual double calcularSucesion(double x)
        {
            double[] Secuencia = new double[Terminos];
            double Factorial = 1.0;
            double Potencia = 1.0;
            double Sum = 0.0;
            for(int i = 0; i < Terminos; i++)
            {
                if(i > 0)
                {
                    Factorial *= i;
                    Potencia *= x;
                }
                Secuencia[i] = Potencia / Factorial;
                Sum += Secuencia[i];
            }
            return Sum;
        }
    }
}
