// Ex 21: Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela.

namespace ex21.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o valor de A: ");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B: ");
        int b = int.Parse(Console.ReadLine());

        int c;

        if (a == b)
        {
            c = a + b;
        }
        else
        {
            c = a * b;
        }

        Console.WriteLine("Resultado: " + c);
    }
}
