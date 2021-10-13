using System;

namespace Индивидуальное_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 7
            double s, Q, x, b, a;
            double e = 2.7;
            Console.WriteLine("Введите значение x: ");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение a: ");
            a = double.Parse(Console.ReadLine());

            if ((x + b) > 0)
            {
                s = Math.Pow(x, 3) * Math.Pow(Math.Tan(Math.Pow((x + b), 2)), 2)+ a/Math.Sqrt(a+b);
                Console.WriteLine($"Значение s = {s} ");
            }
            else
            {
                Console.WriteLine("Ошибка! Значение не удовлетворяет ОДЗ s!");
            }
            if (Math.Pow(e, a * x) != 1) 
            {
                Q = (b * Math.Pow(x, 2) - a) / Math.Pow(e, a * x) - 1;
               Console.WriteLine($"Значение Q = {Q} ");
            }
            else
            {
                Console.WriteLine("Ошибка! Значение не удовлетворяет ОДЗ Q!");
            }
        }
    }
}
