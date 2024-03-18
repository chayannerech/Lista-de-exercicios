using System.Diagnostics;

namespace Exercício_2
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 02\nConvertendo graus Fahrenheit em graus Celsius\n");
                Console.WriteLine("Digite a temperatura em graus Fahrenheit:");
                string temperatura = Console.ReadLine();
                decimal temp = Convert.ToDecimal(temperatura);

                decimal celsius = Math.Round ((5 * (temp - 32)) / 9,2);
                Console.WriteLine("Show! A temperatura em graus Celsius é: " + celsius + "\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
