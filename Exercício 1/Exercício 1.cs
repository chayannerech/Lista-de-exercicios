using System.Diagnostics;
namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                decimal comp = ObterNumeroDecimal("Exercício 01\nCalculando o volume de uma caixa retangular\n\nDigite o comprimento:");
                decimal lar = ObterNumeroDecimal("Digite a largura:");
                decimal alt = ObterNumeroDecimal("Digite a altura:");
                decimal volume = CalcularVolume(comp, lar, alt);
                ExibirResultado(volume);
                if (DeveContinuar()) break;
            }
        }
        static decimal CalcularVolume(decimal comp, decimal lar, decimal alt)
        {
            return comp * lar * alt;
        }
        static decimal ObterNumeroDecimal(string texto)
        {
            Console.WriteLine(texto);
            return Convert.ToDecimal(Console.ReadLine());
        }
        static void ExibirResultado(decimal volume)
        {
            Console.WriteLine("\nShow! O volume é: " + volume + "\n\nDeseja continuar? [S/N]");
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}
