using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ElectionProgram
{
    class Election
    {
        const int NUMCANDIDATES = 5;                                   //constant holding total number of candidates
        private string[] candidateNames = new string[NUMCANDIDATES];   //String array to hold candidate names
        private int[] votes = new int[NUMCANDIDATES];                  //int array to hold candidate votes
        

        //NumberofCandidates method returns the number of candidates in the array
        public  int NumberOfCandidates()
        {
            int numCandidates = candidateNames.Length;

            return numCandidates;
        }

        //set method for candidates name
        public void SetCandidateName(string name, int i)
        {
            candidateNames[i] = name;
        }

        //set method for candidates vote count
        public void SetCandidateVote(int voteAmount, int i)
        {
            votes[i] = voteAmount;
        }

        //get method to get candidates name
        public string GetCandidateName(int i)
        {
            return candidateNames[i];
        }

        //get method to get candidates vote
        public int GetCandidateVote(int i)
        {
            return votes[i];
        }
        
        //FindWinner method takes in an array of vote totals and loops through to find the highest valued
        //index number.  That index number is stored in a local variable, which then corresponds to the 
        //candidateNames array to find the name of the candidate with the most votes
        public string FindWinner()
        {
            int highestVotes = votes[0];
            string candidate = "";

            for (int i = 1; i < NUMCANDIDATES; i++)
            {
                if(highestVotes < votes[i])
                {
                    highestVotes = votes[i];
                    candidate = candidateNames[i];
                }
            }

            return candidate;
            
        }

        //TotalVotes method takes the votes array and adds them all together
        public int TotalVotes()
        {
            int total = 0;

            for(int i = 0; i < votes.Length; i++)
            {
                total += votes[i];
            }

            return total;

        }

        



    }
}
