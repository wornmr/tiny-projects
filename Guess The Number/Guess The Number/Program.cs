using System;

class GuessTheNumberGame
{
    static void Main()
    {
        while (true)
        {
            StartNewGame();
            if (!PlayAgain())  // Ask if the player wants to play again
                break;
        }
    }

    static void StartNewGame()
    {
        int numberToGuess = new Random().Next(1, 101); // Random number between 1 and 100
        int playerGuess = 0;
        int attempts = 0;
        int maxAttempts = 10; // The player can guess 10 times

        Console.Clear();
        Console.WriteLine("Welcome to the Guess the Number Game!");
        Console.WriteLine("I have chosen a number between 1 and 100.");
        Console.WriteLine($"You have {maxAttempts} attempts to guess it!");

        while (attempts < maxAttempts)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

            // Handle invalid input
            if (!int.TryParse(input, out playerGuess))
            {
                Console.WriteLine("Please enter a valid number.");
                continue;
            }

            attempts++;

            if (playerGuess > numberToGuess)
            {
                Console.WriteLine("Your guess is too high. Try again.");
            }
            else if (playerGuess < numberToGuess)
            {
                Console.WriteLine("Your guess is too low. Try again.");
            }
            else
            {
                Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts!");
                break;
            }
        }

        if (attempts == maxAttempts && playerGuess != numberToGuess)
        {
            Console.WriteLine($"Sorry! You've used all {maxAttempts} attempts. The correct number was {numberToGuess}.");
        }
    }

    static bool PlayAgain()
    {
        Console.WriteLine("\nWould you like to play again? (Y/N)");
        var key = Console.ReadKey(true).Key;
        return key == ConsoleKey.Y;
    }
}
