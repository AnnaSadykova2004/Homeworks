using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace task9._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Искомые числа:");

            for (int number1 = 1; number1 < n; number1++)
            {
                int number2 = GetSumDel(number1);
                if (number1 < number2 & number1 == GetSumDel(number2))
                    Console.WriteLine($"{number1} и {number2}");
            }

            Console.ReadKey();
        }
        static int GetSumDel(int number)
        {
            int sumDel = 0;
            for (int del = 1; del <= number/2; del++)
            {
                if (number % del == 0)
                    sumDel = sumDel + del;
            }
            return sumDel;
        }

    }
}
