using System;
using System.Linq;
using System.Threading;

namespace Snake.Core
{
    public class Game
    {
        private const int MAP_WIDTH = 90;
        private const int MAP_HEIGHT = 30;

        private Walls _walls;
        private Snake _snake;
        private Point _food;
        private FoodProvider _foodProvider;

        public void Init()
        {
            _walls = new Walls(MAP_WIDTH, MAP_HEIGHT);
            _walls.Draw();

            Point tailPoint = new Point(5, 5, '*');
            _snake = new Snake(tailPoint, 10, Direction.RIGHT);
            _snake.Draw();

            _foodProvider = new FoodProvider(MAP_WIDTH, MAP_HEIGHT, '$');
            _food = _foodProvider.CreateFood();
        }

        public void Play()
        {
            while (true)
            {
                if (_walls.IsHit(_snake) || _snake.IsHitTail())
                {
                    break;
                }

                if (_snake.Eat(_food))
                {
                    _food = _foodProvider.CreateFood();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo info = Console.ReadKey();
                    _snake.HandleClick(info.Key);
                }

                Thread.Sleep(100);
                _snake.Move();
            }

        }

        public bool IsGameOver()
        {
            Console.Clear();
            Console.WriteLine("Game Over. \n Do you want to play again? \n y/n?");
            string answer = String.Empty;
            while (answer != "y" && answer != "n")
            {
                answer = Console.ReadLine();
            }

            if (answer == "y")
            {
                Console.Clear();
                Init();
                return false;
            }

            return true;
        }
    }
}