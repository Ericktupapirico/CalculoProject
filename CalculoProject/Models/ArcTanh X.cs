using System;

namespace CalculoProject.Models
{
    public class ArcTanh : Padre
    {
        public ArcTanh(double x, int terminos) : base(x, terminos)
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
            return numerador / denominador;
        }

        public override double calcularSucesion(double x, int terminos)
        {
            if (x <= -1 || x >= 1)
            {
                throw new ArgumentException("x debe estar en el intervalo -1 < x < 1 para la función arctanh.");
            }

            double secuencia = 0;

            for (int i = 0; i < terminos; i++)
            {
                double termino = Division(Potencia(x, 2 * i + 1), 2 * i + 1);
                secuencia += termino;
            }

            return secuencia;
        }
    }
}
