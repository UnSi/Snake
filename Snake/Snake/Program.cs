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
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight); 

            // Рамка
            Walls walls = new Walls(Console.WindowWidth, Console.WindowHeight);
            walls.Draw();

            //Змея
            Point p = new Point(4,5);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();

            //Еда
            FoodCreator foodCreator = new FoodCreator(Console.WindowWidth, Console.WindowHeight, '$');
            Point food = foodCreator.CreateFood();
            Console.ForegroundColor = ConsoleColor.Cyan;
            food.Draw();
            Console.ResetColor();

            //Двигаем
            while(true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                    break;
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    food.Draw();
                    Console.ResetColor();
                }
                else snake.Move();
                Thread.Sleep(200);
                if (Console.KeyAvailable)
                {
                    snake.HandleKey(Console.ReadKey().Key);
                }
            }
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            snake.Clear();
            food.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Good Bye!");
            Console.ResetColor();
            Console.ReadLine();
        }
    }
}
