using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework
{
    internal class Point
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

            return (this.x == ((Point)obj).CoordinateX)
                && (this.y == ((Point)obj).CoordinateY);
        }

        public static Point operator +(Point x, Point y)
        {
            Point z = new Point(0, 0);
            z.x = x.x + y.x;
            z.y = x.y + y.y;
            return z;
        }
    }
}
