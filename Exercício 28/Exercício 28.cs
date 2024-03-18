using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace Exercício_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal num = 0;
                Console.Clear();
                Console.WriteLine("Exercício 28\nEstruturas de repetição\n\nAo seu comando, mostrarei a tabuada de 1 a 10 :)\n\nPosso começar?");

                Console.Read();

                Console.WriteLine("TABUADA SHOW DE BOLA\n");

                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write(j + "x" + i + " = " + j * i + "    ");
                    }
                    Console.WriteLine();
                }

                Console.Read();

                Console.WriteLine("\nDeseja repetir? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
