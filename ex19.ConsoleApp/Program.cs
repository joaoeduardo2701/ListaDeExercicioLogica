/*  
    Ex 19:
    O IMC – Índice de Massa Corporal é um critério da Organização Mundial de Saúde para dar uma indicação sobre a condição de peso de uma pessoa adulta. A fórmula é IMC = peso / (altura) ². Elabore um algoritmo que leia o peso e a altura de um adulto e mostre sua condição de acordo com a listagem abaixo:
    IMC em adultos Condição
    Abaixo de 18,5
    Abaixo do peso
    Entre 18,5 e 25 Peso normal
    Entre 25 e 30
    Acima do peso
    Acima de 30 obeso
*/

namespace ex19.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("-- Calculadora de MMC --");

        Console.WriteLine("Digite o seu peso: ");
        double peso = double.Parse(Console.ReadLine());

        Console.WriteLine(("Digite a sua altura: "));
        double altura = double.Parse((Console.ReadLine()));

        double mmc = (peso) / (Math.Pow(altura, 2));

        if (mmc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (mmc >= 18.5 && mmc <= 25)
        {
            Console.WriteLine("Peso normal");
        }
        else if (mmc >= 25 && mmc <= 30)
        {
            Console.WriteLine("Acima do peso");
        }
        else if (mmc > 30)
        {
            Console.WriteLine("Você esta em obsidade");
        }

    }
}
