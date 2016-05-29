using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(3, 4, '*');
            point.Draw();

            var horizantalLine = new HorizantalLine(5, 10, 8, '+');
            horizantalLine.Drow();

            Console.ReadLine();
        }
    }
}
