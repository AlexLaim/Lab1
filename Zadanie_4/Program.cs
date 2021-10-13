using System;

namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Введите первую переменную (1): ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вторую переменную (2): ");
            y = int.Parse(Console.ReadLine());
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine("Обмен значениями переменных: (1) = " + x + " ,(2) = " + y );
        }
    }
}
