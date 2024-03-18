using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace Exercício_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 22\nEstruturas de repetição\nAo seu comando, mostrarei os números ímpares entre 100 e 200\n\nPosso começar?");
                Console.Read();

                for (int i = 101; i < 200; i = i + 2) Console.WriteLine(i);

                Console.WriteLine("Deseja repetir? [S/N]");
                Console.Read();
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}

