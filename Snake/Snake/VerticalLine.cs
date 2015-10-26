using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        //****************constructors******************
        public VerticalLine(int x, int yLeft, int yRight, char sym)
        {
            plist = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                plist.Add(new Point(x, y, sym));
            }
        }
        //****************constructors******************
        public override void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Draw();
            Console.ResetColor();
        }
    }
}
