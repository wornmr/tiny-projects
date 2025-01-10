using System;

class RockPaperScissorsGame
{
    static void Main()
    {
        while (true)
        {
            PlayRound();
            if (!PlayAgain())  
                break;
        }
    }

    static void PlayRound()
    {
        Console.Clear();
        Console.WriteLine("Welcome to Rock, Paper, Scissors!");
        Console.WriteLine("Please choose: Rock, Paper, or Scissors");

        string playerChoice = GetPlayerChoice();
        string computerChoice = GetComputerChoice();

        Console.WriteLine($"You chose {playerChoice}.");
        Console.WriteLine($"The computer chose {computerChoice}.");

        string result = DetermineWinner(playerChoice, computerChoice);

        Console.WriteLine(result);
    }

    static string GetPlayerChoice()
    {
        string choice;
        while (true)
        {
            choice = Console.ReadLine().Trim().ToLower();
            if (choice == "rock" || choice == "paper" || choice == "scissors")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice! Please enter Rock, Paper, or Scissors:");
            }
        }
        return choice;
    }

    static string GetComputerChoice()
    {
        Random random = new Random();
        int index = random.Next(0, 3);  
        return index switch
        {
            0 => "rock",
            1 => "paper",
            2 => "scissors",
            _ => "rock", 
        };
    }

    static string DetermineWinner(string playerChoice, string computerChoice)
    {
        if (playerChoice == computerChoice)
        {
            return "It's a draw!";
        }
        if ((playerChoice == "rock" && computerChoice == "scissors") ||
            (playerChoice == "scissors" && computerChoice == "paper") ||
            (playerChoice == "paper" && computerChoice == "rock"))
        {
            return "Ugh, you win...";
        }
        else
        {
            return "Computer wins, HAH!";
        }
    }

    static bool PlayAgain()
    {
        Console.WriteLine("\nWould you like to play again? :3 (Y/N)");
        var key = Console.ReadKey(true).Key;
        return key == ConsoleKey.Y;
    }
}
