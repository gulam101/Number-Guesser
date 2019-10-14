using System;
using System.Security;

//Namespace
namespace NumberGuesser
{
    //Main class
    class Program //Can store veriables and functions
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //Setting up veriables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Gulam";
            //string input = "";

            //Changes text colour
            Console.ForegroundColor = ConsoleColor.Red;
            
            //Changes background colour
            Console.BackgroundColor = ConsoleColor.White;

            // START HERE //
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            //Resets back to orginal colour
            Console.ResetColor();

            //Asks the users name
            Console.Write("What is your name?");

            //Gets user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello " +inputName+ ", let's play a game...");

            //init correct number
            int correctNumber = 7;

            // init guess ver
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

                //Match guess to correct number
                if(guess != correctNumber)
                {
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
            } 
       }
    }
}
