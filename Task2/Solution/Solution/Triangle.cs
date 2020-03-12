using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    class Triangle : Shape
    {
        private readonly double side;

        public Triangle(double a)
        {
            side = a;
            xPos = DataModel.GetNewXPos();
            yPos = DataModel.GetNewYPos();
        }

        public override double GetArea()
        {
            return ((Math.Sqrt(3) / 4) * (side * side));
        }

        public override double GetPerimeter()
        {
            return 3 * side;
        }

        public override void PrintData()
        {
            Console.WriteLine();
            Console.WriteLine("My type: " + this.GetType());
            Console.WriteLine("Side = " + side);
            Console.WriteLine("X position = " + xPos);
            Console.WriteLine("Y position = " + yPos);
        }
    }
}
