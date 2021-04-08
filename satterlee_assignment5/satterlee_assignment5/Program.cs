using System;
using static System.Console;

namespace satterlee_assignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            info info = new info();
            info.DisplayInfo();

            StudentUI currentStudent = new StudentUI();
            currentStudent.EnterStudentInfo();
            currentStudent.FillHours();
            currentStudent.DisplayData();
            currentStudent.DisplayAverage();

            ReadKey();
        }
    }
}
