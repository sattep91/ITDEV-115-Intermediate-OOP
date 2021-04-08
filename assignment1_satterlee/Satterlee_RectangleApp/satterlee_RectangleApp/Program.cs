using System;
using static System.Console;
namespace satterlee_RectangleApp

{
    class Program
    {
        static void Main(string[] args)
        {
            ProgramInfo();
            Directions();
            Dimensions.Calculate(Dimensions.InputHeight(), Dimensions.InputWidth());
            ReadKey();


        }

        public static void ProgramInfo()
        {
            WriteLine("**************************************************************");
            WriteLine();
            WriteLine("Name:           Paul Satterlee");
            WriteLine("Course:         ITDEV-115");
            WriteLine("Instructor:     J. Christie");
            WriteLine("Assignment:     Rectangle Assignment");
            WriteLine("Date:           1/30/2021");
            WriteLine();
            WriteLine("**************************************************************");
        }

        public static void Directions()
        {
            WriteLine("This program will calculate the area and the perimeter of " +
                "a rectangle.");
            WriteLine("All you need to do is enter the rectangles height and width.");
            WriteLine();
            WriteLine();
        }
    }

    class Dimensions
    {
        public static double InputHeight()
        {
            string heightInput;
            double recHeight;

            Write("Please enter the rectangles height in inches: ");
            heightInput = Console.ReadLine();
            recHeight = double.Parse(heightInput);

            return recHeight;

        }

        public static double InputWidth()
        {
            string widthInput;
            double recWidth;

            Write("Please enter the rectangles width in inches: ");
            widthInput = Console.ReadLine();
            recWidth = double.Parse(widthInput);

            return recWidth;

        }

        public static void Calculate(double inputHeight, double inputWidth)
        {
            double area;
            double perimeter;

            area = inputHeight * inputWidth;
            perimeter = (2 * (inputHeight + inputWidth));

            WriteLine();
            WriteLine("The area of the rectangle is {0:N2} inches", area);
            WriteLine("The perimeter of the rectangle is {0:N2} inches", perimeter);

        }



    }
}

