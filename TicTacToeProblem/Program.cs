using System;

namespace TicTacToeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToeGame TicTacToe = new TicTacToeGame();
            char[] gameBoard = TicTacToe.createTicTacToeBoard();
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