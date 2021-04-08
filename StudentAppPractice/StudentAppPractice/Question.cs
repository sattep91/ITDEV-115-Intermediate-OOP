 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAppPractice
{
    class Question
    {
        public string StudentName(string whichOne)  // Obtain from the user the students first and last name
        {
            string inValue;
            Console.Write("Enter Student's {0} Name: ", whichOne);
            inValue = Console.ReadLine();
            return inValue;
        }

        public string StudentNumber()
        {
            string inValue;
            Console.Write("Enter Student Number:       ");
            inValue = Console.ReadLine();
            return inValue;

        }

        public string Major(string name)
        {
            string inValue;
            Console.Write("Enter {0}'s Major:          ", name);
            inValue = Console.ReadLine();
            return inValue;


        }

        public int ExamScore(int whichOne)
        {
            string inValue;
            int aScore;
            Console.Write("Enter a value for Score {0}:  ", whichOne);
            inValue = Console.ReadLine();
            while (int.TryParse(inValue, out aScore) == false)
            {
                Console.Write("Please enter an integer value for Score {0}: ", whichOne);
                inValue = Console.ReadLine();
            }
            return aScore;

        }
    }
}
