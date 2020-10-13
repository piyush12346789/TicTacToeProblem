using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeProblem
{
    public class TicTacToeGame
    {
        const int HEADS = 1;
        const int TAILS = 2;
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
        public void MakeUserDesiredMove(char[] board, char userChoice)
        {
            // int[] validMoves = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("What is your desired next move?");
            while (true)
            { 
                int index = Convert.ToInt32(Console.ReadLine());
                if(index >=1 && index <= 9)
                {
                    if(IsSpaceFree(board, index))
                    {
                        board[index] = userChoice;
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry please check the input and try again.");
                }
            }
        }
        public bool IsSpaceFree(char[] board, int index)
        {
            if (board[index] == ' ')
                return true;
            else
                return false;
        }
        public void flipingACoin()
        {
            Random random = new Random();
            int toss = random.Next(1, 3);
            switch (toss)
            {
                case HEADS:
                    Console.WriteLine("User Won The Toss.");
                    break;
                case TAILS:
                    Console.WriteLine("Computer won the toss.");
                    break;
            }
        }
    }
}
