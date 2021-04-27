using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ConnectFour
{
    public class Cell
    {
        public int X { get; }
        public int Y { get; }
        public bool IsPlaced { get; private set; } = false;
        // The default value for player number is -1 if there is no player assigned
        // this should be used for error checks.

        // Im not the one handling this so you can change the implementation if you want...
        // but I was thinking:
        // Null = 0
        // Player 1 = 1
        // Player 2 = 2
        public int PlayerNumber { get; private set; } = 0;
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
        public Cell(int x, int y, RoundButton button, bool isPlaced, int playerNumber)
        {
            this.X = x;
            this.Y = y;
            this.Button = button;
            this.IsPlaced = isPlaced;
            this.PlayerNumber = playerNumber;

        }

        public void Reset()
        {
            this.Button.Enabled = true;
            this.IsPlaced = false;
            this.PlayerNumber = 0;
            this.Button.Reset();
        }

        public void PlaceRed(int playerNumber)
        {
            if (IsPlaced || !this.Button.Enabled) return;
            this.Button.SetRed();
            this.PlayerNumber = playerNumber;
            this.IsPlaced = true;
        }
        public void PlaceYellow(int playerNumber)
        {
            if (IsPlaced || !this.Button.Enabled) return;
            this.Button.SetYellow();
            this.PlayerNumber = playerNumber;
            this.IsPlaced = true;
        }

        // Debug Functions
        public override string ToString() => $"({X}, {Y})";

    }
}
