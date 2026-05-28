using exs_POO_28_05.Models.desafioDois;
using exs_POO_28_05.Models.desafioUm;

Console.Clear();

// Nokia nokia = new();
// Iphone iphone = new();

// nokia.InstalarAplicativo("mine");
// iphone.InstalarAplicativo("mine");



Valores valores = new();

Random random = new();
for (int i = 1; i <= 100; i++)
{

    valores.AdicionarValores(random.Next(1000));
}

valores.EncontrarMaiorValor();
valores.ExibirLista();
Console.WriteLine("");
valores.ExibirMaior();