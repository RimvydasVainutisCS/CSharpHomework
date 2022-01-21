using System;
using System.Collections.Generic;

namespace CSharpHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Homework 001");
            Console.WriteLine("\n------");

            var pointOne = new Point(0, 0);
            var pointTwo = new Point(0, 10);
            var pointThree = new Point(10, 10);
            var pointFour = new Point(3, 4);

            var triangleOne = new Triangle(pointOne, pointTwo, pointThree);
            var triangleTwo = new EquilaterialTriangle(pointOne, pointTwo, pointThree);
            var triangleThree = new RectangularTriangle(pointOne, pointTwo, pointThree);

            var circleOne = new Circle(pointOne, pointTwo);

            var rectangleOne = new Rectangle(pointOne, pointTwo, pointThree);

            Console.WriteLine(pointOne.ToString());
            Console.WriteLine(pointTwo.ToString());
            Console.WriteLine(pointThree.ToString());
            Console.WriteLine(pointFour.ToString());

            Console.WriteLine("------");
            Console.WriteLine();

            Console.WriteLine($"Are the {pointOne} equal to {pointTwo}? Answer: {pointOne.Equals(pointTwo)}.");
            Console.WriteLine($"Are the {pointOne} equal to {pointThree}? Answer: {pointOne.Equals(pointThree)}.");
            Console.WriteLine($"Are the {pointOne} equal to {pointFour}? Answer: {pointOne.Equals(pointFour)}.");

            Console.WriteLine();
            Console.WriteLine($"Sum of {pointOne} and {pointTwo} are coordinates: {pointOne + pointTwo}.");
            Console.WriteLine($"Sum of {pointOne} and {pointThree} are coordinates: {pointOne + pointThree}.");
            Console.WriteLine($"Sum of {pointOne} and {pointFour} are coordinates: {pointOne + pointFour}.");
            Console.WriteLine();

            Console.WriteLine($"Perimeter of the triangle made of points " +
                $"\nXY1: {pointOne}, " +
                $"\nXY2: {pointTwo}, " +
                $"\nXY3: {pointThree} " +
                $"\nis {triangleOne.GetPerimeter()}");
            Console.WriteLine();

            Console.WriteLine($"Area of triangle: {triangleOne.GetArea()}");

            Console.WriteLine($"Area of Equilaterial triangle: {triangleTwo.GetArea()}");

            Console.WriteLine($"Area of Rectangular triangle: {triangleThree.GetArea()}");
            Console.WriteLine();

            Console.WriteLine($"Perimeter of circleOne is: {circleOne.GetPerimeter()}");
            Console.WriteLine($"Area of circleOne is: {circleOne.GetArea()}");
            Console.WriteLine();

            Console.WriteLine($"Area of rectangleOne is: {rectangleOne.GetArea()}");

            var listOfFigures = new List<Figure>();

            listOfFigures.Add(new Triangle(pointOne, pointTwo, pointThree));
            listOfFigures.Add(new Triangle(pointOne, pointTwo, pointThree));
            listOfFigures.Add(new Triangle(pointOne, pointTwo, pointThree));

            listOfFigures.Add(new Circle(pointOne, pointTwo));
            listOfFigures.Add(new Circle(pointOne, pointTwo));
            listOfFigures.Add(new Circle(pointOne, pointTwo));

            listOfFigures.Add(new Rectangle(pointOne, pointTwo, pointThree));
            listOfFigures.Add(new Rectangle(pointOne, pointTwo, pointThree));

            double totalArea = 0;
            double totalAreaTriangles = 0;
            foreach (var figure in listOfFigures)
            {
                if (figure.GetType() == typeof(Triangle))
                {
                    totalAreaTriangles += figure.GetArea();
                }
                totalArea += figure.GetArea();
            }

            Console.WriteLine($"\nTotal area of figures: {totalArea}");
            Console.WriteLine($"Total area of figures: {totalAreaTriangles}");

            Console.ReadLine();
        }
    }
}
