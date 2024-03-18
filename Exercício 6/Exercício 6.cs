using System.Diagnostics;

namespace Exercício_6
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 06\nConvertendo graus Celsius em graus Fahrenheit\n");
                Console.WriteLine("Digite a temperatura em graus Celsius:");
                string temperatura = Console.ReadLine();
                decimal temp = Convert.ToDecimal(temperatura);

                decimal fahr = Math.Round((9 * temp / 5) + 32, 2);
                Console.WriteLine("Show! A temperatura em graus Fahrenheit é: " + fahr + "\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}