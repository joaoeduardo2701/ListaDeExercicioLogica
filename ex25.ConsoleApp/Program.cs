// Ex 25: Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
// Exemplo : 5! = 5 X 4 X 3 X 2 X 1 = 120

namespace ex25.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- FATORIAL --");
        
        Console.WriteLine("Digite um número para ver o seu fatorial: ");
        int n = int.Parse(Console.ReadLine());

        int auxn = n;
        int aux = n - 1;
        int total = 0;
        int resultadoFinal = 0;

        Console.WriteLine();

        for (int i = n; i >= 1; i--)
        {
            if (i == n)
            {
                total = auxn * aux;
            }
            resultadoFinal += total;
            Console.Write($"{i} ");
            aux--;
            auxn--;
        }

        Console.WriteLine();

        Console.WriteLine($"Fatorial {n}: {resultadoFinal} ");
    }
}
