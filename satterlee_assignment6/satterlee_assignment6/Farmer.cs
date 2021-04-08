using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using static System.Console;

namespace satterlee_assignment6
{
    enum Direction { NORTH, SOUTH };

    class Farmer
    {
        private List<string> northBank = new List<string>();        //ArrayList to store values on the north bank
        private List<string> southBank = new List<string>();        //ArrayList to store values on the south bank
        private Direction farmer;                                   //Direction enum to hold the location of the farmer

        //North Bank property
        public List<string> NorthBank
        {
            get { return northBank; }
            set { northBank = value; }
        }

        //South Bank property
        public List<string> SouthBank
        {
            get { return southBank; }
            set { northBank = value; }
        }

        //TheFarmer direction property
        public Direction TheFarmer
        {
            get { return farmer; }
            set { farmer = value; }
        }

        //Farmer Constructor begins with all values, including farmer, on north bank of river
        public Farmer()
        {
            northBank.Add("FOX");
            northBank.Add("CHICKEN");
            northBank.Add("GRAIN");

            farmer = Direction.NORTH;
        }
        
        //method using assigned integer values to determine whether an animal will eat the food or another animal
        //returns an integer value
        public int AnimalAteFood()
        {
            int tempInt = 0;

            if (farmer == Direction.NORTH && southBank.Count > 1)
            {
                for (int i = 0; i < southBank.Count; i++)
                {
                    if (southBank[i] == "FOX") 
                    { 
                        tempInt += 1; 
                    }
                    if (southBank[i] == "CHICKEN") 
                    {
                        tempInt += 3; 
                    }
                    if (southBank[i] == "GRAIN") 
                    {
                        tempInt += 5; 
                    }
                }
            }
            else if (farmer == Direction.SOUTH && northBank.Count > 1)
            {
                for (int i = 0; i < northBank.Count; i++)
                {
                    if (northBank[i] == "FOX") 
                    { 
                        tempInt += 1; 
                    }
                    if (northBank[i] == "CHICKEN") 
                    { 
                        tempInt += 3; 
                    }
                    if (northBank[i] == "GRAIN") 
                    { 
                        tempInt += 5; 
                    }
                }
            }

            if (DetermineWin()) 
            { 
                return 1; 
            }
            else if (tempInt == 4 || tempInt == 8) 
            { 
                return tempInt; 
            }
            else if (farmer == Direction.SOUTH && northBank.Count == 3 && tempInt == 9) 
            { 
                return 4; 
            }
            else 
            { 
                return 0; 
            }

        }

        //Method using integer values assigned to each item to determine if the game has been won
        //returns a boolean value
        public bool DetermineWin()
        {
            int tempInt = 0;

            for (int i = 0; i < southBank.Count; i++)
            {
                if (southBank[i] == "FOX") 
                { 
                    tempInt += 1; 
                }
                if (southBank[i] == "CHICKEN") 
                { 
                    tempInt += 3; 
                }
                if (southBank[i] == "GRAIN") 
                { 
                    tempInt += 5; 
                }
            }

            if (tempInt == 9) 
            { 
                return true; 
            }
            else 
            { 
                return false; 
            }
        }

        //Method that accepts a string argument and determines what move to make
        //returns an integer value
        public int Move(string value)
        {
            int tempInt; 

            if (value == "")
            {
                if(farmer == Direction.NORTH)
                {
                    farmer = Direction.SOUTH;
                }
                else if(farmer == Direction.SOUTH)
                {
                    farmer = Direction.NORTH;
                }
            }
            else if (farmer == Direction.NORTH)
            {
                northBank.Remove(value.ToUpper());
                southBank.Add(value.ToUpper());

                farmer = Direction.SOUTH;
            }
            else if (farmer == Direction.SOUTH)
            {
                southBank.Remove(value.ToUpper());
                northBank.Add(value.ToUpper());

                farmer = Direction.NORTH;
            }

            tempInt = AnimalAteFood();
            if (tempInt > 0)
            {
                northBank.Clear();
                southBank.Clear();

                farmer = Direction.NORTH;

                northBank.Add("FOX");
                northBank.Add("CHICKEN");
                northBank.Add("GRAIN");
            }
            return tempInt;


        }
    }
}
