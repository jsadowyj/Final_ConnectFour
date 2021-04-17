using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ConnectFour
{
    public partial class GameForm : Form
    {
        int counter = 0;

        private Board gameBoard = new Board();
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Ok... maybe this is a little hard coded

            // Row One
            gameBoard.AddCell(new Cell(0, 0,roundBtn_0_0));
            gameBoard.AddCell(new Cell(0, 1, roundBtn_0_1));
            gameBoard.AddCell(new Cell(0, 2, roundBtn_0_2));
            gameBoard.AddCell(new Cell(0, 3, roundBtn_0_3));
            gameBoard.AddCell(new Cell(0, 4, roundBtn_0_4));
            gameBoard.AddCell(new Cell(0, 5, roundBtn_0_5));
            gameBoard.AddCell(new Cell(0, 6, roundBtn_0_6));

            // Row Two
            gameBoard.AddCell(new Cell(1, 0, roundBtn_1_0));
            gameBoard.AddCell(new Cell(1, 1, roundBtn_1_1));
            gameBoard.AddCell(new Cell(1, 2, roundBtn_1_2));
            gameBoard.AddCell(new Cell(1, 3, roundBtn_1_3));
            gameBoard.AddCell(new Cell(1, 4, roundBtn_1_4));
            gameBoard.AddCell(new Cell(1, 5, roundBtn_1_5));
            gameBoard.AddCell(new Cell(1, 6, roundBtn_1_6));

            // Row Three
            gameBoard.AddCell(new Cell(2, 0, roundBtn_2_0));
            gameBoard.AddCell(new Cell(2, 1, roundBtn_2_1));
            gameBoard.AddCell(new Cell(2, 2, roundBtn_2_2));
            gameBoard.AddCell(new Cell(2, 3, roundBtn_2_3));
            gameBoard.AddCell(new Cell(2, 4, roundBtn_2_4));
            gameBoard.AddCell(new Cell(2, 5, roundBtn_2_5));
            gameBoard.AddCell(new Cell(2, 6, roundBtn_2_6));

            // Row Four
            gameBoard.AddCell(new Cell(3, 0, roundBtn_3_0));
            gameBoard.AddCell(new Cell(3, 1, roundBtn_3_1));
            gameBoard.AddCell(new Cell(3, 2, roundBtn_3_2));
            gameBoard.AddCell(new Cell(3, 3, roundBtn_3_3));
            gameBoard.AddCell(new Cell(3, 4, roundBtn_3_4));
            gameBoard.AddCell(new Cell(3, 5, roundBtn_3_5));
            gameBoard.AddCell(new Cell(3, 6, roundBtn_3_6));

            // Row Five
            gameBoard.AddCell(new Cell(4, 0, roundBtn_4_0));
            gameBoard.AddCell(new Cell(4, 1, roundBtn_4_1));
            gameBoard.AddCell(new Cell(4, 2, roundBtn_4_2));
            gameBoard.AddCell(new Cell(4, 3, roundBtn_4_3));
            gameBoard.AddCell(new Cell(4, 4, roundBtn_4_4));
            gameBoard.AddCell(new Cell(4, 5, roundBtn_4_5));
            gameBoard.AddCell(new Cell(4, 6, roundBtn_4_6));

            // Row Six
            gameBoard.AddCell(new Cell(5, 0, roundBtn_5_0));
            gameBoard.AddCell(new Cell(5, 1, roundBtn_5_1));
            gameBoard.AddCell(new Cell(5, 2, roundBtn_5_2));
            gameBoard.AddCell(new Cell(5, 3, roundBtn_5_3));
            gameBoard.AddCell(new Cell(5, 4, roundBtn_5_4));
            gameBoard.AddCell(new Cell(5, 5, roundBtn_5_5));
            gameBoard.AddCell(new Cell(5, 6, roundBtn_5_6));
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void roundButton_Click(object sender, EventArgs e)
        {
            
            RoundButton roundButton = sender as RoundButton;

            if (counter%2 == 0)
            {
                roundButton.PlaceRed();
                MessageBox.Show(roundButton.Name);
                counter++;
            }
            else
            {
                roundButton.PlaceYellow();
                MessageBox.Show(roundButton.Name);
                counter++;
            }
        }

        private void debug_red_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gameBoard.board.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.board.GetLength(1); col++)
                {
                    gameBoard.GetCell(row, col).Button.ChangeHoverColor("Red");
                }
            }
        }

        private void debug_yellow_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gameBoard.board.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.board.GetLength(1); col++)
                {
                    gameBoard.GetCell(row, col).Button.ChangeHoverColor("Yellow");
                }
            }
        }

        private void debug_reset_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < gameBoard.board.GetLength(0); row++)
            {
                for (int col = 0; col < gameBoard.board.GetLength(1); col++)
                {
                    gameBoard.GetCell(row, col).Button.ChangeHoverColor("Default");
                }
            }
        }


    }
}
