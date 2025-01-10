using System;

class HauntedHouse
{
    static void Main()
    {
        bool gameRunning = true;

        Console.WriteLine("Welcome to the Haunted House. Can you escape alive?");
        Console.WriteLine("---------------------------------------------------");

        while (gameRunning)
        {
            Console.WriteLine("\nYou're standing at the entrance of the house. Do you want to go inside?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No, leave");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nYou enter the dark house. The door slams shut behind you.");
                Console.WriteLine("You find yourself in a dark hallway with two doors.");
                Console.WriteLine("Do you:");
                Console.WriteLine("1. Go through the left door.");
                Console.WriteLine("2. Go through the right door.");
                string doorChoice = Console.ReadLine();

                if (doorChoice == "1")
                {
                    Console.WriteLine("\nYou open the left door and a chill runs down your spine. The room is cold and filled with cobwebs.");
                    Console.WriteLine("A shadowy figure stands in the corner.");
                    Console.WriteLine("Do you:");
                    Console.WriteLine("1. Approach the figure.");
                    Console.WriteLine("2. Turn around and run.");

                    string figureChoice = Console.ReadLine();

                    if (figureChoice == "1")
                    {
                        Console.WriteLine("\nThe figure turns around. It's a ghost! You feel cold and lose consciousness. You were never seen again.");
                        gameRunning = false;
                    }
                    else if (figureChoice == "2")
                    {
                        Console.WriteLine("\nYou quickly turn around and flee back into the hallway, but the door slams shut behind you.");
                        Console.WriteLine("You're stuck in the hallway. The house is trapping you!");
                    }
                }
                else if (doorChoice == "2")
                {
                    Console.WriteLine("\nYou go through the right door, which creaks open. Inside, you find a blood-stained room.");
                    Console.WriteLine("In the center of the room is an old bed with something moving under the blanket.");
                    Console.WriteLine("Do you:");
                    Console.WriteLine("1. Investigate the bed.");
                    Console.WriteLine("2. Back out and return to the hallway.");

                    string bedChoice = Console.ReadLine();

                    if (bedChoice == "1")
                    {
                        Console.WriteLine("\nYou approach the bed slowly and pull the blanket away. It's a corpse! The spirit rises up and grabs you.");
                        Console.WriteLine("You scream as you're dragged into the bed. The house has claimed another victim.");
                        gameRunning = false;
                    }
                    else if (bedChoice == "2")
                    {
                        Console.WriteLine("\nYou back out of the room. The door slams shut. You're now alone in the hallway, surrounded by darkness.");
                    }
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("You decide to leave, but the ground beneath you shakes. Something in the house doesn't want you to leave...");
                gameRunning = false;
            }
        }

        Console.WriteLine("Game Over. Thanks for playing the Haunted House!");
    }
}
