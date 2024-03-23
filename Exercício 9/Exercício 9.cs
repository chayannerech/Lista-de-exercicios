using System.Data;
using System.Diagnostics;

namespace Exercício_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double divisor = 0, nota = 0, numNotas = 0;
                Console.Clear();
                Console.WriteLine("Exercício 09\nCalculando a média harmônica das notas de um aluno\n");

                do
                {
                    numNotas = ObterNumeroDouble("Digite o número de notas:");
                    if (numNotas <= 0 || numNotas % 1 != 0) Console.WriteLine("Número inválido. Por favor, tente novamente\n");
                } 
                while (numNotas <= 0 || numNotas % 1 != 0);

                for (int i = 1; i <= numNotas; i++)
                    {
                    do
                    {
                        nota = ObterNumeroDouble("\nDigite a nota nº " + 0 + i + " :");

                        if (nota > 0) divisor = divisor + (1 / nota);
                        else
                        {
                            Console.WriteLine("Nota inválida. Por favor, tente novamente");
                        }
                    }
                    while (nota <= 0);
                }
                Console.WriteLine("Show! A média harmônica do aluno é: " + (Math.Round(numNotas / divisor, 2)) + "\n\nDeseja continuar? [S/N]");
                if (DeveContinuar()) break;
            }
        }
        static double ObterNumeroDouble(string texto)
        {
            Console.WriteLine(texto);
            return Convert.ToDouble(Console.ReadLine());
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}
