using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x"); 
            double x = double.Parse(Console.ReadLine());

            double y = (Math.Abs(x) + Math.Sin(Math.Pow((Math.Tan(x)), 2) + 4)) / (5.5 * x);
            Console.WriteLine("y = f(x), y = " + y);

            Console.ReadKey();


        }
    }
}
