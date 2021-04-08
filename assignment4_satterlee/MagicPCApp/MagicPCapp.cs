using System;
using static System.Console;

namespace MagicPCApp
{
    class MagicPCapp
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            info.MagicPCinfo();

            MagicPCUI magic = new MagicPCUI();
            magic.UserInstructions();

            MagicPC answer = new MagicPC();

            String userContinue = "";        //to hold users answer
            do
            {
                magic.GetUserQuestion();
                answer.GetUserAnswer();

                WriteLine();
                WriteLine("Would you like to ask another YES or NO question? ");
                userContinue = ReadLine();
                WriteLine();
            } while (userContinue.Equals("Yes", StringComparison.CurrentCultureIgnoreCase));

            if (userContinue.Equals("No", StringComparison.CurrentCultureIgnoreCase)) ;
            {
                WriteLine();
                WriteLine("Thanks for playing!");
            }
            
        }
    }
}
