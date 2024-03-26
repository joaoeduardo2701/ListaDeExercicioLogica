namespace ex24.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- TABUADA --");

        Console.WriteLine("Digite um número para ver a sua tabuada: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int resposta = n * i;
            Console.WriteLine($"{n} x {i} = {resposta}");
        }
    }
}
