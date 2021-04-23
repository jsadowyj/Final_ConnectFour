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

        // For Debug
        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public void Reset()
        {
            this.IsPlaced = false;
            this.PlayerNumber = -1;
            this.Button.ResetButton();
        }

    }
}
