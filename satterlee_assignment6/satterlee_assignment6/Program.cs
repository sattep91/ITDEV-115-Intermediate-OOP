using System;
using static System.Console;

namespace satterlee_assignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            Info myInfo = new Info();
            myInfo.DisplayInfo();

            FarmerUI newFarmer = new FarmerUI();
            newFarmer.PlayGame();

            ReadKey();
            
        }
    }
}
