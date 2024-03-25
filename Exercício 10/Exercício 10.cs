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
                decimal nota = 1, peso = 1, dividendo = 0, divisor = 0, numNota = 1, numProvas;
                numProvas = ObterNumeroDecimal("Exercício 10\nCalculando a média ponderada das notas de um aluno\n\nInforme o número de provas:");
                
                ReceberInformacoes(nota, peso, dividendo, divisor, numNota, numProvas);
                if (DeveContinuar()) break;
            }
        }
        static decimal ObterNumeroDecimal(string texto)
        {
            Console.Clear();
            Console.WriteLine(texto);
            return Convert.ToDecimal(Console.ReadLine());
        }
        static void ReceberInformacoes(decimal nota, decimal peso, decimal dividendo, decimal divisor, decimal numNota, decimal numProvas)
        {
            for (int i = 1; i <= numProvas * 2; i++)
            {
                do
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine("\nDigite a nota 0" + numNota + ":");
                        nota = Convert.ToDecimal(Console.ReadLine());
                        if (nota <= 0) Console.WriteLine("Valor inválido. Por favor, tente novamente.\n");
                    }
                    else
                    {
                        Console.WriteLine("\nDigite o peso da nota 0" + numNota + ":");
                        peso = Convert.ToDecimal(Console.ReadLine());
                        divisor = divisor + peso;
                        if (peso > 0)
                        {
                            dividendo = dividendo + (nota * peso);
                            numNota++;
                        }
                        else Console.WriteLine("Valor inválido. Por favor, tente novamente.\n");
                    }
                } while (nota <= 0 || peso <= 0);
            }
            Console.WriteLine("Show! A média ponderada do aluno é: " + Math.Round(dividendo / divisor, 2) + "\n\nDeseja continuar? [S/N]");
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}

