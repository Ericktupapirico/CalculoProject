using System;

namespace CalculoProject.Models
{
    public class ExCos : Padre
    {
        public ExCos(double x, int terminos) : base(x, terminos)
        {
        }

        public override double calcularSucesion(double x, int terminos)
        {
            double cosX = CalcularCoseno(x);
            double eCosX = 0;

            for (int n = 0; n < terminos; n++)
            {
               
                double termino = CalcularPotencia(cosX, n) / CalcularFactorial(n);

                
                eCosX += termino;
            }

            return eCosX;
        }

        static double CalcularCoseno(double x)
        {  
            double cosX = 1;
          
            double termino = 1;

            for (int n = 1; n <= 10; n++)
            {
                termino *= -CalcularPotencia(x, 2) / ((2 * n - 1) * (2 * n));
                cosX += termino;
            }

            return cosX;
        }

        static double CalcularPotencia(double baseNum, int exponente)
        {
            double resultado = 1.0;

            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }

            return resultado;
        } 

    static double CalcularFactorial(int n)
    {
        if (n == 0)
            return 1;

        double factorial = 1.0;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        return factorial;
    }
}
    }
