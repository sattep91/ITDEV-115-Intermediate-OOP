using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;


namespace satterlee_assignment7
{
    public partial class Form1 : Form
    {
      
        //Instantiate a new farmer object to use
        Farmer farmer = new Farmer();


        public Form1()
        {
            InitializeComponent();
            ClassInfoDisplay();
            GameInfoDisplay();
            GameDisplay();
        }

        //method that displays class info
        private void ClassInfoDisplay()
        {
            MessageBox.Show("Name:                 Paul Satterlee" +
                "\nCourse:                ITDEV-115" +
                "\nInstructor:            Janese Christie" +
                "\nAssignment:          Assignment 7:  Farmer Game GUI" +
                "\nDate:                    3/28/21\n");
        }
        //method that displays info about the game and how to play
        private void GameInfoDisplay()
        {
            MessageBox.Show("This is the Farmer Game!\n\n  Your mission is to get the farmer, chicken, fox," +
                " and grain safely across the river.  But there's a catch!\n\n  If you leave the chicken alone with" +
                " the grain, the chicken will eat the grain... GAME OVER!\n\n If you leave the chicken alone " +
                "with the fox, the fox will eat the chicken... GAME OVER!\n\n The farmer has the boat and can take " +
                "a maximum of one passenger but can also travel across the river alone.  GOOD LUCK!" );
            
        }

        //method that sets up the display of the game based on where each item is currently located
        private void GameDisplay()
        {
            //set all buttons to false initially
            chickenN.Visible = false;
            foxN.Visible = false;
            grainN.Visible = false;
            chickenS.Visible = false;
            foxS.Visible = false;
            grainS.Visible = false;
            farmerN.Visible = false;
            farmerS.Visible = false;

            if(farmer.TheFarmer == Direction.NORTH)
            {
                farmerN.Visible = true;
            }
            else if(farmer.TheFarmer == Direction.SOUTH)
            {
                farmerS.Visible = true;
            }

            for(int i = 0; i < farmer.NorthBank.Count; i++)
            {
                if(farmer.NorthBank[i] == "FOX")
                {
                    foxN.Visible = true;
                }
                if(farmer.NorthBank[i] == "CHICKEN")
                {
                    chickenN.Visible = true;
                }
                if(farmer.NorthBank[i] == "GRAIN")
                {
                    grainN.Visible = true;
                }
            }

            for (int i = 0; i < farmer.SouthBank.Count; i++)
            {
                if (farmer.SouthBank[i] == "FOX")
                {
                    foxS.Visible = true;
                }
                if (farmer.SouthBank[i] == "CHICKEN")
                {
                    chickenS.Visible = true;
                }
                if (farmer.SouthBank[i] == "GRAIN")
                {
                    grainS.Visible = true;
                }
            }
        }

        //method that takes in an int from the Farmer class to determine if game has been won
        //and displays a message box showing result
        private void CheckForWin(int result)
        {
            if(result == 1)
            {
                MessageBox.Show("Congrats!  You have won the game!");
            }
            else if(result == 4)
            {
                MessageBox.Show("Oh no! The fox ate the chicken!  YOU LOSE!");
            }
            else if(result == 8)
            {
                MessageBox.Show("Oh no! The chicken ate the grain!  YOU LOSE!");
            }
        }

        //method for when user chooses to move farmer from North to South
        private void farmerN_Click(object sender, EventArgs e)
        {
            CheckForWin(farmer.Move(""));
            GameDisplay();
        }

        //method for when user chooses to move fox from North to South
        private void foxN_Click(object sender, EventArgs e)
        {
            CheckForWin(farmer.Move("FOX"));
            GameDisplay();
        }

        //method when user chooses to move chicken from North to South
        private void chickenN_Click(object sender, EventArgs e)
        {
            CheckForWin(farmer.Move("CHICKEN"));
            GameDisplay();
        }

        //method when user chooses to move grain from north to south
        private void grainN_Click(object sender, EventArgs e)
        {
            CheckForWin(farmer.Move("GRAIN"));
            GameDisplay();
        }

        //method for when user chooses to move farmer from South to North
        private void farmerS_Click(object sender, EventArgs e)
        {
            CheckForWin(farmer.Move(""));
            GameDisplay();
        }

        //method for when user chooses to move fox from South to North
        private void foxS_Click(object sender, EventArgs e)
        {
            CheckForWin(farmer.Move("FOX"));
            GameDisplay();
        }

        //method when user chooses to move chicken from South to North
        private void chickenS_Click(object sender, EventArgs e)
        {
            CheckForWin(farmer.Move("CHICKEN"));
            GameDisplay();
        }

        //method when user chooses to move grain from South to North
        private void grainS_Click(object sender, EventArgs e)
        {
            CheckForWin(farmer.Move("GRAIN"));
            GameDisplay();
        }
    }

}
