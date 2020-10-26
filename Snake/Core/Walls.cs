using System.Collections.Generic;

namespace Snake.Core
{
    public class Walls
    {
        private List<Figure> walls;

        public Walls(int mapWidth, int mapHeight)
        {
            VerticalLine leftBorder = new VerticalLine(0, mapHeight-1, 0, '+');
            VerticalLine rightBorder = new VerticalLine(0, mapHeight-1, 88, '+');
            HorizontalLine upBorder = new HorizontalLine(0, mapWidth-2, mapHeight-1, '+');
            HorizontalLine downBorder = new HorizontalLine(0, mapWidth-2, 0, '+');

            walls = new List<Figure>() {rightBorder, leftBorder, upBorder, downBorder};
        }

        public bool IsHit(Figure figure)
        {
            foreach (Figure wall in walls)
            {
                if (wall.IsHit(figure))
                    return true;
            }

            return false;
        }

        public void Draw()
        {
            foreach (Figure figure in walls)
            {
                figure.Draw();
            }
        }
    }
}