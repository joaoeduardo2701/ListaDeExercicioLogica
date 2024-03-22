// Ex 04: Crie um programa para calcular o consumo de combustível por Km. Deverá ser informado a quilometragem Inicial e Final do Percurso do Veículo. Deverá ser informado o Consumo de Combustível

using System.Globalization;

namespace ex04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Calculadora de Consumo de Combustível --");

            Console.WriteLine("Digite a kilometratem inicial do veículo: ");
            int inicialkm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a kilometragem final do veículo: ");
            int finalkm = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o gasto de combustível: ");
            double valorCombustivel = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double totalGasto = valorCombustivel / (finalkm - inicialkm) ;

            Console.WriteLine("Valor gasto por litro: " + totalGasto.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
