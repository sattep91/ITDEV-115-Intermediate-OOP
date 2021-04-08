using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.Collections;

namespace satterlee_assignment6
{
    class FarmerUI
    {
        //Instantiate a farmer object to use in this class
        Farmer theFarmer = new Farmer();


        //Welcome message displayed that expains the rules of the game
        public void DisplayWelcome()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine();
            WriteLine("This is the Farmer Game.  The object of the game is to get the Chicken, Fox, and Grain" +
                "\n to the other side of the river.  But there's a catch!  If the farmer leaves the chicken and " +
                "\nthe grain alone on either side of the river, the chicken will eat the grain.  This is game over! " +
                "\nIf the farmer leaves the fox and the chicken alone on either side of the river, the fox will eat " +
                "\nthe chicken and that will also mean Game Over!  To win, you must get the fox, chicken, grain, and " +
                "\nfarmer across the river.  Good Luck!");
            ForegroundColor = ConsoleColor.White;
            WriteLine();
            WriteLine();
            WriteLine("Press any key when you are ready to begin");
            ReadKey();
            Clear();
        }

        //Displays game state
        public void DisplayGameState()
        {
            DisplayNorthBank();
            DisplayRiver();
            DisplaySouthBank();
            WriteLine("The farmer is on the {0} side of the river", theFarmer.TheFarmer);
        }

        //Displays the north bank and any contents of the north bank array
        public void DisplayNorthBank()
        {
            BackgroundColor = ConsoleColor.Green;

            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("*********************North Bank****************************************");
            ResetColor();
            for (int i = 0; i < theFarmer.NorthBank.Count; i++)
            {
                Write(theFarmer.NorthBank[i] + "  ");
                
            }


        }

        //Displays the southbank and any contents of the south bank array
        public void DisplaySouthBank()
        {

            for (int i = 0; i < theFarmer.SouthBank.Count; i++)
            {
                Write(theFarmer.SouthBank[i] + "  ");
            }

            BackgroundColor = ConsoleColor.Green;
            WriteLine();
            WriteLine("********************South Bank*****************************************");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
            ResetColor();
        }

        //Displays the river
        public void DisplayRiver()
        {
            BackgroundColor = ConsoleColor.Blue;

            WriteLine();
            WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            WriteLine();

            ResetColor();
        }

        //Play method takes in an int and returns a boolean value
        public bool Play(int intro)
        {
            if (intro < 1) 
            { 
                DisplayWelcome(); 
            }
            DisplayGameState();
            return PromptForMove();
        }

        //Play Game method 
        public void PlayGame()
        {
            bool RunGame = true;
            int count = 0;

            while (RunGame)
            {
                RunGame = Play(count);
                count++;
            }
        }

        //Method to determine if game should continue
        //0= play continues 1= win 4= Fox ate Chicken 8= Chicken ate Grain
        //returns a boolean value
        public bool PromptForMove()
        {
            string inString = "";
            string choice = "";
            bool choiceError = true;
            
            int outcome = 0;

            Write("\nChoose next item for the farmer.  If you choose nothing, just hit the enter key ");
            choice = Console.ReadLine();
            if (choice == "")
            {
                outcome = theFarmer.Move(choice);
                choiceError = false;
            }
            else if (theFarmer.TheFarmer == Direction.NORTH)
            {
                for (int i = 0; i < theFarmer.NorthBank.Count; i++)
                {
                    if (choice.ToUpper() == theFarmer.NorthBank[i])
                    {
                        outcome = theFarmer.Move(choice.ToUpper());
                        choiceError = false;
                        choice = "";
                    }
                }
            }
            else if (theFarmer.TheFarmer == Direction.SOUTH)
            {
                for (int i = 0; i < theFarmer.SouthBank.Count; i++)
                {
                    if (choice.ToUpper() == theFarmer.SouthBank[i])
                    {
                        outcome = theFarmer.Move(choice.ToUpper());
                        choiceError = false;
                        choice = "";
                    }
                }
            }

            Console.Clear();
            if (choiceError)
            {
                Console.WriteLine("\nThat item is not on this side of the river");
                Console.WriteLine("Please try again");
                return true;
            }
            else if (outcome == 1)
            {
                Console.WriteLine("You have successfully completed the game!!");
                Console.WriteLine("CONGRATULATIONS");
                Console.Write("\n\nWould you like to play again? ");
                inString = Console.ReadLine();

                if (inString != "" && inString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else if (outcome == 4)
            {
                Console.WriteLine("Oh No! The Fox Ate the Chicken!!");
                Console.WriteLine("YOU LOSE");
                Console.Write("\n\nWould you like to play again? ");
                inString = Console.ReadLine();

                if (inString != "" && inString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else if (outcome == 8)
            {
                Console.WriteLine("Oh No! The Chicken Ate the Grain!!");
                Console.WriteLine("YOU LOSE");
                Console.Write("\n\nWould you like to play again? ");
                inString = Console.ReadLine();

                if (inString != "" && inString.ToUpper()[0] == 'Y')
                {
                    Console.Clear();
                    return true;
                }
                else { return false; }
            }
            else { return true; }
        }
    }
}
