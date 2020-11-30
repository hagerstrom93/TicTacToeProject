using System.Collections.Generic;

namespace TicTacToeProjekt
{
    public class Square
    {
        public string name;
        public int status;
        public List<Position> Positions;

        public Square(string name) // Konstruktor. Varje Ruta har ett namn som representerar var i brädet den finns, status för spelad eller ospelad och en Lista med 9 positioner.
        {
            this.name = name;
            status = 0;
            Positions = new List<Position>(9);
            Position NW = new Position("NW");
            Positions.Add(NW);
            Position NC = new Position("NC");
            Positions.Add(NC);
            Position NE = new Position("NE");
            Positions.Add(NE);
            Position CW = new Position("CW");
            Positions.Add(CW);
            Position CC = new Position("CC");
            Positions.Add(CC);
            Position CE = new Position("CE");
            Positions.Add(CE);
            Position SW = new Position("SW");
            Positions.Add(SW);
            Position SC = new Position("SC");
            Positions.Add(SC);
            Position SE = new Position("SE");
            Positions.Add(SE);
        }

        public Position GetPosition(Square thesquare, string input) // Returnerar den position som ska ändras
        {
            foreach (Position position in thesquare.Positions)
            {
                if (input == position.Name)
                {    
                    return position;
                }
            }
            return null; // Utgår från att input är rätt format
        }

        private int ChangeStatus(Player player, Square thesquare) // Ändrar status på en specifik position. Värdet beror på spelare.
        {
            return thesquare.status += player.status;
        }

        public int WinCondition(Player player, Square square) // Checkar om en Ruta är vunnen och returnerar status för spelaren med 3 i rad.
        {
            {
                for (int i = 0; i < 7; i += 3)
                {
                    if (Positions[i].status != 0 && Positions[i].status == Positions[i + 1].status && Positions[i + 1].status == Positions[i + 2].status && Positions[i + 2].status == Positions[i].status)
                    {
                        square.ChangeStatus(player, square);
                        player.WonSquares.Add(square);
                        return Positions[i].status;
                    }
                }
                for (int i = 0; i < 3; i++)
                {
                    if (Positions[i].status != 0 && Positions[i].status == Positions[i + 3].status && Positions[i + 3].status == Positions[i + 6].status && Positions[i + 6].status == Positions[i].status)
                    {
                        square.ChangeStatus(player, square);
                        player.WonSquares.Add(square);
                        return Positions[i].status;
                    }
                }
                if (Positions[0].status != 0 && Positions[0].status == Positions[4].status && Positions[4].status == Positions[8].status && Positions[8].status == Positions[0].status ||
                    Positions[2].status != 0 && Positions[2].status == Positions[4].status && Positions[4].status == Positions[6].status && Positions[6].status == Positions[0].status)
                {
                    square.ChangeStatus(player, square);
                    player.WonSquares.Add(square);
                    return Positions[4].status;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}