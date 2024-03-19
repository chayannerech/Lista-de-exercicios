using System.Diagnostics;

namespace Exercício_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double inicio = ObterNumeroDouble("Exercício 04\nCalculando o consumo de combustível por km rodado\n\nDigite a quilometragem inicial: [km]");
                double final = ObterNumeroDouble("Digite a quilometragem final: [km]");
                double cons = ObterNumeroDouble("Digite quanto combustível foi consumido: [l]");
                Console.WriteLine("Show! O consumo do seu carro é de: " + ((final - inicio) / cons) + " km/l\n\nDeseja continuar? [S/N]");
                if (DeveContinuar()) break;
            }
        }
        static double ObterNumeroDouble(string texto)
        {
            Console.WriteLine(texto);
            return Convert.ToDouble(Console.ReadLine());
        }
        static bool DeveContinuar()
        {
            string continua = Console.ReadLine();
            return (continua == "n" || continua == "N");
        }
    }
}
