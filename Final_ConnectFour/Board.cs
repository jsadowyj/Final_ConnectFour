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

        // Create copy of board
        public Board GenerateVirtualBoard()
        {
            Board newBoard = new Board();
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < columns; col++)
                {
                    Cell oldCell = this.GetCell(row, col);
                    Cell newCell = new Cell(oldCell.X, oldCell.Y, new RoundButton(), oldCell.IsPlaced, oldCell.PlayerNumber);
                    newBoard.AddCell(newCell);
                }
            }

            return newBoard;
        }
        // Gotta make debugging look good
        public void Print()
        {
            Console.Write("\n");
            Console.WriteLine("=====================");
            Console.WriteLine("     Board Print");
            Console.WriteLine("=====================");
            Console.Write("[");
            Console.Write("\n");
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col <= columns; col++)
                {
                    if (col < columns)
                    {
                        string num = this.GetCell(row, col).PlayerNumber.ToString();
                        if (num.Length < 2) Console.Write(' ');
                        Console.Write(num + ",");
                    }
                    else
                    {
                        Console.Write("\n");
                    }
                }
            }
            Console.WriteLine("]");
            Console.WriteLine("=====================");
        }

        public bool IsValidCoordinate(int x, int y) => (x < rows && x >= 0) && (y < columns && y >= 0);
        public bool IsPlaceable(int x, int y)
        {
            // If it is not a valid coordinate then you obviously can't place it
            if (!IsValidCoordinate(x,y)) return false;
            // If it's already placed you can't place it
            if (this.GetCell(x, y).IsPlaced) return false;

            // If it gets through the other if statements then we can assume that it is
            // valid and is not placed
            // so if x is on the bottom row that means you can place it
            if (x == rows - 1) return true;

            // If the cell below it is placed then you are able to place it
            if (this.GetCell(x + 1, y).IsPlaced) return true;

            return false;
        }

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
