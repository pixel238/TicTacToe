using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicTacToe.Models;

namespace TicTacToe.Services
{
    
    public class WinChecker
    {
        public bool Won(int s,int x,int y)
        {
            int n = Board.board.GetLength(0);
            //check the coloum
            for (int i = 0; i < n; i++)
            {
                if (Board.board[x,i] != s)
                    break;
                if (i == n - 1)
                    return true;
            }
            //check a row
            for (int i = 0; i < n; i++)
            {
                if (Board.board[i,y] != s)
                    break;
                if (i == n - 1)
                    return true;
            }

            //checking diagonals
            if (x == y)
            {
                for (int i = 0; i < n; i++)
                {
                    if (Board.board[i,i] != s)
                        break;
                    if (i == n - 1)
                        return true;
                }
            }
            if (x + y == n - 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (Board.board[i,(n - 1) - i] != s)
                        break;
                    if (i == n - 1)
                        return true;
                }
            }
            return false;
        }
    }
}
