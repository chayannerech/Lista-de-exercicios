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
                decimal v1 = 0, v2 = 0, v3 = 0;
                Console.Clear();
                Console.WriteLine("Exercício 18\nEstruturas de decisão\n");
                Console.WriteLine("Por favor, informe três valores inteiros e diferentes\n\nO primeiro valor:");
                do {
                    string valor1 = Console.ReadLine();
                    v1 = Convert.ToDecimal(valor1);
                    if (v1 % 1 != 0) Console.WriteLine("Por favor, insira um valor inteiro\n\nTente novamente:");
                } while (v1 % 1 != 0);
                
                Console.WriteLine("\nAgora, o segundo valor:");
                do
                {
                    string valor2 = Console.ReadLine();
                    v2 = Convert.ToDecimal(valor2);
                    if (v1 == v2) Console.WriteLine("Por favor, insira números diferentes\n\nTente novamente:");
                    if (v2 % 1 != 0) Console.WriteLine("Por favor, insira um valor inteiro\n\nTente novamente:");
                } while (v1 == v2 || v2 % 1 != 0);

                Console.WriteLine("\nAgora, o terceiro valor:");
                do
                {
                    string valor3 = Console.ReadLine();
                    v3 = Convert.ToDecimal(valor3);
                    if (v1 == v3 || v2 == v3) Console.WriteLine("Por favor, insira números diferentes\n\nTente novamente:");
                    if (v3 % 1 != 0) Console.WriteLine("Por favor, insira um valor inteiro\n\nTente novamente:");
                } while (v1 == v3 || v3 == v2 || v3 % 1 != 0);

                if (v1 > v2 && v1 > v3) {
                    if(v2 > v3) Console.WriteLine("\nOrdem decrescente: " + v1 + ", " + v2 + ", " + v3 + "\nDeseja tentar novamente? [S/N]");
                    else Console.WriteLine("\nOrdem decrescente: " + v1 + ", " + v3 + ", " + v2 + "\nDeseja tentar novamente? [S/N]");
                }

                if (v2 > v1 && v2 > v3)
                {
                    if (v1 > v3) Console.WriteLine("\nOrdem decrescente: " + v2 + ", " + v1 + ", " + v3 + "\nDeseja tentar novamente? [S/N]");
                    else Console.WriteLine("\nOrdem decrescente: " + v2 + ", " + v3 + ", " + v1 + "\nDeseja tentar novamente? [S/N]");
                }

                else
                {
                    if (v1 > v2) Console.WriteLine("\nOrdem decrescente: " + v3 + ", " + v1 + ", " + v2 + "\nDeseja tentar novamente? [S/N]");
                    else Console.WriteLine("\nOrdem decrescente: " + v3 + ", " + v2 + ", " + v1 + "\nDeseja tentar novamente? [S/N]");
                }

                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
