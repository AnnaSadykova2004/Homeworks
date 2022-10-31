using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(Translate());

        }

        static string Enter()
        {
            string phrase = Console.ReadLine();
            phrase = phrase.ToUpper();
            return phrase;
        }

        static string Translate()
        {
            string phrase2 = Enter();
            phrase2 = phrase2.Replace("A", "4");
            phrase2 = phrase2.Replace("B", "8");
            phrase2 = phrase2.Replace("C", "(");
            phrase2 = phrase2.Replace("D", "|)");
            phrase2 = phrase2.Replace("E", "3");
            phrase2 = phrase2.Replace("F", "|=");
            phrase2 = phrase2.Replace("G", "6");
            phrase2 = phrase2.Replace("H", "|-|");
            phrase2 = phrase2.Replace("I", "!");
            phrase2 = phrase2.Replace("J", ")");
            phrase2 = phrase2.Replace("K", "|<");
            phrase2 = phrase2.Replace("L", "1");
            phrase2 = phrase2.Replace("M", "|\\/|");
            phrase2 = phrase2.Replace("N", "|\\|");
            phrase2 = phrase2.Replace("O", "0");
            phrase2 = phrase2.Replace("P", "|>");
            phrase2 = phrase2.Replace("Q", "9");
            phrase2 = phrase2.Replace("R", "|2");
            phrase2 = phrase2.Replace("S", "5");
            phrase2 = phrase2.Replace("T", "7");
            phrase2 = phrase2.Replace("U", "|_|");
            phrase2 = phrase2.Replace("V", "\\/");
            phrase2 = phrase2.Replace("W", "\\/\\/");
            phrase2 = phrase2.Replace("X", "><");
            phrase2 = phrase2.Replace("Y", "'/");
            phrase2 = phrase2.Replace("X", "2");
            return phrase2;
        }

    }
}
