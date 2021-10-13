using System;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Console.WriteLine("Введите трехзначное число: ");
            x = int.Parse(Console.ReadLine());
            if (x <= 99 ^ x <= 999)
            {
                string b = x.ToString();
                char[] inputarray = b.ToCharArray();
                Array.Reverse(inputarray);
                    string reversed;
                    reversed = new string(inputarray);
                Console.WriteLine(reversed);
            }
            else
            {
                Console.WriteLine("Ошибка! Число не трехзначное!");
            }
        }
    }
}
