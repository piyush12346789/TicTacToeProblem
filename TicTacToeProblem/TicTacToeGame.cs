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
        public char getCompLetter(char userChoice)
        {
            char computerChoice;
            if (userChoice == 'X')
            {
                computerChoice = 'O';
            }
            else
            {
                computerChoice = 'X';
            }
            return computerChoice;
        }
        public void showBoard(char[] board)
        {
            Console.WriteLine(board[1] + " | " + board[2] + " | " +board[3]);
            Console.WriteLine("------------");
            Console.WriteLine(board[4]  + " | " + board[5] + " | " + board[6]);
            Console.WriteLine("------------");
            Console.WriteLine(board[7]  + " | " + board[8] + " | " + board[9]);
            Console.WriteLine("------------");
        }
        public int getUserDesiredMove(char[] board)
        {
            int[] validMoves = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            while (true)
            {
                Console.WriteLine("What is your desired next move?");
                int index = Convert.ToInt32(Console.ReadLine());
                if(index >=1 && index <= 9 && board[index] == ' ')
                {
                    return index;
                }
                else
                {
                    Console.WriteLine("Invalid entry please check the input and try again.");
                }
            }
        }

    }
}
