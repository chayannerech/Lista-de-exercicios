using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace Exercício_24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal N = 0;
                Console.Clear();
                Console.WriteLine("Exercício 24\nEstruturas de repetição\n\nInforme um número de 1 a 10, e te direi a tabuada dele:");

                while (N < 1 || N > 10)
                {
                    string numero = Console.ReadLine();
                    N = Convert.ToDecimal(numero);
                    if (N < 1 || N > 10) Console.WriteLine("Por favor, informe um número entre 1 e 10.\nTente novamente:");
                }
       
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine(i + " x " + N + " = " + i * N);
                }

                Console.WriteLine("\nDeseja repetir? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
