using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шахматы
{
    internal class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Введите позицию белого коня");
            var WhiteKnightPosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черного коня");
            var BlackKnightPosition = Console.ReadLine();

            if (!CheckPosition(WhiteKnightPosition) || !CheckPosition(BlackKnightPosition))
            {
                Console.WriteLine("Так ставить фигуры нельзя. ");
                Console.ReadKey();

            }
            if (KnightUnderStrike(BlackKnightPosition, WhiteKnightPosition))
            {
                Console.WriteLine("Кони под ударом друг друга");
                Console.ReadKey();
            }
            Console.WriteLine("Введите ход белого коня");
            var WhiteKnightMove = Console.ReadLine();
            if (!CorrectMove(WhiteKnightPosition, WhiteKnightMove))
            {
                Console.WriteLine("Конь так не ходит");
                Console.ReadKey();
            }
            else if (WhiteKnightMove == BlackKnightPosition)
            {
                Console.WriteLine("Черный конь срублен");
                Console.ReadKey();
            }
            else
            {
                if (KnightUnderStrike(BlackKnightPosition, WhiteKnightMove))
                {
                    Console.WriteLine("Кони под ударом друг друга");
                    Console.ReadKey();
                }

            }

        }
        static void DecodePosition(string position, out int row, out int colomn)
        {
            row = int.Parse(position[1].ToString());
            colomn = (int)position[0] - 0x60;

        }
        static bool CheckPosition(string position)
        {
            int r, c;
            DecodePosition(position, out r, out c);
            return r >= 1 & r <= 8 & c >= 1 & c <= 8;
        }
        static bool KnightUnderStrike(string bk, string wk)
        {
            int wr, wc, br, bc;
            DecodePosition(bk, out br, out bc);
            DecodePosition(wk, out wr, out wc);
            return ((Math.Abs(br - wr) == 1) & (Math.Abs(bc - wc) == 2) || ((Math.Abs(bc - wc) == 1) & (Math.Abs(br - wr) == 2)));
        }
        static bool CorrectMove(string wks, string wke)
        {
            int wksr, wksc, wkre, wkce;
            DecodePosition(wks, out wksr, out wksc);
            DecodePosition(wke, out wkre, out wkce);
            return ((Math.Abs(wksr - wkre) == 1) & (Math.Abs(wksc - wkce) == 2) || ((Math.Abs(wkce - wksc) == 1) & (Math.Abs(wkre - wksr) == 2)));
        }
    }
}
