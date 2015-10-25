﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake : Figure
    {
        Direction direction;
        public Snake(Point tail, int length, Direction direction)
        {
            this.direction = direction;
            plist = new List<Point>();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }


        internal void Move()
        { 
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            tail.Clear();
            head.Draw();
        }

        public Point GetNextPoint()
        {
            Point head = plist.Last() ;
            Point nextPoint = new Point(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case (ConsoleKey.RightArrow): direction = Direction.RIGHT; break;
                case (ConsoleKey.LeftArrow): direction = Direction.LEFT; break;
                case (ConsoleKey.UpArrow): direction = Direction.UP; break;
                case (ConsoleKey.DownArrow): direction = Direction.DOWN; break;
            }
        }
        public bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit(food))
            {
                food.sym = head.sym;
                plist.Add(food); 
                return true;
            }
            else
            return false;
        }

    }
}
