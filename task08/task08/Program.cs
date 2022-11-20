using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task08
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Введите значение х");
           double x = double.Parse(Console.ReadLine());
           Console.WriteLine(Calc(x));
        }
        static double Calc(double x)
        {
            if (x > 1)
            {
                return 2 - x;
            }
            else if (x >= -1 & x <= 1)
            {
                return x * x;
            }
            else
            {
                return 1;
            }
        }
                  
    }
}
