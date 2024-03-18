using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace Exercício_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal num = 0;
                Console.Clear();
                Console.WriteLine("Exercício 27\nEstruturas de repetição\n\nAo seu comando, mostrarei todos os números de 0 a 100 em ordem crescente.\nOs números múltiplos de 3 serão substituídos por 'Fizz', e os múltiplos de 5 por 'Buzz'\nOs números múltiplos tanto de 3 quanto de 5 serão substituídos por 'FizzBuzz'\n\nPosso começar?");

                Console.Read();

                for(int i = 0; i <=100;  i++)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                    {
                        if (i % 3 == 0) Console.Write("Fizz");
                        if (i % 5 == 0) Console.Write("Buzz");
                        Console.WriteLine();
                    }
                    else Console.WriteLine(i);
                }

                Console.Read();
                Console.WriteLine("\n\nDeseja repetir? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
