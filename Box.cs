﻿using System;

namespace ClassAdv3_2
{
    internal class Box
    {
        private int width;
        public int Width
        {
            get { return width; }
            set
            {
                if (value < 0)
                {
                    throw (new Exception("width는 양수"));
                }
                width = value;
            }
        }

        private int height;
        public int Height
        {
            get { return height; }
            set
            {
                if (value < 0)
                {
                    throw (new Exception("height는 양수"));
                }
                else Console.WriteLine(value);
                height = value;
            }
        }

        public Box(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public int GetArea()
        {
            return this.Width * this.Height;
        }

    }
}