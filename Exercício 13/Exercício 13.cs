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

                decimal pao = ObterNumeroDecimal("Exercício 13\nCalculando a renda de uma padaria\n\nCampeão, quantos pães foram vendidos hoje?");
                decimal broa = ObterNumeroDecimal("E quantas broas?");
                decimal valor = (12 * pao / 100) + (15 * broa / 10);

                Console.WriteLine("\nShow! O total arrecadado é de: " + valor + " R$\nVocê deve guardar " + valor / 10 + " R$ na poupança!\n\nDeseja continuar? [S/N]");
                if (DeveContinuar()) break;
            }
        }
        static decimal ObterNumeroDecimal(string texto)
        {
            Console.WriteLine(texto);
            return Convert.ToDecimal(Console.ReadLine());
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}

