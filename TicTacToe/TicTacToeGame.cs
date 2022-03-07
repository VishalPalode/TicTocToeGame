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

        public object Board { get; private set; }

        public static void CreateBoard()
        {
            char[] board = new char[10];
            for (int i = 1; i < board.Length; i++)
            {
                board[i] = ' ';
            }
        }

        internal static void ShowBoard(object p, object createBoard)
        {
            throw new NotImplementedException();
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
        public static void ShowBoard(char[] createBoard)
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[1], createBoard[2], createBoard[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[4], createBoard[5], createBoard[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", createBoard[7], createBoard[8], createBoard[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}
