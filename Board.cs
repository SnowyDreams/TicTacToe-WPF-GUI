using System;

namespace TicTacToe_WPF_GUI
{
    class Board
    {
        private sbyte player = 2;
        private char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public void PrintBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[0], board[1], board[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[3], board[4], board[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}  ", board[6], board[7], board[8]);
            Console.WriteLine("     |     |     ");
        }

        public void MarkCell(sbyte cell, object sender)
        {
            switch (cell - 1)
            {
                case 0:
                    if (board[0] == 'X' || board[0] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[0] = 'X';
                            player++;
                        }
                        else
                        {
                            board[0] = 'O';
                            player++;

                        }

                    }
                    break;
                case 1:
                    if (board[1] == 'X' || board[1] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[1] = 'X';
                            player++;
                        }
                        else
                        {
                            board[1] = 'O';
                            player++;
                        }
                    }
                    break;
                case 2:
                    if (board[2] == 'X' || board[2] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[2] = 'X';
                            player++;
                        }
                        else
                        {
                            board[2] = 'O';
                            player++;
                        }
                    }
                    break;
                case 3:
                    if (board[3] == 'X' || board[3] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[3] = 'X';
                            player++;
                        }
                        else
                        {
                            board[3] = 'O';
                            player++;
                        }
                    }
                    break;
                case 4:
                    if (board[4] == 'X' || board[4] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[4] = 'X';
                            player++;
                        }
                        else
                        {
                            board[4] = 'O';
                            player++;
                        }
                    }
                    break;
                case 5:
                    if (board[5] == 'X' || board[5] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[5] = 'X';
                            player++;
                        }
                        else
                        {
                            board[5] = 'O';
                            player++;
                        }
                    }
                    break;
                case 6:
                    if (board[6] == 'X' || board[6] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[6] = 'X';
                            player++;
                        }
                        else
                        {
                            board[6] = 'O';
                            player++;
                        }
                    }
                    break;
                case 7:
                    if (board[7] == 'X' || board[7] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[7] = 'X';
                            player++;
                        }
                        else
                        {
                            board[7] = 'O';
                            player++;
                        }
                    }
                    break;
                case 8:
                    if (board[8] == 'X' || board[8] == 'O')
                    {
                        Console.WriteLine("cell already marked, please choose another cell");
                    }
                    else
                    {
                        if (player % 2 == 0)
                        {
                            board[8] = 'X';
                            player++;
                        }
                        else
                        {
                            board[8] = 'O';
                            player++;
                        }
                    }
                    break;
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
                    continue;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (board[i] == board[i + 3] && board[i] == board[i + 6])
                {
                    winner = !winner;
                    continue;
                }
            }
            if ((board[0] == board[4] && board[0] == board[8]) || (board[2] == board[4] && board[2] == board[6]))
            {
                winner = !winner;
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
                    break;
                }
            }

            return tie;
        }

        public sbyte CurrentPlayer()
        {
            return player;
        }

        public bool MarkCell(int cell, char player)
        {
            if (board[cell - 1] != 'X' && board[cell - 1] != 'O')
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