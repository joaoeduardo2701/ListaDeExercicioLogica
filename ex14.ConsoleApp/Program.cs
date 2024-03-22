namespace ex14.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Quantos dias de vida você tem? --");

        Console.WriteLine("Digite o seu nome: ");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a sua idade");
        int idade = int.Parse(Console.ReadLine());

        int diasDeIdade = idade * 365;

        Console.WriteLine($"{nome} você já viveu {diasDeIdade} dias!");
    }
}
