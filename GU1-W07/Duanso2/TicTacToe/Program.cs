using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir;
            const int width = 70;
            const int height = 10;
            const int panel = 10;
            int input = -1;
            Console.SetWindowSize(width, height + panel);
            Console.ForegroundColor = ConsoleColor.DarkYellow;               // Chỉnh màu chữ
            Console.CursorVisible = false;                              // Ẩn con trỏ
            Console.WriteLine("============================================");
            Console.WriteLine("=================TIC TAC TOE================");
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("Pres any key to play");
            Console.WriteLine("Tips: - Use Arrow button to move the snake");
            Console.WriteLine("      - Press key 1 to Player vs Player   ");
            Console.WriteLine("      - Press key 2 to Player vs Bot      ");
            Console.WriteLine("      - Press key 3 to Bot vs Bot         ");
            Console.WriteLine("      - Press key 4 to Quit game          ");
            Console.WriteLine("");
            Console.Write("Choose your opt: ");
            if (int.TryParse(Console.ReadLine(), out input) && input >= 1 && input <= 5)
            {
                
                if (input == 1)
                {
                    TicTacToe game = new TicTacToe();
                    game.play();
                }



            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Error");
            }

            Console.ReadLine();
        }
    }
}
