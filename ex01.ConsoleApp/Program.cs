// Ex 01: Crie um programa para calcular o volume de uma caixa retangular

using System.Globalization;

namespace ex01.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        #region INPUT DE DADOS

        Console.WriteLine("-- Calculadora de Volume --");
        
        Console.WriteLine("Digite o tamanho da altura: ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o tamanho da largura: ");
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o tamanho do comprimento: ");
        double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        #endregion

        #region PROCESSAMENTO DE DADOS
        double volume = altura * largura * comprimento;
        #endregion

        #region OUTPUT DE DADOS
        Console.WriteLine("Volume: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        #endregion

    }
}
