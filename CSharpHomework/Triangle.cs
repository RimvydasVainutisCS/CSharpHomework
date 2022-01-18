using System;

namespace CSharpHomework
{
    public class Triangle
    {
        public Point XY1 { get; set; }
        public Point XY2 { get; set; }
        public Point XY3 { get; set; }

        public Triangle(Point pointOne, Point pointTwo, Point pointThree)
        {
            XY1 = pointOne;
            XY2 = pointTwo;
            XY3 = pointThree;
        }

        public double GetPerimeter()
        {
            return XY1.GetDistance(XY2) + XY2.GetDistance(XY3) + XY3.GetDistance(XY1);
        }

        public double GetHalfPerimeter()
        {
            return (XY1.GetDistance(XY2) + XY2.GetDistance(XY3) + XY3.GetDistance(XY1)) / 2;
        }

        // Triangle area Heron's formula: sqrt(p(p - a) * (p - b) * (p - c)
        // p = P / 2 = (a + b + c) / 2

        public virtual double GetArea()
        {
            return Math.Round(Math.Sqrt(GetHalfPerimeter() *
                (GetHalfPerimeter() - XY1.GetDistance(XY2)) *
                (GetHalfPerimeter() - XY2.GetDistance(XY3)) *
                (GetHalfPerimeter() - XY3.GetDistance(XY1))), 2);
        }
    }
}
