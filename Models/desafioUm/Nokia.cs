using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace exs_POO_28_05.Models.desafioUm
{
    public class Nokia : Smartphone
    {
        public override void InstalarAplicativo(string nome) => Console.WriteLine($"Instalando {nome} no {GetType().Name} através da Google Play Store");
    }
}