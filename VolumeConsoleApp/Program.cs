// Ex 01: Crie um programa para calcular o volume de uma caixa retangular
using System.Globalization;

namespace VolumeConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Calculadora de Volume --");
            
            Console.WriteLine("Digite o tamanho da altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o tamanho da largura: ");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o tamanho do comprimento: ");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double volume = altura * largura * comprimento;

            Console.WriteLine("Volume: " + volume.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}
