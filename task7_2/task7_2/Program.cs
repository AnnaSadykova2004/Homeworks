using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_2
{
    internal class Program
    {
        static void Main(string[] args)//задание 7.2
        {
            Console.WriteLine("Введите координаты точки: х и у");
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine(IsPointInArea(ref x, ref y));
            Console.ReadKey();

        }
        static bool IsPointInArea(ref double x, ref double y)
        {
            if (y >= 1 | y<= -3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
