using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ElectionProgram
{
    class ElectionUI
    {
        Election theElection = new Election();      //instantiate a new Election object

        //MainMethod gathers name and vote count by calling methods within this class
        public void MainMethod()
        {
            for(int i = 0; i < theElection.NumberOfCandidates(); i++)
            {
                PromptForString(i);
                PromptForInt(i);
            }
            WriteLine();
            WriteLine();
        }

        //PromptForString method allows user to enter candidates name and stores name in an array
        public void PromptForString(int i)
        {
            string name;

            Write("Please enter candidate {0}'s name:  ", i + 1);
            name = ReadLine();
            theElection.SetCandidateName(name, i);

        }

        //PromptforInt method allows user to enter candidates vote total and stores vote total in an array
        public void PromptForInt(int i)
        {
            string inValue;
            int voteCount;
            Write("Please enter candidate {0}'s vote count:  ", i + 1);
            inValue = ReadLine();
            if (int.TryParse(inValue, out voteCount) == false)
            {
                Write("Invalid input.  Please enter a number: ");
                inValue = ReadLine();
                voteCount = int.Parse(inValue);
            }
            WriteLine();
            theElection.SetCandidateVote(voteCount, i);
        }

        //DisplayResults method displays all calculations and voting results
        public void DisplayResults()
        {
          
            WriteLine("Name\t\tVotes\t\tPercentage");
            WriteLine("__________________________________________________");
            WriteLine();
            

            for (int i = 0; i < theElection.NumberOfCandidates(); i++)
            {
                double percentage = (double)theElection.GetCandidateVote(i) / theElection.TotalVotes();

                string results = String.Format("{0,-18}{1,-18}{2:P}", theElection.GetCandidateName(i), theElection.GetCandidateVote(i),
                    percentage);

                WriteLine(results);
            }
            WriteLine();
            WriteLine("The winner of the election is {0}", theElection.FindWinner());
        }
    }
}
