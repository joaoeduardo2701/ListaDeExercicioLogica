// Ex20: Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar.

namespace ex20.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- ÍMPAR OU PAR --");
        Console.WriteLine();

        Console.WriteLine("Digite um número: ");
        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 0)
        {
            Console.WriteLine("O número é PAR");
        }
        else
        {
            Console.WriteLine("O número é ÍMPAR");
        }
    }
}
