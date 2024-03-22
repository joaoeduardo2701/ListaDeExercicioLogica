// Ex 18: Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente

namespace ex18.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de C: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Ordem decrescente: ");

        if (a > b && b > c)
            Console.WriteLine($"{a} {b} {c}");
        else if (b > a && a > c)
            Console.WriteLine($"{b} {a} {c}");
        else if (c > a && a > b)
            Console.WriteLine($"{c} {a} {b}");
        else if(a > c && c > b)
            Console.WriteLine($"{a} {c} {b}");
        else if(b > c && c > a)
            Console.WriteLine($"{b} {c} {a}");
        else if(c > b && b > a)
            Console.WriteLine($"{c} {b} { a}");
    }
}
