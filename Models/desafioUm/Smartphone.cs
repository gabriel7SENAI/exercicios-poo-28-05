using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exs_POO_28_05.Models.desafioUm
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public void Ligar() => Console.WriteLine("Smartphone ligado.");
        public void ReceberLigacao() => Console.WriteLine($"Chamada recebida no número: {Numero}");
        public abstract void InstalarAplicativo(string nome);
    }
}