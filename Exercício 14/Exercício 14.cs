using System.Diagnostics;

namespace Exercício_14
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 14\nCalculando a idade de uma pessoa em dias\n\n");
                Console.WriteLine("Informe seu nome:");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual a sua idade?");
                string anos = Console.ReadLine();
                int ano = Convert.ToInt32(anos);

                int idade = ano * 365;
                Console.WriteLine("\n" + nome + ", você já viveu " + idade + " dias!\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}


