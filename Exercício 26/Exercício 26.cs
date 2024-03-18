using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace Exercício_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal num = 0;
                Console.Clear();
                Console.WriteLine("Exercício 26\nEstruturas de repetição\n\nInforme um número inteiro positivo e te direi sequência de Fibonacci até ele:");

                do
                {
                    string numero = Console.ReadLine();
                    num = Convert.ToDecimal(numero);
                    if (num % 1 != 0 || num <= 0) Console.WriteLine("Número inválido :(\n\nPor favor, tente novamente:");
                } while (num % 1 != 0 || num <= 0);

                int atual = 1, anterior = 0, total = 0;

                Console.Write("\n1 ");

                while (total < num)
                {
                    total = anterior + atual;
                    anterior = atual;
                    atual = total;
                    if (total <= num) Console.Write(total + " ");
                } 

                Console.WriteLine("\n\nDeseja repetir? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}

