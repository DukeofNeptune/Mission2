// Author: Dallin Duke
// Description: Create a Dice game where you roll two die and show
// the results in the form of asteriks that represent 1 percent of total number of rolls
using System;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiating RollFunction
            RollFunction rf = new RollFunction();

            //Creating output and collecting input for the user for the dice game
            Console.WriteLine("\nWelcome to the dice throwing simulator! \n");
            Console.Write("How many dice rolls would you like to simulate? ");
            int numberofRolls  =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each " + "\"" + "*" + "\"" + " represents 1% of the total number of rolls.");
            Console.WriteLine("Total number of rolls = " + numberofRolls + ".\n");

            //Calling dice function
            rf.DiceRollsCount(numberofRolls);
            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
