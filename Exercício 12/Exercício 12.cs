using System.Diagnostics;

namespace Exercício_12
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 12\nCalculando a área de um terreno retangular\n");
                Console.WriteLine("Digite o comprimento:");
                string comprimento = Console.ReadLine();
                decimal comp = Convert.ToDecimal(comprimento);

                Console.WriteLine("Digite a largura:");
                string largura = Console.ReadLine();
                decimal lar = Convert.ToDecimal(largura);

                decimal area = comp * lar;
                Console.WriteLine("Show! A área é: " + area + "\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}

