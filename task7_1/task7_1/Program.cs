using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значения m и n ");
            double m = double.Parse(Console.ReadLine());    
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine(Result(m, n));
            Console.ReadKey();
        }
        static bool Result(double m, double n)
        {
            if (m > 10 & n > 10)
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
