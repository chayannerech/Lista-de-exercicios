using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace Exercício_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int soma = 0;
                Console.Clear();
                Console.WriteLine("Exercício 23\nEstruturas de repetição\nAo seu comando, mostrarei a soma de todos os números ímpares que são múltiplos de três (de 1 até 500)\n\nPosso começar?");
                Console.Read();

                for (int i = 1; i < 500; i = i + 2)
                {
                    if (i % 3 == 0) soma = soma + i;
                }

                Console.WriteLine("Seu resultado é: " + soma + "\n\nDeseja repetir? [S/N]");
                Console.Read();
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
