using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ConnectFour
{
    public class Board
    {
        private const int rows = 6;
        private const int columns = 7;
        // {
        //   {(0,0), (0,1), (0,2), (0,3), (0,4), (0,5), (0,6)}, --> Index 0
        //   {(1,0), (1,1), (1,2), (1,3), (1,4), (1,5), (1,6)}, --> Index 1
        //   {(2,0), (2,1), (2,2), (2,3), (2,4), (2,5), (2,6)}, --> Index 2
        //   {(3,0), (3,1), (3,2), (3,3), (3,4), (3,5), (3,6)}, --> Index 3
        //   {(4,0), (4,1), (4,2), (4,3), (4,4), (4,5), (4,6)}, --> Index 4
        //   {(5,0), (5,1), (5,2), (5,3), (5,4), (5,5), (5,6)}, --> Index 5
        // }
        private Cell[,] board = new Cell[rows, columns];

        // Constructor
        public Board() { }

        public int GetRows()
        {
            return rows;
        }

        public int GetColumns()
        {
            return columns;
        }

        public Cell GetCell(int x, int y)
        {
            return this.board[x, y];
        }

        public void AddCell(Cell cell)
        {
            this.board[cell.X, cell.Y] = cell;
        }

        public Cell GetLowestCell(RoundButton roundButton)
        {
            Cell cell = roundButton.GetCell(this);
            int coordinate = rows - 1;

            while (coordinate >= 0)
            {
                if (!this.GetCell(coordinate, cell.Y).IsPlaced)
                    return this.GetCell(coordinate, cell.Y);
                coordinate--;
            }

            return cell;
        }

        // Just in case
        public Cell GetLowestCell(Cell cell)
        {
            int coordinate = rows - 1;

            while (coordinate >= 0)
            {
                if (!this.GetCell(coordinate, cell.Y).IsPlaced)
                    return this.GetCell(coordinate, cell.Y);
                coordinate--;
            }

            return cell;
        }
    }
}
