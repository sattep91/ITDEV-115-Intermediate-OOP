using System;
using static System.Console;

namespace ElectionProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Info info = new Info();
            info.DisplayInfo();

            ElectionUI election = new ElectionUI();
            election.MainMethod();
            election.DisplayResults();
            
            ReadKey();
            
        }
    }
}
