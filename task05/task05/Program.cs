using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double x = (Math.Sqrt(3)-Math.Sqrt(2))/(Math.Sqrt(3)+Math.Sqrt(2))+(Math.Sqrt(5)-Math.Sqrt(3))/(Math.Sqrt(5)+Math.Sqrt(3))+(Math.Sqrt(11)-Math.Sqrt(7))/(Math.Sqrt(11)+Math.Sqrt(7));

            //x = Math.Round(x, 3);
            double x = calc2(3, 2)/calc(3, 2) + calc2(5, 3)/calc(5, 3) + calc2(11, 7)/calc(11, 7);
           Console.WriteLine("х равен: "+Math.Round(x,3));
           
           Console.ReadKey();
            
        }
        static double calc(double a, double b)
        {
            return Math.Sqrt(a)+Math.Sqrt(b);
        }
        static double calc2(double c, double d)
        {
            return Math.Sqrt(c) - Math.Sqrt(d);
        }
    }
}
