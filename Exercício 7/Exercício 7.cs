using System.Diagnostics;
namespace Exercício_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 07\nCalculando salário total de um vendedor\n");

                double salario = GettingValue("Digite o salário base: [R$]");
                double vendas = GettingValue("Informe o total de vendas realizadas: [R$]");
                double comissao = GettingValue("Qual a comissão sobre as vendas? [%]");

                Console.WriteLine("Show! O salário total do vendedor é de: " + (salario + (vendas * comissao / 100)) + " R$\n\nDeseja continuar? [S/N]");
                if (DeveContinuar()) break;
            }
        }
        static double GettingValue(string text)
        {
            Console.WriteLine(text);
            return Convert.ToDouble(Console.ReadLine());
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}

