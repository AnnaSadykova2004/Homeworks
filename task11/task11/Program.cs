using System;

namespace task11
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число строк и столбцов таблицы");
            var m = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            if (!CheckRowsColumnsNumber(m, n))
                Console.WriteLine("Число строк и столбцов должно быть от 5 до 20");

            else
            {
                var table = new int[m, n];
                var rnd = new Random();

                for (int i = 0; i < table.GetLength(0); i++)
                    for (int j = 0; j < table.GetLength(1); j++)
                        table[i, j] = rnd.Next(100);
                PrintTable(table);

            }

            Console.WriteLine(CheckElementsOrder(table));

            Console.ReadKey();

        }

        static bool CheckRowsColumnsNumber(int a, int b)//проверка правильности ввода числа строк и столбцов
        {
            return a >= 5 && a <= 20 && b >= 5 && b <= 20;
        }

        static void PrintTable(int[,] t)//вывод массива
        {
            for (var i = 0; i < t.GetLength(0); i++)
            {
                for (var j = 0; j < t.GetLength(1); j++)
                    Console.Write($"{t[i, j],2} ");

                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static int[,] CheckElementsOrder(int[,] t, int i, int j, int j2)//определяет идут ли элементы по возрастанию
        {
            Console.Write("Элементы, нарушающие порядок:");
            i = 0;
            j = 0;
            j2 = j + 1; 

            for (; i < t.GetLength(0); i++)
            {
                for (; j < t.GetLength(1);j++)
                {
                    if (t[i,j2] < t[i,j])
                    {
                        return (i,j, j2);
                    }
                }

            }

        }

    }
}

