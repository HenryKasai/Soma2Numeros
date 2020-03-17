using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número.");
            string número = Console.ReadLine();
            int conversão = Int32.Parse(número);
            Console.WriteLine("Digite outro número.");
            string outro = Console.ReadLine();
            int auau = Int32.Parse(outro);
            int resultado = conversão + auau;
            Console.WriteLine(resultado);
            
        }
    }
}
