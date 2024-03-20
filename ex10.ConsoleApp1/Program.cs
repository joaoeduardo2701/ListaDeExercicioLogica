namespace ex10.ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Cálculo média ponderada --");

        Console.WriteLine("Informe o nota da 1ª prova: ");
        double nota1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso da 1ª prova: ");
        double peso1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Informe a nota da 2ª prova: ");
        double nota2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe o peso da 2ª prova: ");
        double peso2 = double.Parse(Console.ReadLine());

        double media = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);

        Console.WriteLine("MÉDIA: " + media);
    }
}
