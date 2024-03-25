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
                decimal comprimento = ObterNumeroDecimal("Exercício 12\nCalculando a área de um terreno retangular\n\nDigite o comprimento:");
                decimal largura = ObterNumeroDecimal("Digite a largura:");

                Console.WriteLine("Show! A área é: " + comprimento * largura + "\n\nDeseja continuar? [S/N]");
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

