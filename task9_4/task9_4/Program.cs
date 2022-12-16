using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9_4
{
    internal class Program
    {
        //задание 4
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение n");
            int n = int.Parse(Console.ReadLine());
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
