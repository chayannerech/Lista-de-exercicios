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
                Console.WriteLine("Exercício 04\nCalculando o consumo de combustível por km rodado\n");

                Console.WriteLine("Digite a quilometragem inicial: [km]");
                string iniciokm = Console.ReadLine();
                double inicio = Convert.ToDouble(iniciokm);

                Console.WriteLine("Digite a quilometragem final: [km]");
                string finalkm = Console.ReadLine();
                double final = Convert.ToDouble(finalkm);

                Console.WriteLine("Digite quanto combustível foi consumido: [l]");
                string consumiu = Console.ReadLine();
                double cons = Convert.ToDouble(consumiu);

                double consumo = (final-inicio)/cons;
                Console.WriteLine("Show! O consumo do seu carro é de: " + consumo + " km/l\n\nDeseja continuar? [S/N]");
                string continua = Console.ReadLine();
                if (continua == "n" || continua == "N") break;
            }
        }
    }
}
