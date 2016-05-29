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

            // Наследование 
            new Employee {Age = 42, Pay = 300000};
            Console.ReadLine();
        }
    }
}
