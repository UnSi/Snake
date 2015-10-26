﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Walls:Figure
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeight)
        {
            wallList = new List<Figure>();
            HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '-');
            HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '-');
            VerticalLine leftLine = new VerticalLine(0, 0, mapHeight - 1, '|');
            VerticalLine rightLine = new VerticalLine(mapWidth - 2, 0, mapHeight - 1, '|');
            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure)) return true;
            }
            return false;
        }
                

        public override void Draw()
        {
            foreach (Figure f in wallList)
                f.Draw();
        }
    }
}
