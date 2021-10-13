using System;

namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, P, S, c;
            Console.WriteLine("Введите длину первого катета: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите длину Второго катета: ");
            b = double.Parse(Console.ReadLine());
            S = (a * b) / 2;
            c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            P = a + b + c;
            Console.WriteLine("Площадь треугольника равна: " + S + ", Периметр треугольника равен: " + P);
        }
    }
}
