// Ex 05: Crie um programa para calcular o volume de uma esfera

using System.Globalization;

namespace VolumeEsfera.ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Calculadora de Volume de Esferas --");

        Console.WriteLine("Digite o raio da esfera: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double resultado = (4 * Math.PI * Math.Pow(raio, 3)) / 3;

        Console.WriteLine("Volume da esfera: " + resultado.ToString("F2", CultureInfo.InvariantCulture) + " m³");
    }
}
