namespace TicTacToeApp.Models
{
    public class TicTacToe
    {
        public string[,] Board { get; set; }
        public string CurrentPlayer { get; set; }
        public string Winner { get; set; }

        public TicTacToe()
        {
            Board = new string[3, 3]; // 3x3 Tic-Tac-Toe board
            CurrentPlayer = "X"; // X starts first
            Winner = null;
        }

        public bool MakeMove(int row, int col)
        {
            if (Board[row, col] == null && Winner == null)
            {
                Board[row, col] = CurrentPlayer;
                if (CheckWinner())
                {
                    Winner = CurrentPlayer;
                }
                else
                {
                    CurrentPlayer = (CurrentPlayer == "X") ? "O" : "X";
                }
                return true;
            }
            return false;
        }

        private bool CheckWinner()
        {
            for (int i = 0; i < 3; i++)
            {
                // Check rows and columns
                if ((Board[i, 0] == Board[i, 1] && Board[i, 1] == Board[i, 2] && Board[i, 0] != null) ||
                    (Board[0, i] == Board[1, i] && Board[1, i] == Board[2, i] && Board[0, i] != null))
                {
                    return true;
                }
            }

            // Check diagonals
            if ((Board[0, 0] == Board[1, 1] && Board[1, 1] == Board[2, 2] && Board[0, 0] != null) ||
                (Board[0, 2] == Board[1, 1] && Board[1, 1] == Board[2, 0] && Board[0, 2] != null))
            {
                return true;
            }

            return false;
        }
    }

}
