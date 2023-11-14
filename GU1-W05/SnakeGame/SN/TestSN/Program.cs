using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestSN
{
    public static class ConsoleHelper
    {
        public static void SetCursor(Point p)
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(p.X, p.Y);
        }
    }

    public sealed class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point() { }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.X + p2.X, p1.Y + p2.Y);
        }

        public override bool Equals(object obj)
        {
            Point p = (Point)obj;
            if (p == null)
                return false;
            return X == p.X && Y == p.Y;
        }

        public override int GetHashCode()
        {
            return X ^ Y;
        }
    }

    public sealed class SnakeGame
    {
        private enum Direction
        {
            Up = 1,
            Right = 2,
            Down = 3,
            Left = 4,
        }

        private Dictionary<Direction, Point> DirectionToPoint = new Dictionary<Direction, Point>
        {
            { Direction.Down, new Point(0,1)},
            { Direction.Up, new Point(0,-1)},
            { Direction.Right, new Point(1,0)},
            { Direction.Left, new Point(-1,0)},
        };

        public int Width { get; set; }
        public int Height { get; set; }
        private Direction direction;
        private IList<Point> Body { get; set; }
        private Point food;
        private Random random;
        private bool isDead = false;
        public bool IsDead
        {
            get { return isDead; }
        }
        public bool Walls { get; set; }

        public SnakeGame(int width, int height)
        {
            Width = width;
            Height = height;
            Body = new List<Point>() { new Point() };
            random = new Random();
            food = new Point();
            GenerateFood();
            direction = Direction.Right;
        }

        private void GenerateFood()
        {
            do
            {
                food.X = random.Next(Width);
                food.Y = random.Next(Height);
            } while (Body.Contains(food));
        }

        public void ChangeDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.A || key == ConsoleKey.LeftArrow)
                direction = Direction.Left;
            else if (key == ConsoleKey.D || key == ConsoleKey.RightArrow)
                direction = Direction.Right;
            else if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                direction = Direction.Up;
            else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                direction = Direction.Down;
        }

        bool ValidateNextStep(Point p)
        {
            return p.X >= 0 && p.X < Width && p.Y >= 0 && p.Y <= Height;
        }

        void ChangeNextStep(Point p)
        {
            if (p.X < 0)
                p.X += Width;
            else if (p.X >= Width)
                p.X -= Width;
            else if (p.Y < 0)
                p.Y += Height;
            else if (p.Y >= Height)
                p.Y -= Height;
        }

        public bool Move()
        {
            Point nextStep = Body.First() + DirectionToPoint[direction];

            if (!Walls)
                ChangeNextStep(nextStep);

           
            if (!ValidateNextStep(nextStep) || Body.Contains(nextStep))
            {
                isDead = true;
                return false;
            }

            
            if (nextStep.Equals(food))
            {
                Body.Insert(0, nextStep);
                GenerateFood();
            }
            
            else
            {
                Body.RemoveAt(Body.Count - 1);
                Body.Insert(0, nextStep);
            }

            return true;
        }

        public void Draw()
        {
            Console.Clear();
            // head
            Console.ForegroundColor = ConsoleColor.Cyan;
            ConsoleHelper.SetCursor(Body.First());
            Console.Write("▲►▼◄"[(int)direction - 1]);
            // body
            Console.BackgroundColor = ConsoleColor.Cyan;
            foreach (var p in Body.Skip(1))
            {
                ConsoleHelper.SetCursor(p);
                Console.Write(" ");
            }
            Console.ResetColor();
            // food
            Console.ForegroundColor = ConsoleColor.Red;
            ConsoleHelper.SetCursor(food);
            Console.Write("♥");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SnakeGame game = new SnakeGame(Console.WindowWidth, Console.WindowHeight);
            Console.WriteLine("Walls 0/1 [0 = off, 1 = on]?");
            game.Walls = Console.ReadLine() == "1";
            Console.WriteLine("Interval between move in miliseconds? (recommended interval is 100ms)");
            int interval = int.Parse(Console.ReadLine());

            new Thread(new ThreadStart(() =>
            {
                while (game.Move())
                {
                    game.Draw();
                    Thread.Sleep(interval);
                }
                Console.Clear();
                Console.WriteLine("YOU LOST!");
            })).Start();

            do
                game.ChangeDirection(Console.ReadKey(true).Key);
            while (!game.IsDead);

        }
    }
}
