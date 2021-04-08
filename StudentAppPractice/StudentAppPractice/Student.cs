using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppPractice
{
    class Student
    {
        private string studentNumber;
        private string studentFirstName;
        private string studentLastName;
        private string major;
        private int score1;
        private int score2;
        private int score3;
        private const double TOTALSCORES= 3;

        public Student()
        {
           
        }

        public Student(string studentNumber)
        {
            this.studentNumber = studentNumber;
        }

        public Student(string studentNumber,string studentFirstName, string studentLastName)
        {
            this.StudentNumber = studentNumber;
            this.StudentFirstName = studentFirstName;
            this.StudentLastName = studentLastName;
        }

        public Student(string studentNumber, string studentFirstName, string studentLastName,string major)
        {
            this.StudentNumber = studentNumber;
            this.StudentFirstName = studentFirstName;
            this.StudentLastName = studentLastName;
            this.Major = major;
        }

        public Student(string studentNumber, string studentFirstName, string studentLastName, int score1, int score2, int score3,string major)
        {
            this.StudentNumber = studentNumber;
            this.StudentFirstName = studentFirstName;
            this.StudentLastName = studentLastName;
            this.major = major;
            this.score1 = score1;
            this.score2 = score2;
            this.score3 = score3;
        }

        /*public string StudentNumber { get => studentNumber; set => studentNumber = value; }
        public string StudentFirstName { get => studentFirstName; set => studentFirstName = value; }
        public string StudentLastName { get => studentLastName; set => studentLastName = value; }
        public string Major { get => major; set => major = value; }
        public int Score1 { get => score1; set => score1 = value; }
        public int Score2 { get => score2; set => score2 = value; }
        public int Score3 { get => score3; set => score3 = value; }
    */
      
        public string StudentNumber
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }

        public string StudentFirstName
        {
            get { return studentFirstName; }
            set { studentFirstName = value; }
        }

        public string StudentLastName
        {
            get { return studentLastName; }
            set { studentLastName = value; }
        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }

        public int Score1
        {
            get { return score1; }
            set { score1 = value; }
        }

        public int Score2
        {
            get { return score2; }
            set { score2 = value; }
        }

        public int Score3
        {
            get { return score3; }
            set { score3 = value; }
        }

        public string FullName
        {
            get { return studentFirstName + " " + studentLastName; }
        }


        public double CalculateAverage()
        {
            return (score1 + score2 + score3) / TOTALSCORES;
        }

        public override string ToString()
        {
            return "\tName: \t\t" + FullName + "\n\tMajor: \t\t" + major + "\n\tExam Score 1:   " + score1 + "\n\tExam Score 2:   " + score2 + "\n\tExam Score 3:   " + score3 + "\n\tScore Average:  " + CalculateAverage().ToString("F2")+"\n";
        }
    }
}
