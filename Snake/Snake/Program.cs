using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, true);
            Point p2 = new Point(4, 5, '#', true);

            HorizontalLine hl1 = new HorizontalLine(5, 10, 8, '+', true);
            VerticalLine vl1 = new VerticalLine(11, 8, 15, '*', true);

            Console.ReadLine();
        }
        
    }
}
