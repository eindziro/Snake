using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake.Core
{
    public class Snake : Figure
    {
        private Direction _direction;

        public Snake(Point tail, int length, Direction direction)
        {
            _list = new List<Point>();
            _direction = direction;
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                _list.Add(p);
            }
        }

        public void Move()
        {
            Point tail = _list.First();
            _list.Remove(tail);
            Point head = GetNextPoint();
            _list.Add(head);
            tail.Clear();
            head.Draw();
        }

        private Point GetNextPoint()
        {
            Point head = _list.Last();
            Point nextPoint = new Point(head);
            nextPoint.Move(1, _direction);
            return nextPoint;
        }

        public void HandleClick(ConsoleKey consoleKey)
        {
            switch (consoleKey)
            {
                case ConsoleKey.UpArrow:
                    _direction = Direction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    _direction = Direction.DOWN;
                    break;
                case ConsoleKey.RightArrow:
                    _direction = Direction.RIGHT;
                    break;
                case ConsoleKey.LeftArrow:
                    _direction = Direction.LEFT;
                    break;
                default:
                    break;
            }
        }

        public bool Eat(Point food)
        {
            Point head = GetNextPoint();

            if (head.IsHit(food))
            {
                food.Sym = head.Sym;
                _list.Add(food);
                return true;
            }

            return false;
        }

        public bool IsHitTail()
        {
            Point head = _list.Last();
            for (int i = 0; i < _list.Count - 2; i++)
            {
                if (head.IsHit(_list[i]))
                    return true;
            }

            return false;
        }
    }
}