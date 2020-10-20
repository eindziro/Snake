using System.Collections.Generic;

namespace Snake.Core
{
    public class VerticalLine : Figure
    {
        public VerticalLine(int downY, int upY, int x, char sym)
        {
            _list = new List<Point>();

            for (int y = downY; y < upY; y++)
            {
                Point point = new Point(x, y, sym);
                _list.Add(point);
            }
        }
    }
}