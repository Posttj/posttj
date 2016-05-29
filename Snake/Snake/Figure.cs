using System;
using System.Collections.Generic;

namespace Snake
{
    // Фигура
    class Figure
    {
        protected List<Point> PList;
 
        public void Drow()
        {
            foreach (var point in PList)
            {
                point.Draw();
            }
        }
    }
}
