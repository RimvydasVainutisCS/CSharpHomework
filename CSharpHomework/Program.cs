using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 001");
            Console.WriteLine("\n------");

            var pointOne = new Point(3, 4);
            var pointTwo = new Point(4, 4);
            var pointThree = new Point(4, 3);
            var pointFour = new Point(4, 4);

            //Console.WriteLine(pointOne.CoordinateX);
            //Console.WriteLine(pointOne.CoordinateY);

            Console.WriteLine(pointOne.ToString());
            Console.WriteLine(pointTwo.ToString());
            Console.WriteLine(pointThree.ToString());
            Console.WriteLine(pointFour.ToString());

            Console.WriteLine("\n------");

            Console.WriteLine(pointOne.Equals(pointTwo));
            Console.WriteLine(pointOne.Equals(pointThree));
            Console.WriteLine(pointOne.Equals(pointFour));

            Console.ReadLine();
        }
    }
}
