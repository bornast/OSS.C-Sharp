using System;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    /// <summary>
	/// Summary description for Shape.
	/// </summary>
	public abstract class Shape
    {
        protected double xPos;
        protected double yPos;

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void PrintData();

        public double GetXPos()
        {
            return xPos;
        }

        public double GetYPos()
        {
            return yPos;
        }
    }
}
