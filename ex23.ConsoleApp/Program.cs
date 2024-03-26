// Ex 23: Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se encontram no conjunto dos números de 1 até 500.


namespace ex23.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Soma dos números ímpares e múltiplos de 3 entre 1 e 500");

        for (int i = 0; i < 500; i++)
        {
            if (i % 2 != 0 && i % 3 == 0)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
