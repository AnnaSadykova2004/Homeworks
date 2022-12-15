using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9._1_9._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 9.1
            Console.WriteLine("Введите значения а и h");
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("Таблица перевода дюймов в см: ");
            for (double number = 1; number <= a; number += h)
                Console.WriteLine(number + " дюйм = " + number * 2.54 + "см");

            //////задание 9.2
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\nВведите значение n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Натуральные числа, квадрат которых меньше n: ");
            for (int num = 1; Math.Pow(num, 2) < n; num++)
                Console.WriteLine(num);

            ////задание 9.3
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nДистанция в 1-й день равна n, введём значение:");
            float n = float.Parse(Console.ReadLine());
            Console.WriteLine("Введём значения m и k:");
            float m = float.Parse(Console.ReadLine());
            float k = float.Parse(Console.ReadLine());
            int t = 2;
            while (n <= k)
            {
                Console.WriteLine("дистанция в " + t++ + " день равна:");
                Console.WriteLine(n += n * m / 100);
            }
            if (n > k)
                Console.WriteLine("Значит в " + (t - 1) + "-й день лыжник пробежит больше, чем " + k + "км");

            Console.ReadKey();

        }
    }
}
