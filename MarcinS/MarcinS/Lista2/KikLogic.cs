using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarcinS.Lista2
{
    public class KikLogic
    {
        public string CurrentPlayer = X;
        private const string X = "X";
        private const string O = "O";
        private string[,] Board = new string[3, 3];
        public void NextPlayer()
        {
            if (CurrentPlayer == X)
            {
                CurrentPlayer = O;
            }
            else
            {
                CurrentPlayer = X;
            }
        }

        public bool Win()
        {
            //columns
            for (int i = 0; i < 3; i++)
            {
                if (Board[0, i] != null)
                {
                    if (Board[0, i] == Board[1, i] && Board[0, i] == Board[2, i])
                    {
                        return true;
                    }
                }
            }
            //rows
            for (int i = 0; i < 3; i++)
            {
                if (Board[i, 0] != null)
                {
                    if (Board[i, 0] == Board[i, 1] && Board[i, 0] == Board[i, 2])
                    {
                        return true;
                    }
                }
            }
            if (Board[1, 1] != null)
            {
                if (Board[0, 0] == Board[1, 1] && Board[0, 0] == Board[2, 2]) return true;
                else if (Board[2, 0] == Board[1, 1] && Board[2, 0] == Board[0, 2]) return true;
            }
            return false;
        }

        public void UpdateBoard(int x, int y, string CurrentPlayer)
        {
            Board[x, y] = CurrentPlayer;
        }

    }
}
