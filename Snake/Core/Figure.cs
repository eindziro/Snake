using System;
using System.Collections.Generic;

namespace Snake.Core
{
    public abstract class Figure
    {
        protected List<Point> _list;

        public void Draw()
        {
            foreach (Point point in _list)
            {
                point.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (Point point in _list)
            {
                if (figure.IsHit(point))
                    return true;
            }

            return false;
        }

        public bool IsHit(Point point)
        {
            foreach (Point p in _list)
            {
                if (p.IsHit(point))
                    return true;
            }

            return false;
        }
    }
}