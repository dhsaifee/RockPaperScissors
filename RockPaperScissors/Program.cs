using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {

            WelcomeUser();
            string userChoice = GetUserChoice();
            string computerChoice = GetComputerChoice();
            string winner = CalculateWinner(userChoice, computerChoice);
            DisplayWinner(winner);

            Console.ReadKey();

        }


        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to rock, paper, scissors");
        }


        public static string GetUserChoice()
        {
            Console.Write("Enter your choice (Rock, Paper or Scissors): ");
            string userInput = Console.ReadLine();
            string userChoice = userInput.ToLower();
            return userChoice.ToLower();
        }


        public static string GetComputerChoice()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1, 4);
            string computerChoice;

            if (number == 1)
            {
                computerChoice = "rock";
            }
            else if (number == 2)
            {
                computerChoice = "paper";
            }
            else
            {
                computerChoice = "scissors";
            }

            Console.WriteLine("Computer's choice is " + computerChoice);

            return computerChoice;
        }


        public static string CalculateWinner(string userChoice, string computerChoice)
        {
            string winner = "";

            if (userChoice == computerChoice)
            {
                winner = "tie";
            }
            else if (userChoice == "rock")
            {
                if (computerChoice == "paper")
                {
                    winner = "computer";
                }
                else
                {
                    winner = "user";
                }
            }
            else if (userChoice == "paper")
            {
                if (computerChoice == "rock")
                {
                    winner = "user";
                }
                else
                {
                    winner = "computer";
                }
            }
            else
            {
                if (computerChoice == "rock")
                {
                    winner = "computer";
                }
                else 
                {
                    winner = "user";
                }
            }

            return winner;
        }


        public static void DisplayWinner(string winner)
        {
            Console.WriteLine("The winner is " + winner);
        }

    }
}
