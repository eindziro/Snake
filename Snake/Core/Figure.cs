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
    }
}