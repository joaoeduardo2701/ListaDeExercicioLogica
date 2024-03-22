namespace ex16.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Aumento de salários --");

        Console.WriteLine("Digite o salário do funcionário: ");
        double salario = double.Parse(Console.ReadLine());

        double salarioFinal = (salario * 1.15) - (salario * 1.15 * 0.08);

        Console.WriteLine("Salário final do funcionário é R$" + salarioFinal.ToString("f2"));
    }
}
