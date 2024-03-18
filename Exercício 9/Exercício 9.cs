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
                double aa = 0;
                double nota = 0;

               Console.Clear();
                Console.WriteLine("Exercício 09\nCalculando a média harmônica das notas de um aluno\n");

                Console.WriteLine("Digite o número de notas:");
                string numnotas = Console.ReadLine();
                double n = Convert.ToDouble(numnotas);
                
                for (int i = 1; i <= n; i++)
                    {
                    do
                    {
                        Console.WriteLine("\nDigite a nota nº " + 0 + i + " :");
                        string notas = Console.ReadLine();
                        nota = Convert.ToDouble(notas);

                        if (nota > 0) aa = aa + (1 / nota);
                        else
                        {
                            Console.WriteLine("Nota inválida. Por favor, tente novamente");
                        }
                    }
                    while (nota <= 0);
                }

                double media = Math.Round(n/aa,2);
                Console.WriteLine("Show! A média harmônica do aluno é: " + media + "\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
