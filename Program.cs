//@niallivmi
using System;

namespace Pgc1Aula02Ex03 
{
    public class Program
    {
        static void Main(string[] args)
        {
            float km, lt;

            Console.Write("Digite a quantidade de quilômetros percorridos: ");
            km = float.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de combustível consumido: ");
            lt = float.Parse(Console.ReadLine());

            Console.WriteLine("O consumo médio do veículo é de: "+(km/lt)+" litros por 1km");
            Console.ReadKey();
        }
    }
}