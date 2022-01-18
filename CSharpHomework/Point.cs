using System;

namespace CSharpHomework
{
    public class Point
    {
        private int x;
        private int y;

        public int CoordinateX
        {
            get => x;
            set => x = value;
        }
        public int CoordinateY
        {
            get => y;
            set => y = value;
        }

        public Point(int x, int y)
        {
            CoordinateX = x;
            CoordinateY = y;
        }

        public override string ToString()
        {
            return $"Coordinates: x = {CoordinateX}, y = {CoordinateY}";
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (!(obj is Point))
            {
                return false;
            }

            // USE (obj as Point)? because it doesn't cause Exception!
            return (this.x == (obj as Point)?.CoordinateX)
                && (this.y == (obj as Point)?.CoordinateY);

            //return (this.x == ((Point)obj).CoordinateX)
            //    && (this.y == ((Point)obj).CoordinateY);
        }

        public static Point operator +(Point x, Point y)
        {
            return new Point(x.x + y.x, x.y + y.y);
        }

        public double GetDistance(Point point)
        {
            double result = (this.CoordinateX - point.CoordinateX) * (this.CoordinateX - point.CoordinateX)
                + (this.CoordinateY - point.CoordinateY) * (this.CoordinateY - point.CoordinateY);

            return Math.Round(Math.Sqrt(result), 2);
        }
    }
}
