using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace MagicPCApp
{
    class MagicPC
    {

        public void GetUserAnswer()
        {
            Random random = new Random();

            switch(random.Next(8))
            {
                case 0:
                    WriteLine();
                    WriteLine("It appears not likely to be likely");
                    break;
                case 1:
                    WriteLine();
                    WriteLine("Icculus has decreed that it is so!");
                    break;
                case 2:
                    WriteLine();
                    WriteLine("Better luck next time");
                    break;
                case 3:
                    WriteLine();
                    WriteLine("All signs point to YES!");
                    break;
                case 4:
                    WriteLine();
                    WriteLine("An emphatic NO");
                    break;
                case 5:
                    WriteLine();
                    WriteLine("Buy a lottery ticket! It's your lucky day!");
                    break;
                case 6:
                    WriteLine();
                    WriteLine("No is the answer and the answer is No");
                    break;
                case 7:
                    WriteLine();
                    WriteLine("The odds are ever in your favor on this one");
                    break;

            }
        }
    }
}
