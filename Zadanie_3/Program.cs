using System;

namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int h, m, s;
            double y, cos, x;
            
            Console.WriteLine("Введите кол-во часов: ");
            h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во минут: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во секунд: ");
            s = int.Parse(Console.ReadLine());
            if (0 <= h && h <= 11)
            {
                if (0 <= m && m <= 59) {
                    if (0 <= s && s <= 59)
                    {
                        x = h * 30;
                        y = s * 0.0016;
                        cos = x + (m / 2) + y;
                        Console.WriteLine("Стрелка отклонилась на: " + cos + " градусов.");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка! Неверное значение секунд!");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка! Неверное значение минут!");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Неверное значение часов!");
            }
        }
    }
}
