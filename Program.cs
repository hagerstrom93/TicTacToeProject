using System;

namespace TicTacToeProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Board TheBoard = new Board();
                Player player1 = new Player("X");
                Player player2 = new Player("O");
                Game TicTacToe = new Game();
                TicTacToe.StartGame(player1, player2, TheBoard, "NW.CC, NC.CC, NW.NW, NE.CC, NW.SE, CE.CC, CW.CC, SE.CC, CW.NW, CC.CC, CW.SE, CC.NW, CC.SE, CE.NW, SW.CC, CE.SE, SW.NW, SE.SE, SW.SE");
                Console.WriteLine();
            }
        }
    }
}

// NW.CC, NC.CC, NW.NW, NE.CC, NW.SE, CE.CC, CW.CC, SE.CC, CW.NW, CC.CC, CW.SE, CC.NW, CC.SE, CE.NW, SW.CC, CE.SE, SW.NW, SE.SE, SW.SE === ORGINALSTIRNG
// CC.NW, CE.NW, CC.CC, CE.CC, CC.SE, CE.SW, SC.NW, SE.NW, SC.CW, SE.CW, SC.SW, SE.SC, NC.NW, NE.NW, NC.CW, NE.CW, NC.SW, NE.SC === Alternativ
// NW.CC,NC.CC,NW.NW,NE.CC,NW.SE,CE.CC,CW.CC,SE.CC,CW.NW,CC.CC,NC.CC, CW.SE, CW.CC,CC.NW,CC.SE, CE.NW,SW.CC, CE.SE,SW.NW, NW.SE, SE.SE,SW.SE === INPUTSTRÄNG MED 3 "FELDRAG"
