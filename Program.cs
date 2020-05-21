using System;

namespace Soma2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Digite um número.");
            string xstring = Console.ReadLine();
            double xdouble = Convert.ToDouble(xstring);
            Console.WriteLine("Digite outro número.");
            string ystring = Console.ReadLine();
            double ydouble = Convert.ToDouble(ystring);
            double resultado = xdouble + ydouble;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Soma dos números: { resultado}");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Gray;

            
        }
    }
}
