using System.Diagnostics;

namespace Exercício_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine($"\nShow! A temperatura em graus Fahrenheit é: {ObterTemperatura()}\n\nDeseja continuar? [S/N]");
                if (DeveContinuar()) break;
            }
        }
        static decimal ObterTemperatura()
        {
            Console.Clear();
            Console.WriteLine("Exercício 06\nConvertendo graus Celsius em graus Fahrenheit\n");
            Console.WriteLine("Digite a temperatura em graus Celsius:");
            decimal temp = Convert.ToDecimal(Console.ReadLine());
            return Math.Round((9 * temp / 5) + 32, 2);
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}