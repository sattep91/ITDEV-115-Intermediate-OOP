using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppPractice
{
    class StudentAppPracitce
    {
        static void Main(string[] args)
        {
            Question Ask = new Question();  //Create object to do user input and output to console

            Student firstStudentObject = new Student(); //create student object

            firstStudentObject.StudentFirstName = Ask.StudentName("First");             //Ask user for student's first name
            firstStudentObject.StudentLastName = Ask.StudentName("Last ");              //Ask user for student's laast name

            firstStudentObject.StudentNumber = Ask.StudentNumber();                     //Ask user for student's student number
            firstStudentObject.Major = Ask.Major(firstStudentObject.StudentFirstName);  //Ask user for student's major
            firstStudentObject.Score1 = Ask.ExamScore(1);                               //Ask user for exam score 1
            firstStudentObject.Score2 = Ask.ExamScore(2);                               //Ask user for exam score 2
            firstStudentObject.Score3 = Ask.ExamScore(3);                               //Ask user for exam score 3

            Console.Clear();
            Console.WriteLine("First Student");                                         //Print out students information
            Console.WriteLine(firstStudentObject);

            Student secondStudentObject = new Student("2345");                          // Second student object information
            secondStudentObject.Score1 = 95;
            secondStudentObject.Score2 = 62;
            secondStudentObject.Score3 = 87;

            Console.WriteLine("\n\nSecond Student");
            Console.WriteLine("\tStudent Number: " + secondStudentObject.StudentNumber + "\n\tScore Average: \t{0:F1}", secondStudentObject.CalculateAverage());

            Student thirdStudentObject = new Student("5432", "Randolph", "Wonder");  // Third student object information
            thirdStudentObject.Major = "Math";
            thirdStudentObject.Score1 = 95;
            thirdStudentObject.Score2 = 87;
            thirdStudentObject.Score3 = 72;
            Console.WriteLine("\n\nThird Student");
            Console.WriteLine(thirdStudentObject);

            Student aStudentObject = new Student("123456", "Maria", "Smith", 97, 75, 87, "CS");  //Fourth student object information
            Console.WriteLine("\n\nFourth Student");
            Console.WriteLine(aStudentObject);

            Console.ReadLine();
        }
    }
}
