using System;

namespace Ernesto_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string userSelection;
            
            Console.WriteLine("Please choose a shape from the following, type your selection and press enter:");
            Console.WriteLine("Square");
            Console.WriteLine("Rectangle");
            Console.WriteLine("Parallelogram");
            Console.WriteLine("Triangle");
            Console.WriteLine("Elleipse");
            Console.WriteLine("Circle");
            Console.WriteLine("");

            userSelection = Console.ReadLine();
            string selected = userSelection.ToUpper();

            switch (selected)
            {
                case "SQUARE":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of a side and press enter.");
                            int side1;
                            side1 = Convert.ToInt32(Console.ReadLine());
                        int sqArea = side1 * side1;
                        Console.WriteLine("");
                        Console.WriteLine("The area of your square is {0}", sqArea);
                        break;
                    }
                case "RECTANGLE":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the first side and press enter.");
                        int side1;
                        side1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the second side and press enter.");
                        int side2;
                        side2 = Convert.ToInt32(Console.ReadLine());
                        int rectArea = side1 * side2;
                        Console.WriteLine("");
                        Console.WriteLine("The area of your rectangle is {0}", rectArea);
                        break;
                    }
                case "PARALLELOGRAM":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the first side and press enter.");
                        int pSide1;
                        pSide1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the second side and press enter.");
                        int pSide2;
                        pSide2 = Convert.ToInt32(Console.ReadLine());
                        int pArea = pSide1 * pSide2 * Convert.ToInt32(Math.Sin(90));
                        Console.WriteLine("");
                        Console.WriteLine("The area of your parallelogram is {0}", pArea);
                        break;
                    }
                case "TRIANGLE":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the first side press enter.");
                        double triSide1;
                        triSide1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the second side and press enter.");
                        double triSide2;
                        triSide2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the third side and press enter.");
                        double triSide3;
                        triSide3 = Convert.ToInt32(Console.ReadLine());
                        if ((triSide1 + triSide2 > triSide3) && (triSide2 + triSide3 > triSide1) && (triSide1 + triSide3 > triSide2))
                        {
                            double semiPerimeter = ((triSide1 + triSide2 + triSide3) / 2);
                            double triArea = (Math.Sqrt(semiPerimeter * (semiPerimeter - triSide1) * (semiPerimeter - triSide2) * (semiPerimeter - triSide3)));
                            Console.WriteLine("");
                            Console.WriteLine("The area of your triangle is {0}", triArea);
                        }
                        else
                        {
                            Console.WriteLine("The sides provided do not make a triangle.");
                        }        
                        break;

                    }
                case "ELLIPSE":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the Semi-Major axis (1/2 of the longest diameter) and press enter.");
                        double major;
                        major = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the length of the Semi-Minor axis (1/2 of the smallest diameter) and press enter.");
                        double minor;
                        minor = Convert.ToInt32(Console.ReadLine());
                        double ellArea = major * minor * Math.PI;
                        Console.WriteLine("");
                        Console.WriteLine("The area of your rectangle is {0}", ellArea);
                        break;
                    }
                case "CIRCLE":
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter the radius of the circle and press enter.");
                        double radius;
                        radius = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("");
                        double cirArea = radius * radius * Math.PI;
                        Console.WriteLine("");
                        Console.WriteLine("The area of your rectangle is {0}", cirArea);
                        break;
                    }
            }
            
        }
    }
}
