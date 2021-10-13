using System;

namespace Задание_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b, c, d;
            Console.WriteLine("Введите четырехзначное число: ");
            x = int.Parse(Console.ReadLine());
            if (x <= 999 ^ x <= 9999)
            {
                a = x / 1000;
                b = (x - a * 1000) / 100;
                c = (x - a * 1000 - b * 100) / 10;
                d = (x - a * 1000 - b * 100 - c * 10);
                int sum = a * b * c * d;
                Console.WriteLine("Произведение чисел равно: " + sum);
            }
            else
            {
                Console.WriteLine("Ошибка! Число не четырехзначное!");
            }
        }
    }
}
