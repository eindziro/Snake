using System.Collections.Generic;

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
            if (_direction == Direction.UP)
            {
            }
            else if (_direction == Direction.RIGHT)
            {
            }
            else if (_direction == Direction.DOWN)
            {
            }
            else if (_direction == Direction.LEFT)
            {
            }
        }
    }
}