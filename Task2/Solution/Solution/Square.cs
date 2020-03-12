using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    /// <summary>
	/// Summary description for Square.
	/// </summary>
	public class Square : Shape
    {
        private readonly double oneSide;

        public Square(double p)
        {
            oneSide = p;
            xPos = DataModel.GetNewXPos();
            yPos = DataModel.GetNewYPos();
        }

        public override double GetArea()
        {
            return oneSide * oneSide;
        }

        public override double GetPerimeter()
        {
            return 4 * oneSide;
        }

        public override void PrintData()
        {
            Console.WriteLine();
            Console.WriteLine("My type: " + this.GetType());
            Console.WriteLine("Side of square = " + oneSide);
            Console.WriteLine("X position = " + xPos);
            Console.WriteLine("Y position = " + yPos);
        }
    }
}
