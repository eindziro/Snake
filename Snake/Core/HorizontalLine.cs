using System.Collections.Generic;

namespace Snake.Core
{
    public class HorizontalLine : Figure
    {
        public HorizontalLine(int leftX, int rightX, int y, char sym)
        {
            _list = new List<Point>();
            for (int x = leftX; x <= rightX; x++)
            {
                Point p = new Point(x, y, sym);
                _list.Add(p);
            }
        }
    }
}