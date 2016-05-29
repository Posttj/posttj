using System.Collections.Generic;

namespace Snake
{
    class VerticalLine : Figure
    {
        //private readonly List<Point> _pList;

        public VerticalLine(int yUp, int yDown, int x, char sym)
        {
            PList = new List<Point>();

            for (var y = yUp; y < yDown; y++)
            {
                var p = new Point(x, y, sym);
                PList.Add(p);
            }
        }

        //public void Drow()
        //{
        //    foreach (var point in _pList)
        //    {
        //        point.Draw();
        //    }
        //}
    }
}
