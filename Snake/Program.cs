using System;
using System.Threading;

namespace Snake
{
    using Snake.Core;

    internal class Program
    {
        public static void Main(string[] args)
        {
            Game game = new Game();
            game.Init();
            while (true)
            {
                game.Play();
                if (game.IsGameOver())
                {
                    break;
                }
            }
        }
    }
}