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
                Console.WriteLine("Exercício 05\nCalculando o volume de uma esfera\n");

                Console.WriteLine("Digite o raio da esfera:");
                string radio = Console.ReadLine();
                double raio = Convert.ToDouble(radio);

                double volume = Math.Round(Math.PI, 4) * Math.Pow(raio, 3) * 4 / 3;
                Console.WriteLine("Show! O volume é: " + volume + "\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}

