using System;
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

        //****************constructors******************
        public Point()
        {
            x = 0;
            y = 0;
            sym = '*';
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
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

        //****************constructors******************
 
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Move(int offset, Direction direction)
        {
            switch(direction)
            {
                case (Direction.DOWN): y=y+offset; break;
                case (Direction.LEFT): x=x-offset; break;
                case (Direction.RIGHT): x=x+offset; break;
                case (Direction.UP): y=y-offset; break;
                default: Console.WriteLine("Error"); break;
            }
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        internal bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
    }
}
