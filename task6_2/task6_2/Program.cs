using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "перемена";
            string word1 = word.Substring(4);
            Console.WriteLine(word1.Replace("н", "р"));
            string word2 = word1.Replace("н", "рп");
            Console.WriteLine(word[6] + word2.Remove(0, 1));
            Console.ReadKey();

        }
    }
}
