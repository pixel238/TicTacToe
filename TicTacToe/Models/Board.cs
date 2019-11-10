using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class Board
    {
        public static int[,] board= new int[,] {{-1,-1,-1},{-1,-1,-1},{-1,-1,-1}};
        //public static List<int> initialValue = new List<int>() { -1, -1, -1 };
        //public static List<List<int>> board= new List<List<int>>() { initialValue, initialValue, initialValue };
        public Board()
        {
            //initialValue = new List<int>() { -1, -1, -1 };
            //board = new List<List<int>>() { initialValue, initialValue, initialValue };
        }
    }
}
