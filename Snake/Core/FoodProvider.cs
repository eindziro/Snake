using System;

namespace Snake.Core
{
    public class FoodProvider
    {
        private int _maxX;
        private int _maxY;
        private char _sym;

        private Random _random = new Random();


        public FoodProvider(int maxX, int maxY, char sym)
        {
            _maxX = maxX;
            _maxY = maxY;
            _sym = sym;
        }

        public Point CreateFood()
        {
            int x = _random.Next(2, _maxX - 2);
            int y = _random.Next(2, _maxY - 2);
            Point food = new Point(x, y, _sym);
            food.Draw();
            return food;
        }
    }
}