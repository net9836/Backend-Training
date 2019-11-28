using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Rectangle : IShape
    {
        private double Height;
        private double Width;

        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double GetArea()
        {
            return Height * Width;
        }

        public double GetPerimetor()
        {
            return (Height + Width) * 2;
        }
    }
}
