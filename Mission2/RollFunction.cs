using System;
using System.Collections.Generic;
using System.Text;

namespace Mission2
{
    class RollFunction
    {
        public void DiceRollsCount(int NumRolls)
        {
            // Creating an array to hold dice tosses
            int[] numbers = new int[13];
            int randDieTotal = 0;
            // Set Random up
            Random rnd = new Random();

            //Set Random dies up and add them to an array
            for(int i = 0; i < NumRolls; i++)
            {
                int randDie1 = rnd.Next(1, 7);
                int randDie2 = rnd.Next(1, 7);
                randDieTotal = randDie1 + randDie2;

                if(randDieTotal > 1 && randDieTotal < 13)
                {
                    numbers[randDieTotal]++;
                }
            }
            //Print Results
            for (int i = 2; i < numbers.Length; i++)
            {
                int numResults = i;
                double asteriks = Math.Round((float)numbers[i] / NumRolls * 100);
                Console.Write(numResults + ": ");
                for (int y = 0; y < asteriks; y++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
          
        }
    }
}
