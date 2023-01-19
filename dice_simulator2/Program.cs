using System;

namespace dice_simulator2
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize arrays
            int[] numArray = new int[11];
            string[] starArray = new string[11];

            // get number of rolls from user
            Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
            int numRolls = int.Parse(Console.ReadLine());


            // roll both dice and input that number, minus two, into our array of numbers
            for (int roll = 0; roll < numRolls; roll++)
            {
                Random rnd = new Random();
                int die1 = rnd.Next(1, 7);
                int die2 = rnd.Next(1, 7);
                int randNum = die1 + die2;
                numArray[randNum - 2]++; // minus two since two die range from 2-12
                }

            // go through results, calculate percentage, create string of '*'
            for (int i = 0; i < numArray.Length; i++)
            {
                string tempStr = "";
                double numStars;
                numStars = Math.Round((Convert.ToDouble(numArray[i]) / Convert.ToDouble(numRolls)) * 100);
                for (int u = 0; u < Convert.ToInt32(numStars); u++) {
                    tempStr += "*";
                }
                // store string with correct number of '*' into new array 
                starArray[i] += tempStr;

            }

            // create end results for user
            string endStr = "DICE ROLLING SIMULATION RESULTS\n";
            endStr += "Each ' * ' represents 1% of the total number of rolls.\n";
            endStr += "Total number of rolls = " + numRolls + ".\n";
            // loop to display num of times each number was rolled 
            for (int e = 0; e < 11; e++)
            {
                endStr += Convert.ToString((e + 2)) + ": " + starArray[e] + "\n";
            }
            // write to user
            Console.WriteLine(endStr);
        }
    }
}
