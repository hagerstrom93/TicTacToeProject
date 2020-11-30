
namespace TicTacToeProjekt
{
    public class Position
    {
        public string Name { get; private set; }
        public int status;
        public Position(string name) // Konstruktor. Varje position har ett namn som representerar var i rutan den finns samt status för spelad eller ospelad.
        {
            Name = name;
            status = 0;
        }

        public void ChangeStatus(Player player, Position theposition) // Om ospelad - Ändrar status på en specifik position. Värdet beror på spelare.
        {
            if (theposition.status < 1)
            {
                theposition.status += player.status;
            }
        }
    }
}