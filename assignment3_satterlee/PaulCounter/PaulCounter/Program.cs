using System;
using System.Windows.Forms;
using static System.Console;
namespace PaulCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string result = "\tn\tSquared\n";

            while(counter < 10)
            {
                counter++;
                result += "\t" + counter + "\t" + Math.Pow(counter, 2) + "\n";
                MessageBox.Show(result, "1 - 10 and tier squares");

            }

            ReadKey();
        }
    }
}
