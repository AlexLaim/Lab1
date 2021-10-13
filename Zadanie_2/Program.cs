using System;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, h, m, s; 
            Console.WriteLine("Сколько прошло времени в секундах: ");
            t = int.Parse(Console.ReadLine());
            h = t / 3600;
            m = (t - h * 3600) / 60;
            s = t - (h * 3600 + m * 60); 
            Console.WriteLine("Прошло " + h + " часов, " + m + " минут, " + s + " секунд.");
        }
    }
}
