using System.Diagnostics;

namespace Exercício_17
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 17\nEstruturas de decisão\n");
                Console.WriteLine("Se me informar três valores, posso te dizer se a soma dos dois primeiros é menor que o último :)\n\nAh... Você duvida?\nEntão, me diga o primeiro valor:");
                string valor1 = Console.ReadLine();
                decimal A = Convert.ToDecimal(valor1);

                Console.WriteLine("Agora, o segundo valor:");
                string valor2 = Console.ReadLine();
                decimal B = Convert.ToDecimal(valor2);

                Console.WriteLine("Agora, palestrinha, o terceiro valor:");
                string valor3 = Console.ReadLine();
                decimal C = Convert.ToDecimal(valor3);
                decimal D = A + B;

                if (D >= C) Console.WriteLine("\nAhá! A soma dos primeiros valores NÃO é menor que o último valor!\n\nDeseja tentar novamente? [S/N]");
                else Console.WriteLine("\nSimmm! A soma dos primeiros valores (" + A + " + " + B + " = " + D + ") é menor que o último valor ( " + C + " )! \n\nDeseja tentar novamente? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
