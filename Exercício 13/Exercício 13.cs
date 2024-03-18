using System.Diagnostics;

namespace Exercício_13
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 13\nCalculando a renda de uma padaria\n");
                Console.WriteLine("Campeão, quantos pães foram vendidos hoje?");
                string qntpao = Console.ReadLine();
                decimal pao = Convert.ToDecimal(qntpao);

                Console.WriteLine("E quantas broas?");
                string qntbroa = Console.ReadLine();
                decimal broa = Convert.ToDecimal(qntbroa);

                decimal valor = (12 * pao / 100) + (15 * broa / 10);
                Console.WriteLine("\nShow! O total arrecadado é de: " + valor + " R$\nVocê deve guardar " + valor / 10 + " R$ na poupança!\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}

