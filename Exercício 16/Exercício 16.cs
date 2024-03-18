using System.Diagnostics;

namespace Exercício_16
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Exercício 16\nCalculando o salário final de um funcionário\n\n");
                Console.WriteLine("Informe o salário bruto [R$]:");
                string salario = Console.ReadLine();
                decimal sal = Convert.ToDecimal(salario);

                decimal acrescimo = sal * 115 / 100;

                Console.WriteLine("\nSalário inicial: " + sal + " R$\nSalário após aumento: " + acrescimo + " R$\nSalário final, após o desconto dos impostos: " + acrescimo * 92/100 + " R$\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
