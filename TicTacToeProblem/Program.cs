using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame TicTacToe = new TicTacToeGame();
            char[] board = TicTacToe.createTicTacToeBoard();
            char userChoice = TicTacToe.chooseUserChoice();
            char computerChoice;
            if (userChoice == 'X')
            {
                computerChoice = 'O';
            }
            else
            {
                computerChoice = 'X';
            }
        }
    }
}