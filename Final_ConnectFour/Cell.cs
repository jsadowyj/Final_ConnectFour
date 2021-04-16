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

    }
}
