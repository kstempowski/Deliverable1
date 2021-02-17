//Author: Kenneth Stempowski
/*To create a program that converts between the ficticious MilHip measurement
 * and the standard Imperial scale of measurement*/

using System;

namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
                string userInput;
                string number1;
                string choose;
                double amount;
                double inches = 0;
                double feet = 0;
                double memes = 0;
                double fidgetSpinners = 0;

            do
            {
                Console.WriteLine("Please input a measurement type. (feet, iches, memes, or fidget spinners)");
                userInput = Console.ReadLine(); //only feet, inches, memes, or fidget spinners will be used

                Console.WriteLine("Please enter an amount.");
                number1 = Console.ReadLine();
                amount = Convert.ToDouble(number1); //Converts the string into a numeric double value


                if (userInput == "memes") //enables an if then statement
                {
                    feet = amount / 5; //Convert memes to feet
                    feet = Math.Round(feet, 2); //rounds feet to 2 decimal places
                    Console.WriteLine(amount + " memes is equal to " + feet + " feet.");
                }
                else if (userInput == "feet")
                {
                    memes = amount * 5; //Converts feet to memes
                    memes = Math.Round(memes, 2); //rounds memes to 2 decimal places
                    Console.WriteLine(amount + " feet is equal to " + memes + " memes.");
                }
                else if (userInput == "inches")
                {
                    fidgetSpinners = amount * 3.5; //Converts inches to fidget spinners
                    fidgetSpinners = Math.Round(fidgetSpinners, 2); //rounds fidget spinners to 2 decimal places
                    Console.WriteLine(amount + " inches is equal to " + fidgetSpinners + " fidget spinners.");
                }
                else
                {
                    inches = amount / 3.5; //Converts fidget spinners to inches
                    inches = Math.Round(inches, 2); //rounds inches to 2 decimal places
                    Console.WriteLine(amount + " fidget spinners is equal to " + inches + " inches.");
                }

                Console.WriteLine("Do you want to convert another number?");
                choose = Console.ReadLine();
            }
            while (choose != "no" && choose != "n"); //if anything other than no, or n are typed the loop will restart
        }
    }
}
