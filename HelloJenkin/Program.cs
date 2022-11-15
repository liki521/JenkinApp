using System;
using Calculator;

namespace HelloJenkin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calc calc = new Calc();
            Console.WriteLine($"sum={calc.Add(70,80)}");
            Console.WriteLine($"Multiply={calc.Multiply(2,6)}");
            Console.WriteLine($"Subtract={calc.Subtract(4,2)}");
            Console.ReadLine();

        }
    }
}
