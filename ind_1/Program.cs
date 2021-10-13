using System;

namespace Индивидуальное_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вариант 7
            string a1, a2, a3, t1, t2, t3;
            uint b1, b2, b3, c1, c2, c3;
            Console.WriteLine("Введите данные членов спортклуба: ");
            Console.WriteLine("ФИО");
            a1 = Console.ReadLine();
            Console.WriteLine("Введите тип: Т-тренер, С-спортсмен.");
            t1 = Console.ReadLine();
            Console.WriteLine("Введите год рождения: ");
            b1 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите опыт(лет): ");
            c1 = uint.Parse(Console.ReadLine());

            Console.WriteLine("ФИО");
            a2 = Console.ReadLine();
            Console.WriteLine("Введите тип: Т-тренер, С-спортсмен.");
            t2 = Console.ReadLine();
            Console.WriteLine("Введите год рождения: ");
            b2 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите опыт(лет): ");
            c2 = uint.Parse(Console.ReadLine());

            Console.WriteLine("ФИО");
            a3 = Console.ReadLine();
            Console.WriteLine("Введите тип: Т-тренер, С-спортсмен.");
            t3 = Console.ReadLine();
            Console.WriteLine("Введите год рождения: ");
            b3 = uint.Parse(Console.ReadLine());
            Console.WriteLine("Введите опыт(лет): ");
            c3 = uint.Parse(Console.ReadLine());

            Console.WriteLine("Состав спортклуба: ");

            Console.WriteLine($"ФИО\t\t\tТип\t\tГод рождения\tОпыт(лет)");
            Console.WriteLine($"{a1}\t\t{t1}\t\t{b1}\t\t{c1}");
            Console.WriteLine($"{a2}\t\t{t2}\t\t{b2}\t\t{c2}");
            Console.WriteLine($"{a3}\t\t{t3}\t\t{b3}\t\t{c3}");
            Console.WriteLine("Перечисляемый тип: Т - тренер, С - спортсмен");
        }
    }
}
