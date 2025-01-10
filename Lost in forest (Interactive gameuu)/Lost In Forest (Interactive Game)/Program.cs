using System;

class LostInTheForest
{
    static void Main()
    {
        bool gameRunning = true;

        Console.WriteLine("You wake up in the middle of a dark forest. You have no idea how you got here.");
        Console.WriteLine("The trees are thick, the air feels damp, and strange sounds echo around you.");
        Console.WriteLine("You can barely see your surroundings, but ahead of you, there's a path leading north, and a strange glowing clearing to the east.");
        Console.WriteLine("Can you find your way out?");
        Console.WriteLine("---------------------------------------------------");

        while (gameRunning)
        {
            Console.WriteLine("\nYou're standing in a dense forest. There's a path leading north and a strange clearing to the east.");
            Console.WriteLine("Do you:");
            Console.WriteLine("1. Take the path north.");
            Console.WriteLine("2. Explore the glowing clearing to the east.");
            Console.WriteLine("3. Stay put and try to shout for help.");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("\nYou follow the path to the north. The trees grow thicker, and the air gets colder.");
                Console.WriteLine("You see a wooden cabin up ahead, but the door is open, and something is stirring inside.");
                Console.WriteLine("Do you:");
                Console.WriteLine("1. Enter the cabin and investigate.");
                Console.WriteLine("2. Keep walking and avoid the cabin.");

                string cabinChoice = Console.ReadLine();

                if (cabinChoice == "1")
                {
                    Console.WriteLine("\nYou step into the cabin. It smells like decay, and there's dust everywhere.");
                    Console.WriteLine("A dark figure steps into the doorway behind you, locking the door.");
                    Console.WriteLine("Do you:");
                    Console.WriteLine("1. Fight the figure.");
                    Console.WriteLine("2. Try to escape through the window.");

                    string figureChoice = Console.ReadLine();

                    if (figureChoice == "1")
                    {
                        Console.WriteLine("\nThe figure steps forward, revealing a twisted mask. As you try to punch them, you realize they’re stronger than you.");
                        Console.WriteLine("They overpower you in an instant and you're trapped forever. The forest claimed you.");
                        gameRunning = false;
                    }
                    else if (figureChoice == "2")
                    {
                        Console.WriteLine("\nYou quickly run towards the window and break it open. You leap out and manage to escape.");
                        Console.WriteLine("As you land, you hear the figure’s angry growl echoing from the cabin, but you're free for now.");
                    }
                }
                else if (cabinChoice == "2")
                {
                    Console.WriteLine("\nYou decide to keep walking. After a long trek, you come to a fork in the path.");
                    Console.WriteLine("Do you:");
                    Console.WriteLine("1. Go left, down a shadowy path.");
                    Console.WriteLine("2. Go right, where the sunlight seems to shine a little brighter.");

                    string forkChoice = Console.ReadLine();

                    if (forkChoice == "1")
                    {
                        Console.WriteLine("\nYou take the shadowy path, and soon, a dense fog envelops you.");
                        Console.WriteLine("You can hear whispers around you, but no one is in sight. The forest seems alive, and you feel a cold hand on your shoulder.");
                        Console.WriteLine("Do you:");
                        Console.WriteLine("1. Ignore the whispers and continue walking.");
                        Console.WriteLine("2. Turn around and try to go back.");

                        string whisperChoice = Console.ReadLine();

                        if (whisperChoice == "1")
                        {
                            Console.WriteLine("\nThe whispers grow louder, but suddenly, the fog parts. You’re at the edge of the forest!");
                            Console.WriteLine("You’ve found a way out! You've survived.");
                            gameRunning = false;
                        }
                        else if (whisperChoice == "2")
                        {
                            Console.WriteLine("\nYou turn around and try to run back, but the fog seems endless, and you're lost deeper than ever.");
                            Console.WriteLine("The shadows close in and take you.");
                            gameRunning = false;
                        }
                    }
                    else if (forkChoice == "2")
                    {
                        Console.WriteLine("\nYou choose the brighter path, and as you walk, the trees thin out, and you find a large stone circle on the ground.");
                        Console.WriteLine("In the center of the circle lies a glowing artifact. Do you:");
                        Console.WriteLine("1. Pick up the artifact.");
                        Console.WriteLine("2. Leave the artifact and continue onward.");

                        string artifactChoice = Console.ReadLine();

                        if (artifactChoice == "1")
                        {
                            Console.WriteLine("\nYou take the artifact, and suddenly, the ground trembles. A spirit materializes before you, demanding its release.");
                            Console.WriteLine("Do you:");
                            Console.WriteLine("1. Hand the artifact back.");
                            Console.WriteLine("2. Keep the artifact and attempt to flee.");

                            string spiritChoice = Console.ReadLine();

                            if (spiritChoice == "1")
                            {
                                Console.WriteLine("\nYou hand the artifact back to the spirit, and it calms down. As a reward, it opens a portal and sends you out of the forest!");
                                Console.WriteLine("You escape the forest alive.");
                                gameRunning = false;
                            }
                            else if (spiritChoice == "2")
                            {
                                Console.WriteLine("\nThe spirit’s wrath is quick. You try to run but are overwhelmed by dark energy.");
                                Console.WriteLine("The forest wins. You're gone.");
                                gameRunning = false;
                            }
                        }
                        else if (artifactChoice == "2")
                        {
                            Console.WriteLine("\nYou leave the artifact behind and continue walking. After what feels like hours, you find the forest’s edge.");
                            Console.WriteLine("You made it out! You're free.");
                            gameRunning = false;
                        }
                    }
                }
            }
            else if (choice == "2")
            {
                Console.WriteLine("\nYou walk toward the glowing clearing. As you move closer, the light seems to grow stronger.");
                Console.WriteLine("In the clearing, you see a glowing tree with fruit hanging low. It's beautiful and inviting.");
                Console.WriteLine("Do you:");
                Console.WriteLine("1. Pick the fruit from the tree.");
                Console.WriteLine("2. Sit beneath the tree and rest for a while.");

                string treeChoice = Console.ReadLine();

                if (treeChoice == "1")
                {
                    Console.WriteLine("\nAs soon as you eat the fruit, you feel drowsy and your surroundings begin to distort.");
                    Console.WriteLine("You’ve fallen into a trance, trapped by the mystical forces of the forest.");
                    Console.WriteLine("You never wake up.");
                    gameRunning = false;
                }
                else if (treeChoice == "2")
                {
                    Console.WriteLine("\nYou sit under the tree and fall asleep. When you wake up, the forest is different.");
                    Console.WriteLine("The path is now clear and you find your way out. You have escaped.");
                    gameRunning = false;
                }
            }
            else if (choice == "3")
            {
                Console.WriteLine("\nYou shout for help, but no one answers. The forest feels eerily quiet.");
                Console.WriteLine("Time passes, and no one comes. You have no choice but to keep moving.");
            }
        }

        Console.WriteLine("Game Over. Thanks for playing!");
    }
}