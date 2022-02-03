using System;

namespace CSharpHomework
{
    public class RectangularTriangle : Triangle
    {
        public RectangularTriangle(Point XY1, Point XY2, Point XY3) : base(XY1, XY2, XY3)
        {
        }

        public override double GetArea()
        {
            return Math.Round(XY1.GetDistance(XY2) * XY2.GetDistance(XY3) / 2, 2);
        }
    }
}
