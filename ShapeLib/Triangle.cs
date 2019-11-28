using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Triangle : IShape
    {
        private double Height;
        private double Width;

        public Triangle(double height , double width)
        {
            Height = height;
            Width = width;
        }

        public double GetArea()
        {
            return 0.5 * Height * Width;
        }

        public double GetPerimetor()
        {
            return Height + Width + (Math.Sqrt(Math.Pow(Height, 2) + Math.Pow(Width, 2)));
        }
    }
}
