namespace Temperatura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Conversor de Fahrenheit para Celsius  --");

            Console.WriteLine("Digite o valor da temperatura em Fahrenheit: ");
            double temperatura = double.Parse(Console.ReadLine());

            double temperaturaFinal = 5 / 9 * (temperatura - 32);

            Console.WriteLine("")
        }
    }
}
