using System.Collections.Generic;

namespace TicTacToeProjekt
{
    public class Player
    {
        public string Name { get; private set; }
        public int status;
        public List<Square> WonSquares;

        public Player(string name) // Konstruktor. Varje spelare har ett namn samt en Lista som fylls med vunna Rutor.
        {
            WonSquares = new List<Square>(0);
            Name = name;

            if (name == "X")
            {
                status = 1;
            }
            else if (name == "O")
            {
                status = 2;
            }
        }
    }
}