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

                Console.WriteLine("Digite o salário base: [R$]");
                string salariobase = Console.ReadLine();
                double salario = Convert.ToDouble(salariobase);

                Console.WriteLine("Informe o total de vendas realizadas: [R$]");
                string numvendas = Console.ReadLine();
                double vendas = Convert.ToDouble(numvendas);

                Console.WriteLine("Qual a comissão sobre as vendas? [%]");
                string comissao = Console.ReadLine();
                double comis = Convert.ToDouble(comissao);

                double total = salario + (vendas * comis / 100); 
                Console.WriteLine("Show! O salário total do vendedor é de: " + total + " R$\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}

