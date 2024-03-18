using System.Diagnostics;

namespace Exercício_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 19\nEstruturas de decisão\n");
                Console.WriteLine("Por favor, informe a sua altura:");
                string altura = Console.ReadLine();
                double alt = Convert.ToDouble(altura);

                Console.WriteLine("Por favor, informe a seu peso:");
                string peso = Console.ReadLine();
                double pes = Convert.ToDouble(peso);

                double imc = pes / Math.Pow(alt, 2);

                if (imc <= 18.5) Console.WriteLine("\nSua condição é: abaixo do peso! \nDeseja continuar? [S,N]");
                if (imc > 18.5 && imc <= 25) Console.WriteLine("\nSua condição é: normal! \nDeseja continuar? [S,N]");
                if (imc > 25 && imc <= 30) Console.WriteLine("\nSua condição é: acima do peso! \nDeseja continuar? [S,N]");
                if (imc > 30) Console.WriteLine("\nSua condição é: obeso! \nDeseja continuar? [S,N]");

                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}