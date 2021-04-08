using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MagicPCApp
{
    class MagicPCUI
    {
        private String userMagic;       //to hold question that user asks

        public void UserInstructions()
        {
            WriteLine("*********************************************************************************");
            WriteLine();
            WriteLine("My friend, my friend... Have you been enlightened by the writings of the ");
            WriteLine("Helping Friendly Book?  In it, you will find answers to questions written by ");
            WriteLine("those who do things that smart people don't do.  Ask any YES or NO question of the ");
            WriteLine("author, the great and knowledgable Icculus.  You are old enough to Read Icculus!");
            WriteLine();
            WriteLine("*********************************************************************************");
            WriteLine();
            WriteLine();

        }
           
        //Get user question method to prompt the  user to enter a yes or no question
        public void GetUserQuestion()
        {
            WriteLine("Enter your question if you dare...");
            WriteLine("*************************************");
            WriteLine();
            WriteLine("Please ask any YES or NO question now!");
            userMagic = ReadLine();

            if(userMagic == "")
            {
                WriteLine("You didn't ask anything! Please ask a YES or NO question Now!");
                userMagic = ReadLine();
            }
        }
    }
}
