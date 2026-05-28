using exs_POO_28_05.Models.desafioUm;
using exs_POO_28_05.Models.desafioDois;
using exs_POO_28_05.Models.desafioTres;
using exs_POO_28_05.Models.desafioQuatro;

Console.Clear();

// Nokia nokia = new();
// Iphone iphone = new();

// nokia.InstalarAplicativo("mine");
// iphone.InstalarAplicativo("mine");



// Valores valores = new();

// Random random = new();
// for (int i = 1; i <= 100; i++)
// {

//     valores.AdicionarValores(random.Next(1000));
// }

// valores.EncontrarMaiorValor();
// valores.ExibirLista();
// Console.WriteLine("");
// valores.ExibirMaior();



// Nota nota = new(5.0, 10.0, 10.0);
// nota.ExibirMedia();

// Console.WriteLine("");

// Nota notaDois = new(10.0, 10.0, 5.0);
// notaDois.ExibirMedia();



Console.Write("Quantidade de cálculos: ");
int quantidadeDeCalculos = int.Parse(Console.ReadLine());

List<CalcularDivisao> calculos = new();

for (int i = 0; i < quantidadeDeCalculos; i++)
{
    Console.Write($"Digite dois valores(ex.: 3 -2): ");
    string input = Console.ReadLine();

    Console.WriteLine("");

    string[] valores = input.Split(' ');

    double a = double.Parse(valores[0]);
    double b = double.Parse(valores[1]);

    calculos.Add(new CalcularDivisao(a, b));
}

foreach (var calculo in calculos)
{
    calculo.ExibirResultado();
}