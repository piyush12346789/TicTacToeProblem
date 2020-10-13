using System;

namespace TicTacToeProblem
{
    public class TicTacToeGame
    {
        static void Main(string[] args)
        {
            char[] board = createTicTacToeBoard();
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
    }
}
