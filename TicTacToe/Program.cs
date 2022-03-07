using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe Game ");
            TicTacToeGame obj = new TicTacToeGame();
            TicTacToeGame.CreateBoard();
            TicTacToeGame.PlayerInput();
            TicTacToeGame.ShowBoard(char[] createBoard);
            Console.ReadLine();
        }
    }
}
