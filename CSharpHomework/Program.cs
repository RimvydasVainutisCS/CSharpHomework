﻿using System;
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

            var pointOne = new Point(0, 11);
            var pointTwo = new Point(12, 2);
            var pointThree = new Point(0, 0);
            var pointFour = new Point(3, 4);

            //var triangleOne = new Triangle();

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

            Console.WriteLine($"Perimeter of triangle made of points XY1: {pointOne}, XY2: {pointTwo}, XY3: {pointThree} is {pointOne.GetDistance(pointTwo) + pointTwo.GetDistance(pointThree) + pointThree.GetDistance(pointOne)}");

            Point one = new Point(0, 11);
            Point two = new Point(12, 2);
            Point three = new Point(0, 0);

            double perimeter = 

            Console.ReadLine();
        }
    }
}
