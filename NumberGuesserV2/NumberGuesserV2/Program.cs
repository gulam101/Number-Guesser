using System;
using System.Security;

//Namespace
namespace NumberGuesser
{
    //Main class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Declareing veriables
            string appVersion = "1.0.2";
            string appAuthor = "Gulam";
            string dateModified = "This App was updated on 02/01/19";

            //Changes text colour
            Console.ForegroundColor = ConsoleColor.Red;

            //Changes background colour
            Console.BackgroundColor = ConsoleColor.White;

            // START HERE //
            Console.WriteLine("{0}: version {1} by {2}", dateModified, appVersion, appAuthor);

            Console.WriteLine();

            Console.WriteLine("Welcome to Number Guesser");

            //Resets back to orginal colour
            Console.ResetColor();

            //Asks the users name
            Console.Write("What is your name: ");

            //Gets user input
            string inputName = Console.ReadLine();
            //removes the white space at the start
            inputName.TrimStart();
            //Removes the white space at the end
            inputName.TrimEnd(); 

            Console.WriteLine("Hello " + inputName + ", let's play a game...");

            //correct number
            int correctNumber = 7;

            //init guess var
            int guess = 0;

            //Asks user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while (guess != correctNumber)
            {
                //Get users input
                string input = Console.ReadLine();

                //Cast to int and put in guess
                guess = Int32.Parse(input);

                //Changes text colour
                Console.ForegroundColor = ConsoleColor.Red;

                //Changes background colour
                Console.BackgroundColor = ConsoleColor.Green;

                // START HERE //
                Console.WriteLine("Wrong number, please try again");

                //Resets back to orginal colour
                Console.ResetColor();

                Console.ReadLine();
            }
            if (guess == correctNumber)
            {
             Console.WriteLine("Well done! You have the correct number");
            }
        }
    }
}

