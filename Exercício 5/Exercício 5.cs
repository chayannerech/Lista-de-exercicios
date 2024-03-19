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
                Console.WriteLine("Exercício 05\nCalculando o volume de uma esfera\n\nDigite o raio da esfera:");
                double raio = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Show! O volume é: " + (Math.Round(Math.PI, 4) * Math.Pow(raio, 3) * 4 / 3) + "\n\nDeseja continuar? [S/N]");
                if (DeveContinuar()) break;
            }
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}

