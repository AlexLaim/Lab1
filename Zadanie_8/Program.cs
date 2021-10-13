using System;

namespace Задание_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите x");
            x = double.Parse(Console.ReadLine());
            double y = ((((3 * x - 5) * x + 2) * x - 1) * x + 7);
            Console.WriteLine($"Ответ: {y}");
        }
    }
}
