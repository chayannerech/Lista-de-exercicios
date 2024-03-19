using System.Diagnostics;

namespace Exercício_3
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                double raio = ObterNumeroDouble("Exercício 03\nCalculando o volume de um cilíndro\n\nDigite o raio do cilíndro:");
                double alt = ObterNumeroDouble("Digite o raio do cilíndro:");
                CalcularVolume(raio, alt);
                if (DeveContinuar()) break;
            }
        }
        static double ObterNumeroDouble(string texto)
        {
            Console.WriteLine(texto);
            return Convert.ToDouble(Console.ReadLine());
        }
        static void CalcularVolume(double raio, double alt)
        {
            Console.WriteLine("Show! O volume é: " + (Math.Round((Math.PI * Math.Pow(raio, 2) * alt),2)) + "\n\nDeseja continuar? [S,N]");
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}