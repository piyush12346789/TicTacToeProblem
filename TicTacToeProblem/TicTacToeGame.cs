using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProblem
{
    public class TicTacToeGame
    {
        public char[] createTicTacToeBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
            return board;
        }
        public char chooseUserChoice()
        {
            while (true)
            {
                Console.WriteLine("Choose your letter: ");
                char userChoice = (Console.ReadLine()).ToUpper()[0];
                if (userChoice == 'X' || userChoice == 'O')
                {
                    return userChoice;
                }
                else
                {
                    Console.WriteLine("You can choose only X or O");
                }
            }
        }
    }
}
