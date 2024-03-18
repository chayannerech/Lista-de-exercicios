using System.Diagnostics;

namespace Exercício_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 20\nEstruturas de decisão\n");
                Console.WriteLine("Por favor, informe um número:");
                string numero = Console.ReadLine();
                double num = Convert.ToDouble(numero);

                if (num % 2 == 0) Console.WriteLine("\nSeu número é par!\nDeseja continuar? [S,N]");
                else Console.WriteLine("\nSeu número é ímpar!\nDeseja continuar? [S,N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
