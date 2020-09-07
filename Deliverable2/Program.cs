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
            string headsOrTailsGuess; //hold user's string head or tail input 
            int numberOfFlips; // hold user's number input for how many times to flip coin
            int correctCount; //hold number of total guesses 
            Random coinFlip = new Random();
            string heads = "heads";
            string tails = "tails";
            int flip;


            //Welcome Message
            Console.Write("Guess which will have more: heads or tails? ");
            headsOrTailsGuess = Console.ReadLine();

            //start a loop depending on user choice of heads or tails 

                Console.Write("How many times shall we flip a coin? ");
                numberOfFlips = int.Parse(Console.ReadLine());

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
                }
            }
            correctCount = int.Parse(heads);
            Console.WriteLine("\nYour guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");
            int percentage = (correctCount / numberOfFlips) * 100;
            Console.WriteLine("That's " + percentage);
        }
    }
}
