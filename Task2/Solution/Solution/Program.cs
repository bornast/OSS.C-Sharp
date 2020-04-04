using System;

namespace Solution
{
    class Program
    {
        /// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main(string[] args)
        {
            DataModel dm = new DataModel();
            Console.WriteLine("Program started");
            Console.WriteLine();
            DoMainMenu();
        }

        private static void PrintMainMenu()
        {
            Console.WriteLine("You are in main menu - choose action:");
            Console.WriteLine("1 - Insert new circle");
            Console.WriteLine("2 - Insert new square");
            Console.WriteLine("3 - Insert new triangle");
            Console.WriteLine("4 - Print total area of all inserted elements");
            Console.WriteLine("5 - Print total perimeter of all inserted elements");
            Console.WriteLine("6 - Print properties of all inserted elements");
            Console.WriteLine("Q - Exit");
            Console.Write("Action:");

        }

        private static void DoMainMenu()
        {
            PrintMainMenu();

            string s;
            while (true)
            {
                s = Console.ReadLine().Trim();

                if (s == "1")
                {
                    DoSubMenuCircle();
                }
                else if (s == "2")
                {
                    DoSubMenuSquare();
                }
                else if (s == "3")
                {
                    DoSubMenuTriangle();
                }
                else if (s == "4")
                {
                    PrintTotalArea();
                    Console.Write("Action:");

                }
                else if (s == "5")
                {
                    PrintTotalPerimeter();
                    Console.Write("Action:");
                }
                else if (s == "6")
                {
                    PrintAllData();
                    Console.Write("Action:");
                }
                else if (s.ToUpper() == "Q")
                {
                    Console.WriteLine("Exit of application");
                    break;
                }
            }
        }

        private static void DoSubMenuCircle()
        {
            DataModel.CircleAdded += ((string xyPos) => Console.WriteLine(xyPos));
            Console.WriteLine("You are in sub menu for circle - insert the value of radius:");
            Console.Write("Radius=");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.Trim() != "")
                {
                    try
                    {                        
                        double r = System.Convert.ToDouble(input);
                        Circle myCircle = new Circle(r);
                        DataModel.AddCircle(myCircle);

                        //DataModel.GetAllElementsList().Add(myCircle);
                        Console.WriteLine("New circle inserted!");
                        Console.Write("Do you want to insert one more circle? (y/n)");

                        string s;
                        while (true)
                        {
                            s = Console.ReadLine().Trim();
                            if (s == "y")
                            {
                                Console.Write("Radius=");
                                break;
                            }
                            else if (s == "n")
                            {
                                Console.WriteLine();
                                PrintMainMenu();
                                return;
                            }
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Value for radius is not correct!");
                        Console.Write("Radius=");
                    }
                }
            }
        }

        private static void DoSubMenuSquare()
        {
            Console.WriteLine("You are in sub menu for square - insert the value for the side of square:");
            Console.Write("Side of square=");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.Trim() != "")
                {
                    try
                    {
                        double a = System.Convert.ToDouble(input);
                        Square mySquare = new Square(a);
                        DataModel.GetAllElementsList().Add(mySquare);
                        Console.WriteLine("New square inserted!");
                        Console.Write("Do you want to insert one more square? (y/n)");

                        string s;
                        while (true)
                        {
                            s = Console.ReadLine().Trim();
                            if (s == "y")
                            {
                                Console.Write("Side of square=");
                                break;
                            }
                            else if (s == "n")
                            {
                                Console.WriteLine();
                                PrintMainMenu();
                                return;
                            }
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Value for the side of square is not correct!");
                        Console.Write("Side of square=");
                    }
                }


            }

        }

        private static void DoSubMenuTriangle()
        {
            Console.WriteLine("You are in sub menu for triangle - insert the value of side:");
            Console.Write("Side=");
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.Trim() != "")
                {
                    try
                    {
                        double a = System.Convert.ToDouble(input);
                        Triangle myTriangle = new Triangle(a);
                        DataModel.GetAllElementsList().Add(myTriangle);
                        Console.WriteLine("New triangle inserted!");
                        Console.Write("Do you want to insert one more triangle? (y/n)");

                        string s;
                        while (true)
                        {
                            s = Console.ReadLine().Trim();
                            if (s == "y")
                            {
                                Console.Write("Side=");
                                break;
                            }
                            else if (s == "n")
                            {
                                Console.WriteLine();
                                PrintMainMenu();
                                return;
                            }
                        }

                    }
                    catch
                    {
                        Console.WriteLine("Value for side is not correct!");
                        Console.Write("Side=");
                    }
                }


            }
        }

        private static void PrintTotalArea()
        {
            Console.WriteLine();
            Console.WriteLine("Total area of all inserted elements is: " + DataModel.GetTotalArea());
        }

        private static void PrintTotalPerimeter()
        {
            Console.WriteLine();
            Console.WriteLine("Total perimeter of all inserted elements is: " + DataModel.GetTotalPerimeter());
        }

        private static void PrintAllData()
        {
            Console.WriteLine("DATA OF ALL ELEMENTS IN LIST");

            foreach (Shape shape in DataModel.GetAllElementsList())
            {
                shape.PrintData();
            }

        }

    }
}
