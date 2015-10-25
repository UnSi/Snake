﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        public ConsoleColor col;

        //****************constructors******************
        public Point()
        {
            x = 0;
            y = 0;
            sym = '*';
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.sym = '*';
        }
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        // с цветом
        public Point(int x, int y, ConsoleColor col)
        {
            this.x = x;
            this.y = y;
            this.sym = '*';
            this.col = col;
        }
        public Point(int x, int y, char sym, ConsoleColor col)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            this.col = col;
        }

        // с рисованием
        public Point(int x, int y, bool draw)
        {
            this.x = x;
            this.y = y;
            this.sym = '*';
            if (draw) this.Draw();
        }
        public Point(int x, int y, char sym,bool draw)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
            if (draw) this.Draw();
        }

        //****************constructors******************
 
        public void Draw()
        {
            if (col!=ConsoleColor.Black)
            Console.ForegroundColor = col;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            Console.ResetColor();
        }
    }
}
