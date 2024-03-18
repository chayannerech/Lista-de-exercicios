using System.Data;
using System.Diagnostics;

namespace Exercício_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Resolvi complicar o exercício e permitir qualquer número de provas:

            while (true)
            {
                decimal nota = 1, peso = 1, dividendo = 0, divisor = 0, num = 1;
                Console.Clear();
                Console.WriteLine("Exercício 10\nCalculando a média ponderada das notas de um aluno\n\nInforme o número de provas:");
                string contagem = Console.ReadLine();
                decimal cont = Convert.ToDecimal(contagem);

                for (int i = 1; i <= cont * 2; i++)
                {
                    do
                    {
                        if (i % 2 != 0)
                        {
                            Console.WriteLine("\nDigite a nota 0" + num + ":");
                            string n = Console.ReadLine();
                            nota = Convert.ToDecimal(n);
                            if (nota <= 0) Console.WriteLine("Valor inválido. Por favor, tente novamente.\n");
                        }
                        else {
                            Console.WriteLine("\nDigite o peso da nota 0" + num + ":");
                            string p = Console.ReadLine();
                            peso = Convert.ToDecimal(p);
                            divisor = divisor + peso;
                            if (peso > 0) { 
                                dividendo = dividendo + (nota * peso);
                                num++;
                            } 
                            else Console.WriteLine("Valor inválido. Por favor, tente novamente.\n");
                        } 
                    } while (nota <= 0 || peso <= 0);
                }

                Console.WriteLine("Show! A média ponderada do aluno é: " + Math.Round(dividendo / divisor, 2) + "\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}

