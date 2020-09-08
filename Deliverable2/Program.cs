using System;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare Variables
            string headsOrTailsGuess;
            int numberOfFlips;
            int correctCount = 0;
            Random coinFlip = new Random();
            string heads = "heads";
            string tails = "tails";
            int flip;


            //Welcome Message
            Console.Write("Guess which will have more: heads or tails? ");
            headsOrTailsGuess = Console.ReadLine();

            Console.Write("How many times shall we flip a coin? ");
            numberOfFlips = int.Parse(Console.ReadLine());
            Console.WriteLine(); //Blank line to emulate project example

            //Conditions based on user input
            if (headsOrTailsGuess.Contains(heads))
            {
                for (int i = 0; i < numberOfFlips; i++)
                {
                    flip = coinFlip.Next(2);
                    if (flip == 0)
                    {
                        Console.WriteLine(heads);
                        correctCount++;
                    }
                    else
                    {
                        Console.WriteLine(tails);
                    }
                }
            }
            else if (headsOrTailsGuess.Contains(tails))
            {
                for (int i = 0; i < numberOfFlips; i++)
                {
                    flip = coinFlip.Next(2);
                    if (flip == 0)
                    {
                        Console.WriteLine(heads);
                    }
                    else
                    {
                        Console.WriteLine(tails);
                        correctCount++;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            Console.WriteLine("\nYour guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");
            Console.WriteLine("That's " + Convert.ToDouble(correctCount) / Convert.ToDouble(numberOfFlips) * 100 + "%.");
            }
    }
}
