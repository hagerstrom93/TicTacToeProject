using System;

namespace TicTacToeProjekt
{
    public class Game
    {
        private int index;

        public Game()
        {
            index = -1;
        }

        public void StartGame(Player player1, Player player2, Board board, string input) // Startar spelet 
        {
            ParseInput((SplitByComma(input)), player1, player2, board);
        }

        private string[] SplitByComma(string input) // Delar spelets inputargument till en array av drag
        {
            string[] DoubleCoords = input.Split(',', StringSplitOptions.RemoveEmptyEntries);
            return DoubleCoords;
        }

        private void CheckWin(Board board, Player player) // Skriver ut vunna rutor om en spelare har 3 i rad
        {
            if (player.WonSquares.Count > 2)
            {
                if (board.WinCondition(player.WonSquares) > 0)
                {
                    foreach (Square won in player.WonSquares)
                    {
                        Console.Write(won.name + ", ");
                    }
                }
            }
        }

        private void ParseInput(string[] DoubleCoords, Player player1, Player player2, Board board) // Alternerar spelare och kör metoden MakeMove. Kollar sen om en spelare vunnit hela spelet. 
        {
            foreach (string DoubleCoord in DoubleCoords)
            {
                Player player = XorO(player1, player2); 
                MakeMove(player, board, DoubleCoord);
                CheckWin(board, player);  
            }
        }

        private Player XorO(Player player1, Player player2) // Byter tur mellan spelarna
        {
            if (index % 2 != 0)
            {
                index++;
                return player1;
            }
            else
            {
                index++;
                return player2;
            }
        }

        private string[] SplitByDot(string DoubleCoord) // Splittar koordinaten till en för square och en för position
        { 
            string[] temp = DoubleCoord.Trim().Split('.');  
            return temp;
        }

        private void MakeMove(Player player, Board board, string DoubleCoord) // Hämtar rätt square och rätt position och markerar som spelad av nuvarande spelare om positionen är ospelad. Kollar sedan om rutan är vunnen
        {                                                                      // Låter annars spelaren göra ett nytt drag
            string[] temp = SplitByDot(DoubleCoord);
            Square square = board.GetSquare(board, temp[0]); 
            Position position = square.GetPosition(square, temp[1]); 
            if (position.status == 0)
            {
                position.ChangeStatus(player, position);
                square.WinCondition(player, square);
            }
            else
            {
                index++;
            }
        }
    }
}