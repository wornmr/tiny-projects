#hallo! im yuu this is a shit of a "game" but its the first lil proyect ill upload
#theres an C# version also, go try it out!

import random

def puzzle_game():
    # list of puzzles hereee (they r js ordinary questions lol)
    puzzles = [
        ("What is 2 + 2?", ["3", "4", "5"], 2),
        ("What color is the sky on a clear day?", ["Blue", "Green", "Red"], 1),
        ("What is the capital of France?", ["Berlin", "Madrid", "Paris"], 3),
        ("How many legs does a spider have?", ["6", "8", "10"], 2),
        ("Which planet is known as the Red Planet?", ["Earth", "Mars", "Venus"], 2),
        ("What is the largest mammal?", ["Elephant", "Blue Whale", "Giraffe"], 2),
        ("What gas do plants absorb?", ["Oxygen", "Carbon Dioxide", "Nitrogen"], 2),
        ("How many continents are there?", ["5", "6", "7"], 3),
        ("Who wrote 'Hamlet'?", ["Shakespeare", "Homer", "Tolstoy"], 1),
        ("What is the boiling point of water (in Celsius)?", ["90", "100", "120"], 2),
    ]

    random.shuffle(puzzles)

    player_name = input("Enter your name: ")
    print(f"Welcome {player_name}! Let's start the game.")
    
    score = 0
    wrong_count = 0

    for puzzle, options, correct in puzzles:
        print(f"\nPuzzle: {puzzle}")
        print("Options:")
        for i, option in enumerate(options, start=1):
            print(f"{i}. {option}")

        try:
            choice = int(input("Your choice (1, 2, or 3): "))
        except ValueError:
            print("Invalid input! Skipping this round.")
            continue

        if choice == correct:
            score += 10
            if score == 100 and len(puzzles) == 10:
                print("u won... i bet u saw the code before")
                return
            elif score < 30:
                print("ok cool")
            elif score < 60:
                print("okay u get it")
            elif score < 90:
                print("damn u good")
            elif score < 100:
                print("u almost got it... keep going")
        else:
            score -= 10
            wrong_count += 1
            score = max(0, score)  
            if wrong_count >= 9:
                print("... get a brain")
                break
            elif wrong_count < 3:
                print("WRONG!!, try harder")
            elif wrong_count < 6:
                print("DAMN, u kinda suck")
            elif wrong_count < 9:
                print("LEAVE already")
    
    print(f"\nGame Over! Final Score: {score}")
    if wrong_count >= 9:
        print("... get a brain") #lol i maked this code and now my own bot its telling me to get a brain
    elif score < 100:
        print("you just ran out of puzzles u idiot, dont come again!")

# try it out :)
puzzle_game()