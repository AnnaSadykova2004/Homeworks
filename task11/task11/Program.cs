using System;

namespace task11
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of rows and columns in the table");
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            var table = new int[m, n];
            if (!CheckRowsColumnsNumber(m, n))
            {
                Console.WriteLine("The number of rows and columns should be from 5 to 20");
            }
            else
            {
                var rnd = new Random();
                for (int i = 0; i < table.GetLength(0); i++)
                    for (int j = 0; j < table.GetLength(1); j++)
                        table[i, j] = rnd.Next(100);
                PrintTable(table);
            }

            Console.WriteLine(string.Join(" ", GetElementsSum(table, m, n)));

            CheckAscendingOrder(table, m, n);
        }
        static void PrintTable(int[,] t)
        {
            for (var i = 0; i < t.GetLength(0); i++)
            {
                for (var j = 0; j < t.GetLength(1); j++)
                    Console.Write($"{t[i, j],2} ");
                    Console.WriteLine();
            }
                Console.WriteLine();
        }

        static bool CheckRowsColumnsNumber(int a, int b)
        {
            return a >= 5 && a <= 20 && b >= 5 && b <= 20;
        }

        static void CheckAscendingOrder(int[,] array, int m, int n)
        {
            int[] check = new int[1];
            check[0] = m;
            for (int i = 0; i < m; i++)
            {
                if (check[0] == m)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (array[i, j] > array[i, j + 1])
                        {
                            check[0] = i;
                            Console.WriteLine("В строке " + i + " элемент " + j + " больше чем " + (j + 1));
                            break;
                        }
                    }

                }
                else
                {
                    break;
                }
            }
        }
            
        static int[] GetElementsSum(int[,] array, int m, int n)
        {
            int sum = 0;
            int[] arraysum = new int[n];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < n; i += 2)
                {
                    sum += array[i, j];
                }
                arraysum[j] = sum;
                sum = 0;
            }
            return arraysum;
        }
            
    }
}
