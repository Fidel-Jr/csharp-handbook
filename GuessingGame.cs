using System;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Guessing Game!\n");

            do
            {
                PlayGuessingGame();
            }
            while (AskToPlayAgain());

            Console.WriteLine("Thank you for playing!");
            Console.ReadLine();
        }

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

        static bool AskToPlayAgain()
        {
            Console.Write("Do you want to play again? (y/n): ");
            string input = Console.ReadLine();
            Console.WriteLine();
            return input.Trim().ToLower().Contains("y");
        }

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
