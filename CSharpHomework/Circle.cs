using System;

namespace CSharpHomework
{
    internal class Circle : Figure
    {
        const double pi = Math.PI;
        public Circle(Point pointOne, Point pointTwo)
        {
            XY1 = pointOne;
            XY2 = pointTwo;
        }
        public double GetPerimeter()
        {
            return Math.Round(2 * XY1.GetDistance(XY2) * pi, 2);
        }
        public override double GetArea()
        {
            return Math.Round(pi * XY1.GetDistance(XY2) * XY1.GetDistance(XY2), 2);
        }
    }
}
