using System.Globalization;

namespace ex09.ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Cálculo de média harmônica --");

        Console.WriteLine("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine());

        double mediaHarmonica = 4 / ((1 / nota1) + (1 / nota2) + (1 / nota3) + (1 / nota4));

        Console.WriteLine("Á média harmônica das notas é: " + mediaHarmonica);
    }
}
