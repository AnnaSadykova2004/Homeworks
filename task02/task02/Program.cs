using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите сторону а");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите сторону b");
            double b = double.Parse(Console.ReadLine());

            double S = a * b;
            Console.WriteLine("Площадь прямоугольника равна:" + S);
            
            double P = 2*(a + b);
            Console.WriteLine("Периметр прямоугольника равен:" + P);
           
            double d = Math.Sqrt(a * a + b * b);
            Console.WriteLine("Диагональ прямоугольника равна:" + d);
                       
            Console.ReadKey();
        }
    }
}
