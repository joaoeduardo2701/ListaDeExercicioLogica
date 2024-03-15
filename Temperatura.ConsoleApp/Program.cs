// Ex02: Crie um programa para converter a temperatura de graus Fahrenheit para graus Celsius

using System.Globalization;

namespace Temperatura.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Conversor de Fahrenheit para Celsius  --");

            Console.WriteLine("Digite o valor da temperatura em Fahrenheit: ");
            double temperatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double temperaturaFinal = (temperatura - 32) / 1.8;

            Console.WriteLine("O valor dessa temperatura em Celcius é: " +  temperaturaFinal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
