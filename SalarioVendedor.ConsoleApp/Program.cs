// Ex 07: Crie um programa para calcular o salário total de um vendedor. Deverá ser informado o salário base e o total de vendas. A comissão é calculada com um percentual (informado pelo usuário) sobre o total de vendas.


using System.Globalization;

namespace SalarioVendedor.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Calculadora de salário --");

        Console.WriteLine("Digite o salário base: ");
        double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Digite o total de vendas: ");
        double totalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Qual a porcentagem da comissão de vendas? ");
        double comissaoVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double salarioFinal = salarioBase + (totalVendas * (comissaoVendas / 100));

        Console.WriteLine("Salário final: R$" + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));
    }
}
