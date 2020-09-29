using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 1. Paper
             * 2. Rock
             * 3. Scissors
             */
            Random rnd = new Random();
            string userInput;
            string userInput2;
            int rdn;
            int userScore = 0;
            int computerScore = 0;
            Console.WriteLine("What is your name?");
            userInput2 = Console.ReadLine();

            Console.WriteLine($"Hello {userInput2}!, lets play RPS");

            Console.WriteLine("Rock, paper, scissors!");

            while (userScore < 3 && computerScore < 3)
            {
                userInput = Console.ReadLine().ToLower();
                rdn = rnd.Next(1, 4);

                if (rdn == 1 && userInput == "paper")
                {
                    Console.WriteLine("Tie!, next round");
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");
                }
                else if (rdn == 1 && userInput == "scissors")
                {
                    Console.WriteLine("Round won, next round");
                    userScore = userScore + 1;
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");
                }
                else if (rdn == 1 && userInput == "rock")
                {
                    Console.WriteLine("Round lost, next round");
                    computerScore = computerScore + 1;
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");
                }
                else if (rdn == 2 && userInput == "paper")
                {
                    Console.WriteLine("Round won, next round");
                    userScore = userScore + 1;
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");
                }
                else if (rdn == 2 && userInput == "scissors")
                {
                    Console.WriteLine("Round lost, next round");
                    computerScore = computerScore + 1;
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");
                }
                else if (rdn == 2 && userInput == "rock")
                {
                    Console.WriteLine("Tie!, next round");
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");

                }
                else if (rdn == 3 && userInput == "paper")
                {
                    Console.WriteLine("Round lost, next round");
                    computerScore = computerScore + 1;
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");
                }
                else if (rdn == 3 && userInput == "scissors")
                {
                    Console.WriteLine("Tie!, next round");
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");
                }
                else if (rdn == 3 && userInput == "rock")
                {
                    Console.WriteLine("Round won, next round");
                    userScore = userScore + 1;
                    Console.WriteLine($"The computers score is {computerScore}");
                    Console.WriteLine($"Your score is {userScore}.");
                }
                else Console.WriteLine("Please enter either rock, paper or scissors!");

                if (computerScore == 3)
                {
                    Console.WriteLine("The computer won!");
                }
                if (userScore == 3)
                {
                    Console.WriteLine("The user won!");
                }
            }
        }
    }
}