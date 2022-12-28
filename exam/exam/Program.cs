using System;

namespace exam
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите натуральное число n");
            int n = int.Parse(Console.ReadLine( ));

            Console.WriteLine();
            Console.WriteLine("Сиракузская последовательность:");
            Console.Write(n + ", ");

            int maxElement = n;
            for (; n != 1;)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
                if (n > maxElement) 
                    maxElement = n;
                
                Console.Write($"{n}, ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nМаксимальное число в последовательности = {maxElement}"); 
       
            Console.ReadKey();
        }
    }
}
