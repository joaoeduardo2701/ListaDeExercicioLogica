// Ex06: Crie um programa para converter a temperatura da escala Celsius para a escala Fahrenheit

using System.Globalization;

namespace ex06.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Conversor de temperaturas --");

        Console.WriteLine("Digite a temperatura em Celcius: ");
        double temperatura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = 1.8 * temperatura + 32;

        Console.WriteLine("Resultado: " + resultado.ToString("F2", CultureInfo.InvariantCulture));
    }
}
