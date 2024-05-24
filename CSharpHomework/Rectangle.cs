using System;

namespace CSharpHomework
{
    public class Rectangle : Triangle
    {
        public Rectangle(Point XY1, Point XY2, Point XY3) : base(XY1, XY2, XY3)
        {
        }

        public override double GetArea()
        {
            // We will use three points (Triangle)
            // One side of the Rectangle and the diagonal line to find Area
            // A = s * sqrt(d^2 - s^2)

            return Math.Round(XY1.GetDistance(XY2) * Math.Sqrt(XY1.GetDistance(XY3) * XY1.GetDistance(XY3)
                - XY1.GetDistance(XY2) * XY1.GetDistance(XY2)));
        }
    }
}
