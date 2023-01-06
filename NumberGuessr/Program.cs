using System;

//Author: Kevin Darby
//Copied from Brad Traversy Youtube: https://www.youtube.com/watch?v=GcFJjpMFJvI&t=2363s
namespace NumberGuessr
{
  
    internal class Program
    {
        
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();            

            while (true)
            {
                //init game vars
                int guess = 0;
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                //Ask for user input guess
                Console.WriteLine("Guess a number between 1 and 10");
                //Loop until correct number is entered
                while (guess != correctNumber)
                {
                    string guessInput = Console.ReadLine();
                    //Verify input is number
                    if (!int.TryParse(guessInput, out guess))
                    {
                        //print error msg
                        PrintColorMsg(ConsoleColor.Red, "Please enter a valid number between 1-10.");
                       
                        continue;
                    }

                    //cast string to int and put in guess var
                    guess = Int32.Parse(guessInput);
                    if (guess != correctNumber)
                    {
                        PrintColorMsg(ConsoleColor.Red, "Wrong number, try again.");
                    }
                }
                //if this line is reached, guess was correct
                PrintColorMsg(ConsoleColor.Green, "Correct number, you win!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");
                string ans = Console.ReadLine().ToUpper();
                if (ans == "Y")
                {
                    continue;
                }
                else if (ans == "N")
                {
                    return;
                } else {
                    return;
                }
            }
        }
        
        static void GetAppInfo()
        {
            //App variables
            string author = "Kevin Darby";
            string appName = "Number Guessr";
            string appVersion = "1.0.0";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, author);
            Console.ResetColor(); // reset color after printing header
        }
        static void GreetUser()
        {
            //Get user name
            Console.WriteLine("What is your name?");
            string inputName = Console.ReadLine();
            Console.WriteLine("Welcome " + inputName + "! Let's play a number guessing game.");
        }
        //Print color message
        static void PrintColorMsg(ConsoleColor color, string msg)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(msg);
            Console.ResetColor();
        }
    }
}
