using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exs_POO_28_05.Models.desafioQuatro
{
    public class CalcularDivisao
    {
        public CalcularDivisao(double a, double b)
        {
            A = a;
            B = b;
        }

        public int QuantidadeDeCalculos { get; set; }
        public double A { get; set; }
        public double B { get; set; }

        private double Calcular => A / B;
        public void ExibirResultado()
        {
            if (B == 0)
            {
                Console.WriteLine("Divisão Impossível.");
            }
            else
            {
                Console.WriteLine($"{A} : {B} = {Calcular:F1}");
            }
        }

    }
}