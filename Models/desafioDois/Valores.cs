using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exs_POO_28_05.Models.desafioDois
{
    public class Valores
    {
        List<int> cemValores = new();
        private int Maior { get; set; } = 0;
        private int PosicaoMaior { get; set; }

        public void AdicionarValores(int valor) => cemValores.Add(valor);
        public void EncontrarMaiorValor()
        {
            for (int i = 0; i < cemValores.Count; i++)
            {
                if (cemValores[i] > Maior)
                {
                    Maior = cemValores[i];
                    PosicaoMaior = i + 1;
                }
            }
        }

        public void ExibirLista()
        {
            for (int i = 0; i < cemValores.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {cemValores[i]}");
            }
        }

        public void ExibirMaior() => Console.WriteLine($"Maior valor: {Maior} - Posição: {PosicaoMaior}");
    }
}