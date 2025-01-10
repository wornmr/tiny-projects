using System;
using System.Collections.Generic;

class PuzzleGame
{
    static void Main()
    {
        var puzzles = new List<(string question, string[] options, int correct)>
        {
            ("What is 2 + 2?", new[] { "3", "4", "5" }, 2),
            ("What color is the sky on a clear day?", new[] { "Blue", "Green", "Red" }, 1),
            ("What is the capital of France?", new[] { "Berlin", "Madrid", "Paris" }, 3),
            ("How many legs does a spider have?", new[] { "6", "8", "10" }, 2),
            ("Which planet is known as the Red Planet?", new[] { "Earth", "Mars", "Venus" }, 2),
            ("What is the largest mammal?", new[] { "Elephant", "Blue Whale", "Giraffe" }, 2),
            ("What gas do plants absorb?", new[] { "Oxygen", "Carbon Dioxide", "Nitrogen" }, 2),
            ("How many continents are there?", new[] { "5", "6", "7" }, 3),
            ("Who wrote 'Hamlet'?", new[] { "Shakespeare", "Homer", "Tolstoy" }, 1),
            ("What is the boiling point of water (in Celsius)?", new[] { "90", "100", "120" }, 2),
        };

        var rand = new Random();
        var shuffledPuzzles = new List<(string, string[], int)>(puzzles);
        shuffledPuzzles.Sort((a, b) => rand.Next(-1, 2));

        Console.Write("Enter your name: ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Welcome {playerName}! Let's start the game. ill give u 3 options, type the option's number u think its correct. good luck noob.");

        int score = 0;
        int wrongCount = 0;

        foreach (var (question, options, correct) in shuffledPuzzles)
        {
            Console.WriteLine($"\nPuzzle: {question}");
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {options[i]}");
            }

            Console.Write("Your choice (1, 2, or 3): ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 3)
            {
                Console.WriteLine("Invalid input! Skipping this round.");
                continue;
            }

            if (choice == correct)
            {
                score += 10;
                if (score == 100 && shuffledPuzzles.Count == 10)
                {
                    Console.WriteLine("u won... i bet u saw the code before");
                    return;
                }
                else if (score < 30) Console.WriteLine("ok cool");
                else if (score < 60) Console.WriteLine("okay u get it");
                else if (score < 90) Console.WriteLine("damn u good");
                else if (score < 100) Console.WriteLine("u almost got it... keep going");
            }
            else
            {
                score -= 10;
                wrongCount++;
                score = Math.Max(0, score);
                if (wrongCount >= 9)
                {
                    Console.WriteLine("... get a brain");
                    break;
                }
                else if (wrongCount < 3) Console.WriteLine("WRONG!!, try harder");
                else if (wrongCount < 6) Console.WriteLine("DAMN, u kinda suck");
                else if (wrongCount < 9) Console.WriteLine("LEAVE already");
            }
        }

        Console.WriteLine($"\nGame Over! Final Score: {score}");
        if (wrongCount >= 9)
        {
            Console.WriteLine("... get a brain");
        }
        else if (score < 100)
        {
            Console.WriteLine("u js ran out of puzzles");
        }
    }
}
