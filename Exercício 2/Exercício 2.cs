using System.Diagnostics;

namespace Exercício_2
{

    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                decimal temp = ObterNumeroDecimal("Exercício 02\nConvertendo graus Fahrenheit em graus Celsius\nDigite a temperatura em graus Fahrenheit:");
                InformaResultado(temp);
                if (DeveContinuar()) break;
            }
        }
        static decimal ObterNumeroDecimal(string texto)
        {
            Console.WriteLine(texto);
            return Convert.ToDecimal(Console.ReadLine());
        }
        static void InformaResultado(decimal temp)
        {
            Console.WriteLine("\nShow! A temperatura em graus Celsius é: " + (Math.Round((5 * (temp - 32)) / 9, 2)) + "\n\nDeseja continuar? [S/N]");
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}
