using System;

namespace Лаба1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Введите число: x ");
            x = double.Parse(Console.ReadLine());
            int y = (int)x;
            double z = (x - y) * 10;
            z = (int)z;
            Console.WriteLine(z);
        }
    }
}
