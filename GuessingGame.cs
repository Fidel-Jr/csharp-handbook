using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* This will run the guessing game until the user decides to stop it.
               After each game, it will ask if the user wants to play again.
            */
            
            Console.WriteLine("Welcome to the Number Guessing Game!\n");

            do
            {
                PlayGuessingGame();
            }
            while (AskToPlayAgain());

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }

        // This method implements a number guessing game where the user has to guess a randomly generated number between 0 and 4.
        static void PlayGuessingGame()
        {
            Random randomNumberGenerator = new Random();
            int correctAnswer = randomNumberGenerator.Next(5);
            bool guessedCorrectly = false;
            int numberInput = ReadInt("Guess a number between 0 and 4");
            int attempts = 1;

            while (numberInput != correctAnswer)
            {
                attempts++;
                numberInput = numberInput < correctAnswer ? ReadInt("Try something higher") : ReadInt("Try something lower");
                
            }
            Console.WriteLine($"You guessed right, it took you {attempts} attempts.");
            Console.WriteLine();
        }

        /* This method prompts the user to play the guessing game again and returns true if the user wants to play again,
           otherwise it returns false.
        */
        static bool AskToPlayAgain()
        {
            Console.Write("Do you want to play again? (y/n): ");
            string input = Console.ReadLine();
            Console.WriteLine();
            return input.Trim().ToLower().Contains("y");
        }

        /* This method reads an integer from the console and validates the input.
           It keeps prompting the user until a valid integer is entered.
        */
        static int ReadInt(string message)
        {
            Console.Write($"{message}: ");
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }
            return result;
        }

    }
}
