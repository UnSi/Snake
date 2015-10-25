using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class HorizontalLine : Figure
    {
        //****************constructors******************
        public HorizontalLine(int xLeft,int xRight,int y, char sym)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                plist.Add(new Point(x, y, sym));
            }
        }
        public HorizontalLine(int xLeft, int xRight, int y, char sym, bool draw)
        {
            plist = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                plist.Add(new Point(x, y, sym));
            }
            if (draw) this.Draw();
        }
        //****************constructors******************
    }
}
