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

        Cell(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

    }
}
