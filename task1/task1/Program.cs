using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Сергей Александрович Есенин");
            Console.ForegroundColor= ConsoleColor.Blue;
            Console.WriteLine(" Не жалею, не зову, не плачу...");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n Не жалею, не зову, не плачу,\n Все пройдет, как с белых яблонь дым.");
            Console.ResetColor();

            Console.ReadKey();

        }
    }
}
