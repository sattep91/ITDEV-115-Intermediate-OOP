using System;
using System.Collections.Generic;
using System.Text;

namespace satterlee_assignment5
{
    class Student
    {
        private double[] hours = new double[7];           //to hold number of hours student studies
        private String id;                                //to hold student ID number
        private String name;                              //to hold students name

        //ID property
        public String ID
        {
            get { return id; }      //get method
            set { id = value; }     //set method
        }

        //Name property
        public string Name
        {
            get { return name; }        //get method
            set { name = value; }       //set method
        }

        //Hours array property
        public double[] Hours
        {
            get { return hours; }
        }


        //calculate average method returns the average study hours per day for a week
        public double CalculateAverage()
        {
            double total = 0;       //to hold total number of hours studieed
            double average;         //to hold average number of hours

            //for loop to add all hours together
            for (int i = 0; i < 7; i++)
            {
                total += hours[i];
            }

            average = total / 7;        //calculate average

            return average;
        }

        //method that takes in hours each day of study and the corresponding day
        public void EnterHours(double studyAmount, int dayNumber)
        {
            hours[dayNumber] = studyAmount;     //assign hours to each day in array
        }


    }



    
}
