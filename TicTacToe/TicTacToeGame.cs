using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class TicTacToeGame
    {
        public static char player, computer;
        public static void CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }

        public static void PlayerInput()
        {
            Console.WriteLine("Enter your input between 'O' and 'X' to Play");
            player = Convert.ToChar(Console.ReadLine().ToUpper());
            switch (player)
            {
                case 'X':
                    computer = 'O';
                    Console.WriteLine("Player Input: " + player);
                    Console.WriteLine("Computer char is : " + computer);
                    break;
                case 'O':
                    computer = 'X';
                    Console.WriteLine("Player Input: " + player);
                    Console.WriteLine("Computer char is : " + computer);
                    break;
                default:
                    Console.WriteLine("Please choose char between 'O' and 'X'");
                    break;
            }
        }
    }
}
