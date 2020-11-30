using System.Collections.Generic;

namespace TicTacToeProjekt
{
    public class Board
    {
        readonly List<Square> TheBoard;

        public Board() // Konstruktor. Varje bräde innehåller en lista med 9 Squares.
        {
            TheBoard = new List<Square>(9);
            Square NW = new Square("NW");
            TheBoard.Add(NW);
            Square NC = new Square("NC");
            TheBoard.Add(NC);
            Square NE = new Square("NE");
            TheBoard.Add(NE);
            Square CW = new Square("CW");
            TheBoard.Add(CW);
            Square CC = new Square("CC");
            TheBoard.Add(CC);
            Square CE = new Square("CE");
            TheBoard.Add(CE);
            Square SW = new Square("SW");
            TheBoard.Add(SW);
            Square SC = new Square("SC");
            TheBoard.Add(SC);
            Square SE = new Square("SE");
            TheBoard.Add(SE);
        }

        public Square GetSquare(Board board, string input) // Returnerar den Square som ska ändras
        {                                                               
            foreach (Square square in board.TheBoard)
            {
                if (input == square.name)
                {
                    return square;
                }
            }
            return null; // Utgår från att input är rätt format
        }

        public int WinCondition(List<Square> list) // Returnerar statusen för spelaren med 3 i rad.
        {
            {
                for (int i = 0; i <= 6; i += 3)
                {
                    if (list[i].status != 0 && list[i].status == list[i + 1].status && list[i + 1].status == list[i + 2].status && list[i + 2].status == list[i].status)
                    {
                        return list[i].status;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (list[i].status != 0 && list[i].status == list[i + 3].status && list[i + 3].status == list[i + 6].status && list[i + 6].status == list[i].status)
                    {
                        return list[i].status;
                    }
                }

                if (list[0].status != 0 && list[0].status == list[4].status && list[4].status == list[8].status && list[8].status == list[0].status ||
                    list[2].status != 0 && list[2].status == list[4].status && list[4].status == list[6].status && list[6].status == list[0].status)
                {
                    return list[4].status;
                }
                return 0;
            }
        }
    }
}