using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120, 50);

            // Рамка
            HorizontalLine upLine = new HorizontalLine(0, 118, 0, '+', true);
            HorizontalLine downLine= new HorizontalLine(0, 118, 49, '+', true);
            VerticalLine leftLine = new VerticalLine(0, 0, 49, '+', true);
            VerticalLine rightLine = new VerticalLine(118, 0, 49, '+', true);

            //Змея
            Point p = new Point(4,5);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(500);
                snake.Move();
            }

            Console.ReadLine();
        }
        
    }
}
