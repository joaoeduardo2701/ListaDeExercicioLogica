namespace ex13.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a quantidade de pães vendidos: ");
        int paes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a quantidade de broas vendidas: ");
        int broas = int.Parse(Console.ReadLine());

        double arrecadado = (paes * 0.12) + (broas * 1.50);
        double poupanca = arrecadado * 0.1;

        Console.WriteLine("Valor arrecadado: " + arrecadado);
        Console.WriteLine("Valor que vai para a poupança: " + poupanca);
    }
}
