using System.Collections.Generic;

namespace Snake
{
    class HorizantalLine : Figure
    {
        //private readonly List<Point> _pList;

        public HorizantalLine(int xLeft, int xRight, int y, char sym)
        {
            PList = new List<Point>();
            for (var x = xLeft; x < xRight; x++)
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
