using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exs_POO_28_05.Models.desafioTres
{
    public class Nota
    {
        public Nota(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        private double SomaNotas => (A * 2) + (B * 3) + (C * 5);
        private int SomaPesos => 2 + 3 + 5;
        private double Media => SomaNotas / SomaPesos;

        public void ExibirMedia() => Console.WriteLine($"MEDIA = {Media:F1}");

    }
}