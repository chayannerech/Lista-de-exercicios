using System.Diagnostics;

namespace Exercício_3
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 03\nCalculando o volume de um cilíndro\n");

                Console.WriteLine("Digite o raio do cilíndro:");
                string radio = Console.ReadLine();
                double raio = Convert.ToDouble(radio);

                Console.WriteLine("Digite a altura:");
                string altura = Console.ReadLine();
                double alt = Convert.ToDouble(altura);

                double volume = Math.Round(Math.PI, 4)*Math.Pow(raio,2)*alt;
                Console.WriteLine("Show! O volume é: " + volume + "\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}