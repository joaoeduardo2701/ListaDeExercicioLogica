// Ex 03: Crie um programa para calcular o volume de um Cilindro

using System.Globalization;

namespace VolumeCilindro.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Calculadora de volume de cilindros --");

            Console.WriteLine("Digite a altura do cilindro: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o raio do cilindro: ");
            double raio = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = Math.PI * altura * Math.Pow(raio, 2);

            Console.WriteLine("Volume do cilindro: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
