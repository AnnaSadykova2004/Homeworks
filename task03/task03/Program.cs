using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            int a = x % 10;
            Console.WriteLine("число единиц равно " + a);

            int b = x / 1000;
            Console.WriteLine("число тысяч равно " + b);

            int c = (x % 100) / 10;
            
            int d = (x / 100) % 10; 
            
            int P = a * b * c * d;    
            Console.WriteLine("произведение цифр равно " + P);

            Console.ReadKey();  

        }
    }
}
