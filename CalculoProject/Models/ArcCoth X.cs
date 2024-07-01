using System;

namespace CalculoProject.Models
{
    public class ArcCoth : Padre
    {
        public ArcCoth(double x, int terminos) : base(x, terminos)
        {
        }

        private double Potencia(double baseNum, int exponente)
        {
            double resultado = 1.0;
            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }
            return resultado;
        }

        private double Division(double numerador, double denominador)
        {
            double resultado = numerador / denominador;
            return resultado;
        }

        public override double calcularSucesion(double x, int terminos)
        {
            if (x <= 1 && x >= -1)
            {
                throw new ArgumentException("x debe ser mayor que 1 o menor que -1 para la función arccoth.");
            }

            double secuencia = 0;
            double inversoX = Division(1.0, x);

            for (int i = 0; i < terminos; i++)
            {
                double termino = Division(1.0, (2 * i + 1)) * Potencia(inversoX, 2 * i + 1);
                secuencia += termino;
            }

            return secuencia;
        }
    }
}
