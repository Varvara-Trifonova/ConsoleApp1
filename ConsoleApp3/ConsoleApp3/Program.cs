using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Введите длину первого катета:");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину второго катета:");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            double height = (a * b) / c;

            Console.WriteLine($"Длина высоты, опущенной из вершины прямого угла на гипотенузу: {height}"); 

            Console.ReadKey();
        }
    }
}
