using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<Point> plist;

        //****************constructors******************
        public VerticalLine(int x, int yLeft, int yRight, char sym)
        {
            plist = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                plist.Add(new Point(x, y, sym));
            }
        }
        public VerticalLine(int x, int yLeft, int yRight, char sym, bool draw)
        {
            plist = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                plist.Add(new Point(x, y, sym));
            }
            if (draw) this.Draw();
        }
        //****************constructors******************

        public void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
