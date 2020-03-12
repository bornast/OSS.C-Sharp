using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Solution
{
    /// <summary>
	/// Summary description for DataModell.
	/// </summary>
	public class DataModel
    {
        private static ArrayList ALL_ELEMENTS;

        public DataModel()
        {
            ALL_ELEMENTS = new ArrayList();
        }

        public static double GetNewXPos()
        {
            if (ALL_ELEMENTS.Count == 0)
            {
                return 1;
            }
            else
            {
                Shape lastShapeInList = (Shape)ALL_ELEMENTS[ALL_ELEMENTS.Count - 1];
                return lastShapeInList.GetXPos() + 1;
            }
        }

        public static double GetNewYPos()
        {
            if (ALL_ELEMENTS.Count == 0)
            {
                return 1;
            }
            else
            {
                Shape lastShapeInList = (Shape)ALL_ELEMENTS[ALL_ELEMENTS.Count - 1];
                return lastShapeInList.GetYPos() + 2;
            }
        }

        public static ArrayList GetAllElementsList()
        {
            return ALL_ELEMENTS;
        }

        public static double GetTotalArea()
        {
            double totalArea = 0;

            foreach (Shape shape in ALL_ELEMENTS)
            {
                totalArea += shape.GetArea();
            }

            return totalArea;
        }

        public static double GetTotalPerimeter()
        {
            double totalPerimeter = 0;

            foreach (Shape shape in ALL_ELEMENTS)
            {
                totalPerimeter += shape.GetPerimeter();
            }

            return totalPerimeter;
        }
    }
}
