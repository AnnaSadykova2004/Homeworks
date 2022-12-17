using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "перемена";
            Console.WriteLine(word);
            string word1 = word.Replace(word[6], word[2]);
            Console.WriteLine(word1.Remove(0,4));
            string word2 = word.Remove(3,5);
            Console.WriteLine(word2.Replace(word[0], word[6]) + word[0] + word[7]);
            Console.ReadKey();
        }
    }
}
