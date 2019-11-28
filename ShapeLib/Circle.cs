using System;
using System.Collections.Generic;
using System.Text;

namespace ShapeLib
{
    public class Circle : IShape
    {
        private double Redius;

        public Circle(double redius)
        {
            Redius = redius;
        }
        public double GetArea()
        {
            return Math.PI * Redius * Redius; //Math.Pow(Redius, 2)

        }

        public double GetPerimetor()
        {
            return 2 * Math.PI * Redius;
        }
    }
}
