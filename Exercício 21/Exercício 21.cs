using System.Diagnostics;
using System.Runtime.Intrinsics;

namespace Exercício_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                decimal A = 0, B = 0, C = 0;
                Console.Clear();
                Console.WriteLine("Exercício 18\nEstruturas de decisão\n");
                Console.WriteLine("Por favor, informe dois valores inteiros\nSe eles forem iguais, retornarei a sua soma. Caso contrário, a sua multiplicação :)\n\nO primeiro:");
                do
                {
                    string valor1 = Console.ReadLine();
                    A = Convert.ToDecimal(valor1);
                    if (A % 1 != 0) Console.WriteLine("Por favor, insira um valor inteiro\n\nTente novamente:");
                } while (A % 1 != 0);

                Console.WriteLine("\nAgora, o segundo valor:");
                do
                {
                    string valor2 = Console.ReadLine();
                    B = Convert.ToDecimal(valor2);
                    if (B % 1 != 0) Console.WriteLine("Por favor, insira um valor inteiro\n\nTente novamente:");
                } while (B % 1 != 0);

                if (A == B){
                    C = A + B;
                    Console.WriteLine("Seus números são iguais, portanto, a soma deles é: " + C + "\n\nDeseja tentar novamente? [S/N]");
                }else
                {
                    C = A * B;
                    Console.WriteLine("Seus números são diferentes, portanto, a multiplicação deles é igual a: " + C + "\n\nDeseja tentar novamente? [S/N]");
                }

                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
