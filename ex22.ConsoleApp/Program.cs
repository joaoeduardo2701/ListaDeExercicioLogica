// Ex22: Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

namespace ex22.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Números ímpares entre 100 e 200");

        for (int i = 100; i <= 200; i++)
        {
            if (i % 2 != 0)
            {
                Console.Write(i + " ");
            }
        }
    }
}
