using System;
using System.Collections.Generic;
using System.Text;

namespace RectangleIntersection
{
    public class Rectangle
    {
        public string Id { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.Id = id;
            this.Width = width;
            this.Height = height;
            this.X = x;
            this.Y = y;
        }

        internal bool Intersect(Rectangle secondRectangle)
        {
            if (this.X + this.Width < secondRectangle.X 
                || secondRectangle.X + secondRectangle.Width < this.X
                || this.Y + this.Height < secondRectangle.Y
                || secondRectangle.Y + secondRectangle.Height < this.Y)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
