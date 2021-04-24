using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ConnectFour
{
    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPlaced { get; set; } = false;
        // The default value for player number is -1 if there is no player assigned
        // this should be used for error checks.

        // Im not the one handling this so you can change the implementation if you want...
        // but I was thinking:
        // Undefined = -1
        // Computer/AI = 0
        // Player 1 = 1
        // Player 2 = 2
        public int PlayerNumber { get; set; } = -1;
        public RoundButton Button { get; set; }

        public Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public Cell(int x, int y, RoundButton button)
        {
            this.X = x;
            this.Y = y;
            this.Button = button;
        }
        public void Reset()
        {
            this.IsPlaced = false;
            this.PlayerNumber = -1;
            this.Button.Reset();
        }

        public void PlaceRed(int playerNumber)
        {
            this.Button.SetRed();
            this.PlayerNumber = playerNumber;
            this.IsPlaced = true;
        }
        public void PlaceYellow(int playerNumber)
        {
            this.Button.SetYellow();
            this.PlayerNumber = playerNumber;
            this.IsPlaced = true;
        }

        // Debug Functions
        public override string ToString() => $"({X}, {Y})";

    }
}
