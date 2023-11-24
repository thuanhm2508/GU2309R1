using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicTacToe game = new TicTacToe();
            int input;
        put:
            Console.ForegroundColor = ConsoleColor.DarkBlue;               // Chỉnh màu chữ
            Console.CursorVisible = false;                              // Ẩn con trỏ
            Console.WriteLine("============================================");
            Console.WriteLine("=================TIC TAC TOE================");
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("Tips: - Use 1 - 9 number to play game     ");
            Console.WriteLine("      - Press key 1 to Play vs Bot        ");
            Console.WriteLine("      - Press key 2 to Bot vs Bot         ");
            Console.WriteLine("      - Press key 3 to Play vs Play       ");
            Console.WriteLine("      - Press key 4 to quit game          ");
            Console.WriteLine(" ");

            if (int.TryParse(Console.ReadLine(), out input))
            {
                if (input == 1)
                {
                    game.play2();
                }
                if (input == 2)
                {
                    game.play3();
                }
                if (input == 3)
                {
                    game.play();
                }
                if (input == 4)
                {
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Input Invalid. Please try again: ");
                goto put;
            }
            Console.ReadKey();
        }
    }
}
