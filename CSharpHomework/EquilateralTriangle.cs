using System;

namespace CSharpHomework
{
    public class EquilaterialTriangle : Triangle
    {
        public EquilaterialTriangle(Point XY1, Point XY2, Point XY3) : base(XY1, XY2, XY3)
        {
        }

        public override double GetArea()
        {
            return Math.Round(XY1.GetDistance(XY2) * XY1.GetDistance(XY2) * Math.Sqrt(3) / 4, 2);
        }
    }
}
