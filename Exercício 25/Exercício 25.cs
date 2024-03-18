using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace Exercício_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal A = 0;
                Console.Clear();
                Console.WriteLine("Exercício 25\nEstruturas de repetição\n\nInforme um número inteiro positivo (natural) e te direi a fatorial dele:");

                do
                {
                    string numero = Console.ReadLine();
                    A = Convert.ToDecimal(numero);
                    if (A % 1 != 0 || A < 0) Console.WriteLine("Número inválido :(\n\nPor favor, tente novamente:");
                } while (A % 1 != 0 || A < 0);

                Console.Write("\n" + A + "! = ");
                decimal fatorial = A;
                if (A == 0) Console.Write("0");

                for (decimal i = A; i > 0; i--)
                {
                    if (i > 1)
                    {
                        fatorial = fatorial * (i - 1);
                        Console.Write(i + " x ");
                    }
                    else Console.Write("1 = " + fatorial);
                }

                Console.WriteLine("\n\nDeseja repetir? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
