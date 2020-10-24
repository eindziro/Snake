using System;
using System.Threading;

namespace Snake
{
    using Snake.Core;

    internal class Program
    {
        public static void Main(string[] args)
        {
            VerticalLine leftBorder = new VerticalLine(0, 28, 0, '#');
            VerticalLine rightBorder = new VerticalLine(0, 28, 88, '#');
            HorizontalLine upBorder = new HorizontalLine(0, 88, 28, '#');
            HorizontalLine downBorder = new HorizontalLine(0, 88, 0, '#');
            rightBorder.Draw();
            leftBorder.Draw();
            upBorder.Draw();
            downBorder.Draw();

            Point tailPoint = new Point(5, 5, '*');
            Snake snake = new Snake(tailPoint, 10, Direction.RIGHT);
            snake.Draw();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    snake.HandleClick(info.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.Read();
        }
    }
}