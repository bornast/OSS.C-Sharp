using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    /// <summary>
	/// Summary description for Circle.
	/// </summary>
	public class Circle : Shape
    {
        private readonly double radius;
        private static readonly double PI = 3.14159;

        public Circle(double r)
        {
            radius = r;
            xPos = DataModel.GetNewXPos();
            yPos = DataModel.GetNewYPos();
        }

        public override double GetArea()
        {
            return radius * radius * PI;
        }

        public override double GetPerimeter()
        {
            return 2 * radius * PI;
        }

        public override void PrintData()
        {
            Console.WriteLine();
            Console.WriteLine("My type: " + this.GetType());
            Console.WriteLine("Radius = " + radius);
            Console.WriteLine("X position = " + xPos);
            Console.WriteLine("Y position = " + yPos);
        }
    }
}
