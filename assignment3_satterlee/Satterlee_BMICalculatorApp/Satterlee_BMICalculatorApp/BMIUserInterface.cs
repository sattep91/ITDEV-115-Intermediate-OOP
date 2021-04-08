using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Satterlee_BMICalculatorApp
{
    class BMIUserInterface
    {
        string inputValue;
        double height;      //to hold users height input
        double weight;      //to hold users weight input

        public void BMIMainModule()
        {
            WriteLine("**************************************************************");
            WriteLine();
            WriteLine("Name:            Paul Satterlee");
            WriteLine("Course:          ITDEV-115");
            WriteLine("Instructor:      Janese Christie");
            WriteLine("Assignment:      BMI Calculator, Assignment 3");
            WriteLine("Date:            2/10/21");
            WriteLine();
            WriteLine("*************************************************************");
            WriteLine("Press Any Key to Continue");
            ReadKey();

        }

        public void UserDirections()
        {
            WriteLine();
            WriteLine("This program will calculate your Body Mass Index (BMI)");
            WriteLine("using your height and weight.");
            WriteLine();
        }

        public void RequestUserData()
        {

            Write("Please enter your height in inches: ");
            inputValue = ReadLine();
            height = Double.Parse(inputValue);

            Write("Please enter your weight in pounds: ");
            inputValue = ReadLine();
            weight = Double.Parse(inputValue);

            WriteLine();

        }

        public void DisplayResults()
        {
            BMIdata data = new BMIdata(height, weight);

            data.CalculateBMI();
            data.ObtainWeightStatus();
        }


    }
}
