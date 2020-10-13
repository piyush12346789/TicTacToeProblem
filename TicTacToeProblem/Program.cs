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
            char computerChoice = TicTacToe.getCompLetter(userChoice);
            Console.WriteLine("Your Letter :" + userChoice);
            Console.WriteLine("Computer's Letter :" + computerChoice);
            TicTacToe.showBoard(board);
            TicTacToe.MakeUserDesiredMove(board, userChoice);
            string winner = TicTacToe.flipingACoin();
        }
    }
}