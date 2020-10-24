using System;

namespace Snake.Core
{
    public class Point
    {
        private int _x;
        private int _y;
        private char _sym;

        public char Sym
        {
            get => _sym;
            set => _sym = value;
        }

        public Point(int x, int y, char sym)
        {
            _x = x;
            _y = y;
            _sym = sym;
        }

        public Point(Point other)
        {
            _x = other._x;
            _y = other._y;
            _sym = other._sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(_x, _y);
            Console.Write(_sym);
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.UP)
            {
                _y = _y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                _y = _y + offset;
            }
            else if (direction == Direction.RIGHT)
            {
                _x = _x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                _x = _x - offset;
            }
        }

        public override string ToString()
        {
            return $"{_x} {_y} {_sym}";
        }

        public void Clear()
        {
            _sym = ' ';
            Draw();
        }

        public bool IsHit(Point other)
        {
            return other._x == _x && other._y == _y;
        }
    }
}