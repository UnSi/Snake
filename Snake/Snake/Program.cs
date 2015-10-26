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
            HorizontalLine upLine = new HorizontalLine(0, 118, 0, '+');
            HorizontalLine downLine= new HorizontalLine(0, 118, 49, '+');
            VerticalLine leftLine = new VerticalLine(0, 0, 49, '+');
            VerticalLine rightLine = new VerticalLine(118, 0, 49, '+');

            //Змея
            Point p = new Point(4,5);
            Figure fsnake = new Snake(p, 4, Direction.RIGHT);
            fsnake.Draw();
            Snake snake = (Snake)fsnake;
           // Snake snake = new Snake(p, 4, Direction.RIGHT);
          //  snake.Draw();
            List<Figure> figures = new List<Figure>();
            figures.Add(upLine);
            figures.Add(downLine);
            figures.Add(leftLine);
            figures.Add(rightLine);
            figures.Add(snake);
            foreach (Figure f in figures)
            {
                f.Draw();
            }

            //Еда
            FoodCreator foodCreator = new FoodCreator(120, 50, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            //Двигаем
            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else snake.Move();
                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    snake.HandleKey(Console.ReadKey().Key);
                }
                
                //snake.Move();
            }
        }
    }
}
