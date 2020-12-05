using System;

namespace TicTacToe_WPF_GUI
{
    class Board
    {
        public int scoreX = 0, scoreO = 0;
        private char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public void ResetBoard()
        {
            for (int i = 0; i < 9; i++)
            {
                board[i] = (char)(i+1);
            }
        }

        public bool IsThereAWinner()
        {
            bool winner = false;

            for (int i = 0; i < 9; i += 3)
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2])
                {
                    winner = !winner;
                    for (int j = 1; j <= 9; j++)
                    {
                        MarkCell(j, 'Z');
                    }
                    return winner;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6])
                {
                    winner = !winner;
                    for (int j = 1; j <= 9; j++)
                    {
                        MarkCell(j, 'Z');
                    }
                    return winner;
                }
            }
            if ((board[0] == board[4] && board[0] == board[8]) || (board[2] == board[4] && board[2] == board[6]))
            {
                winner = !winner;
                for (int j = 1; j <= 9; j++)
                {
                    MarkCell(j, 'Z');
                }
                return winner;
            }
            return winner;
        }

        public bool IsThereATie()
        {
            bool tie = true;

            for (int i = 0; tie && i < 9; i++)
            {
                if (board[i] != 'X' && board[i] != 'O')
                {
                    tie = false;
                    return tie;
                }
            }

            return tie;
        }

        public bool MarkCell(int cell, char player)
        {
            if (board[cell - 1] != 'X' && board[cell - 1] != 'O' && board[cell - 1] != 'Z')
            {
                board[cell - 1] = player;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}