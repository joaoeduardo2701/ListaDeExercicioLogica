// ex 12: A imobiliária Imóbilis vende apenas terrenos retangulares. Faça um algoritmo para ler as dimensões de um terreno e depois exibir a área do terreno.

namespace ex12.ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Dimenções do terreno --");

        Console.WriteLine("Digite a largura do terreno: ");
        double largura = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o comprimento do terreno: ");
        double comprimento = double.Parse(Console.ReadLine());

        double area = largura * comprimento;

        Console.WriteLine("Área = " + area);
    }
}
