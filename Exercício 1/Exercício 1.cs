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
                Console.WriteLine("Exercício 01\nCalculando o volume de uma caixa retangular\n");
                Console.WriteLine("Digite o comprimento:");
                string comprimento = Console.ReadLine();
                decimal comp = Convert.ToDecimal(comprimento);

                Console.WriteLine("Digite a largura:");
                string largura = Console.ReadLine();
                decimal lar = Convert.ToDecimal(largura);

                Console.WriteLine("Digite a altura:");
                string altura = Console.ReadLine();
                decimal alt = Convert.ToDecimal(altura);

                decimal volume = comp * lar * alt;
                Console.WriteLine("Show! O volume é: " + volume + "\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
