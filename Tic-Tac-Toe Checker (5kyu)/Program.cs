namespace Tic_Tac_Toe_Checker__5kyu_
{
    using System;
    using System.Linq;

    public class Program
    {
        private static void Main(string[] args)
        {

        }

        public static int IsSolved(int[,] board)
        {
            return FindWinner(board);
        }

        public static bool isFinished(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int k = 0; k < board.GetLength(1); k++)
                {
                    if (board[i, k] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static int FindWinner(int[,] board)
        {
            if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2] && board[0, 0] != 0)
            {
                if (board[0, 0] == 1)
                {
                    return 1;
                }

                return 2;
            }
            else if (board[0, 0] == board[1, 0] && board[0, 0] == board[2, 0] && board[0, 0] != 0)
            {
                if (board[0, 0] == 1)
                {
                    return 1;
                }

                return 2;
            }
            else if (board[0, 1] == board[1, 1] && board[0, 1] == board[2, 1] && board[0, 1] != 0)
            {
                if (board[0, 1] == 1)
                {
                    return 1;
                }

                return 2;
            }
            else if (board[0, 0] == board[0, 1] && board[0, 0] == board[0, 2] && board[0, 0] != 0)
            {
                if (board[0, 0] == 1)
                {
                    return 1;
                }

                return 2;
            }
            else if (board[0, 2] == board[1, 2] && board[0, 2] == board[2, 2] && board[0, 2] != 0)
            {
                if (board[0, 2] == 1)
                {
                    return 1;
                }

                return 2;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 0] == board[2, 2] && board[2, 0] != 0)
            {
                if (board[2, 0] == 1)
                {
                    return 1;
                }

                return 2;
            }
            else if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2] && board[0, 0] != 0)
            {
                if (board[0, 0] == 1)
                {
                    return 1;
                }

                return 2;
            }
            else
            {
                if (!isFinished(board))
                {
                    return -1;
                }

                return 0;
            }
        }
    }
}
