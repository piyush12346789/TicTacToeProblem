using System;
using System.Security.Cryptography.X509Certificates;

namespace TicTacToeProblem
{
    public class TicTacToeGame
    {
        static void Main(string[] args)
        {
            char[] board = createTicTacToeBoard();
            char userChoice = chooseUserChoice();
        }
        private static char[] createTicTacToeBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        private static char chooseUserChoice()
        {
            Console.WriteLine("Choose your letter: ");
            string userChoice = Console.ReadLine();
            return char.ToUpper(userChoice[0]);
        }
    }
}
