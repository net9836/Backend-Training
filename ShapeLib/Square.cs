using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Square : IShape
    {

        public Square(double Side)
        {
            
        }
        public double GetArea()
        {
            return Side * Side;
        }

        public double GetPerimetor()
        {
            return side * 4;
        }
    }
}
