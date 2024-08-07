﻿using System;
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
            double contadorPar = 0;
            double multiplicadorNumerador = 1;
            double multiplicadorDenominador = 1.0;
            double denominador = 1.0;
            double potencia = x;
            double sum = 0.0;
            
            for (int n = 0; n <= Terminos; n++)
            {
                if (n > 0)
                {
                    contadorPar += 2;
                    multiplicadorDenominador *= contadorPar; 
                    denominador = multiplicadorDenominador * (contadorPar+1);
                    potencia *= x * x; 
                }
                Console.WriteLine(potencia);
                Console.WriteLine(multiplicadorNumerador);

                sum += (potencia*multiplicadorNumerador)/denominador;

                if (n > 0){
                    contadorImpar += 2;
                    multiplicadorNumerador *= contadorImpar;
                }
            }

            return (3.141592653589793/2)-(sum);
        }
    }
}
