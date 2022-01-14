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
            var pointFour = new Point(3, 4);

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



            Console.ReadLine();
        }
    }
}
