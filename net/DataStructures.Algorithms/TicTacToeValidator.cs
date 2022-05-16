namespace DataStructures.Algorithms
{
    public class TicTacToeValidator
    {
        public bool ValidTicTacToe(string[] board)
        {
            // check that there are only a one winning row
            var winningX = HasWinningLine(board, 'X');
            var winningO = HasWinningLine(board, 'O');
            if(winningX && winningO)
            {
                return false;
            }

            // check the order of turns 
            var turnsDelta = 0;
            foreach (var row in board)
            {
                foreach (var cell in row)
                {
                    var val = cell switch
                    {
                        ' ' => 0,
                        'X' => 1,
                        'O' => -1
                    };
                    turnsDelta += val;
                }
            }

            if (winningX && turnsDelta == 0) return false;
            else if (winningO && turnsDelta == 1) return false ;
            else return turnsDelta == 0 || turnsDelta == 1;
        }

        public bool HasWinningLine(string[] board, char turn)
        {
            string[][] winningBoards = new string[][]
            {
                new string[] { "***", "   ", "   " },
                new string[] { "   ", "***", "   " },
                new string[] { "   ", "   ", "***" },
                new string[] { "*  ", "*  ", "*  " },
                new string[] { "   ", "   ", "   " },
                new string[] { "*  ", "*  ", "*  " },
                new string[] { " * ", " * ", " * " },
                new string[] { "  *", "  *", "  *" },
                new string[] { "*  ", " * ", "  *" },
                new string[] { "  *", " * ", "*  " }
            };

            foreach (var winningBoard in winningBoards)
            {
                var sum = 0;
                for (var i=0; i<winningBoard.Length; i++)
                {
                    for (var j = 0; j < winningBoard[i].Length; j++)
                    {
                        sum += (winningBoard[i][j] == '*' && board[i][j] == turn) ? 1 : 0;
                    }
                }

                if (sum == 3) return true;
            }

            return false;
        }
    }
}