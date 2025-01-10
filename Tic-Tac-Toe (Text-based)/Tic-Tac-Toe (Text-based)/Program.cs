using System;

class TicTacToeGame
{
    static char[] board = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    static int currentPlayer = 1; 
    static bool gameOver = false;

    static void Main()
    {
        Console.WriteLine("Welcome to Tic-Tac-Toe!");

        while (true)
        {
            DrawBoard();
            PlayerMove();
            gameOver = CheckWin();

            if (gameOver)
            {
                DrawBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                if (!PlayAgain()) break;
                ResetBoard();
            }
            else if (Array.TrueForAll(board, spot => spot == 'X' || spot == 'O'))
            {
                
                DrawBoard();
                Console.WriteLine("It's a draw!");
                if (!PlayAgain()) break;
                ResetBoard();
            }

            currentPlayer = (currentPlayer == 1) ? 2 : 1; 
        }
    }

    static void DrawBoard()
    {
        Console.Clear();
        Console.WriteLine("Player 1 [X] | Player 2 [O]");
        Console.WriteLine();
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
        Console.WriteLine("     |     |     ");
    }

    static void PlayerMove()
    {
        int choice = 0;
        bool validMove = false;

        while (!validMove)
        {
            Console.WriteLine($"Player {currentPlayer}, choose your spot (1-9): ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out choice) && choice >= 1 && choice <= 9)
            {
                if (board[choice] != 'X' && board[choice] != 'O')
                {
                    board[choice] = currentPlayer == 1 ? 'X' : 'O';
                    validMove = true;
                }
                else
                {
                    Console.WriteLine("Spot is already taken. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Choose a number between 1 and 9.");
            }
        }
    }

    static bool CheckWin()
    {
        if ((board[1] == board[2] && board[2] == board[3]) ||
            (board[4] == board[5] && board[5] == board[6]) ||
            (board[7] == board[8] && board[8] == board[9]) ||
            (board[1] == board[4] && board[4] == board[7]) ||
            (board[2] == board[5] && board[5] == board[8]) ||
            (board[3] == board[6] && board[6] == board[9]) ||
            (board[1] == board[5] && board[5] == board[9]) ||
            (board[3] == board[5] && board[5] == board[7]))
        {
            return true;
        }
        return false;
    }

    static bool PlayAgain()
    {
        Console.WriteLine("\nDo you want to play again? (Y/N): ");
        var response = Console.ReadKey(true).Key;
        return response == ConsoleKey.Y;
    }

    static void ResetBoard()
    {
        for (int i = 1; i < board.Length; i++)
        {
            board[i] = (char)(i + '0');
        }
        currentPlayer = 1; 
        gameOver = false;  
    }
}
