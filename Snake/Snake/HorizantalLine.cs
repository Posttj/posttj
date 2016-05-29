using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizantalLine
    {
        private readonly List<Point> _pList;

        public HorizantalLine(int xLeft, int xRight, int y, char sym)
        {
            _pList = new List<Point>();
            for (var x = xLeft; x < xRight; x++)
            {
                var p = new Point(x, y, sym);
                _pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (var point in _pList)
            {
                point.Draw();
            }
        }
    }
}
