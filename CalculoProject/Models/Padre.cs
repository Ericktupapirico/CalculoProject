using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoProject.Models
{
    public abstract class Padre
    {

        public int Terminos;
        public double X;

        public Padre(double X, int Terminos)
        {
            this.Terminos = Terminos;
            this.X = X;
        }
        public abstract double calcularSucesion(double x, int Terminos);
       
    }
}
