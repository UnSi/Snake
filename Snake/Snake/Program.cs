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
            Draw(1, 3);
            Draw(4, 5, '#');
            Draw(4, 7, '#', ConsoleColor.Blue);

            Console.ReadLine();
        }
        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        static void Draw(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write('*');
        }
        static void Draw(int x, int y, char sym, ConsoleColor col)
        {
            Console.ForegroundColor = col;
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
            Console.ResetColor();
        }
    }
}
