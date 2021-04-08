using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Satterlee_BMICalculatorApp
{
    class Satterlee_BMICalcApp
    {
        static void Main(string[] args)
        {
            BMIUserInterface bmiui = new BMIUserInterface();
            

            bmiui.BMIMainModule();
            bmiui.UserDirections();
            bmiui.RequestUserData();
            bmiui.DisplayResults();

            ReadKey();



        }
    }
}
