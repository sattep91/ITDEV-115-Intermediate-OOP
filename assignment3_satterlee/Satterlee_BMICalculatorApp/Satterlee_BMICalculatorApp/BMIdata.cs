using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Satterlee_BMICalculatorApp
{
    class BMIdata
    {
        private double bodyMassIndex;       //to hold users calculated body mass index
        private double userHeight;          //to hold height in inches input by user
        private double userWeight;          //to hold weight in pounds input by user

        //UserHeight Property getter and setter method
        public double UserHeight
        {
            get { return userHeight; }
            set { userHeight = value; }
        }

        //UserWeight Property getter and setter method
        public double UserWeight
        {
            get { return userWeight; }
            set { userWeight = value; }
        }

        //BodyMassIndex Property getter method
        public double BodyMassIndex
        {
            get { return bodyMassIndex; }
        }

        //BMI constructor
        public BMIdata(double height, double weight)
        {
            userHeight = height;
            userWeight = weight;
        }

        //empty default constructor
        public BMIdata()
        {

        }

        //CalculateBMI method
        public void CalculateBMI()
        {
            bodyMassIndex = ((userWeight / (userHeight * userHeight)) * 703.0);
        }

        public void ObtainWeightStatus()
        {
            if(bodyMassIndex <= 18.5 && bodyMassIndex > 0)
            {
                WriteLine("For your height of {0} inches and your weight of {1} pounds, ", userHeight, userWeight);
                WriteLine("your BMI is {0:F2} which gives you a weight status of UNDERWEIGHT", bodyMassIndex);

            }else if(bodyMassIndex > 18.5 && bodyMassIndex < 25)
            {
                WriteLine("For your height of {0} inches and your weight of {1} pounds, ", userHeight, userWeight);
                WriteLine("your BMI is {0:F2} which gives you a weight status of NORMAL", bodyMassIndex);

            }else if(bodyMassIndex >= 25 && bodyMassIndex < 30)
            {
                WriteLine("For your height of {0} inches and your weight of {1} pounds, ", userHeight, userWeight);
                WriteLine("your BMI is {0:F2} which gives you a weight status of OVERWEIGHT", bodyMassIndex);

            }else if(bodyMassIndex >= 30)
            {
                WriteLine("For your height of {0} inches and your weight of {1} pounds, ", userHeight, userWeight);
                WriteLine("your BMI is {0:F2} which gives you a weight status of OBESE", bodyMassIndex);
            }
        }




    }
}
