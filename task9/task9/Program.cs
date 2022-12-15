using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //задание 1
            Console.WriteLine("Введите значения a и h");
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Таблица перевода дюймов в см:");
            for (double number = 1; number <= a; number += h)
                Console.WriteLine($"{number} дюйм = {number * 2.54} см");


            //задание 2
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВведите значение n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Натуральные числа, квадрат которых меньше {n}:");
            for (int num = 1; Math.Pow(num, 2) < n; num++)
                Console.WriteLine(num);


            //задание 3
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nДистанция в 1-й день равна n, введём значение: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine("Введем значения m и k:");
            double m = double.Parse(Console.ReadLine());
            double k = double.Parse(Console.ReadLine());
            int dayNumber = 2;
            while (n <= k)
            {
                Console.WriteLine($"дистанция в  {dayNumber++} равна:");
                Console.WriteLine(n += n * m / 100);
            }
            if (n > k)
                Console.WriteLine($"Значит в {dayNumber - 1}- й день лыжник пробежит больше, чем {k} км");

            Console.ReadKey();
        }
    }
}
