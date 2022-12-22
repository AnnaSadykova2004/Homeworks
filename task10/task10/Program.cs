using System;

namespace task10
{
    internal class Program
    {
        static void Main()
        {
            //задание 1
            Console.WriteLine("Введите значение натурального b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Массив:");
            double[] array = new double[15];
            int n = 1;
            int i = 0;
            array[0] = 1;

            for (int p = 1; p < 15; p++)
            {
                n *= 2;
                array[p] = n;
            }

            for (; i < array.Length; i++)
            {
                array[i] = array[i] - b;
            }

            PrintMassive(array);//задание 2

            Console.WriteLine(string.Join("; ", ChangeSign(array)));//задание 3

            SredArifm(array);//задание 4
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(string.Join("; ", OstatokDelenia(array, k)));
            Console.ReadKey();
        }

        static void PrintMassive(double[] massiv)
        {
            Console.WriteLine(string.Join(" ;", massiv));
            // for (int i = 0; i < massiv.Length; i++)
            //{
            //  Console.Write(massiv[i] + ";");
            //}
            //return massiv;
        }
        static double[] ChangeSign(double[] massiv1)
        {
            for (int i = 0; i < massiv1.Length; i++)
            {
                if (i % 2 != 0)
                {
                    massiv1[i] *= (-1);
                }
            }
            return massiv1;
        }
        static void SredArifm(double[] massiv2)
        {
            double summElements = 0;
            for (int i = 0; i < massiv2.Length; i++)
            {
                summElements += massiv2[i];
            }
            double mid = summElements / massiv2.Length;
            mid = Math.Round(mid, 3);
            Console.WriteLine("Среднее арифметическое элементов массива равно " + mid);

            //return massiv2;
        }
        static double[] OstatokDelenia(double[] array, int o)
        {
            double[] massiv3 = new double[15];
            Array.Copy(array, massiv3, array.Length);
            for (int y = 0; y < array.Length; y++)
            {
                massiv3[y] = massiv3[y] % o;
            }
            return massiv3;
        }


    }
}
