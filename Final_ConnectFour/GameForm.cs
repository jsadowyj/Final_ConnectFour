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
        private readonly Board board = new Board();
        private int _playerTurn = 1;
        private bool GameWon = false;
        private int PlayerTurn
        {
            get { return _playerTurn; }

            set
            {
                _playerTurn = value;
                lbl_playerTurn.Text = value.ToString();
                lbl_playerTurn.ForeColor = value == 1 ? System.Drawing.Color.Red : System.Drawing.Color.FromArgb(188, 171, 70);
            }
        }

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            // Ok... maybe this is a little hard coded
            // But since the image we used only has a set amount of holes
            // theres no reason for this to be dynamic.
            // Row One
            board.AddCell(new Cell(0, 0,roundBtn_0_0));
            board.AddCell(new Cell(0, 1, roundBtn_0_1));
            board.AddCell(new Cell(0, 2, roundBtn_0_2));
            board.AddCell(new Cell(0, 3, roundBtn_0_3));
            board.AddCell(new Cell(0, 4, roundBtn_0_4));
            board.AddCell(new Cell(0, 5, roundBtn_0_5));
            board.AddCell(new Cell(0, 6, roundBtn_0_6));

            // Row Two
            board.AddCell(new Cell(1, 0, roundBtn_1_0));
            board.AddCell(new Cell(1, 1, roundBtn_1_1));
            board.AddCell(new Cell(1, 2, roundBtn_1_2));
            board.AddCell(new Cell(1, 3, roundBtn_1_3));
            board.AddCell(new Cell(1, 4, roundBtn_1_4));
            board.AddCell(new Cell(1, 5, roundBtn_1_5));
            board.AddCell(new Cell(1, 6, roundBtn_1_6));

            // Row Three
            board.AddCell(new Cell(2, 0, roundBtn_2_0));
            board.AddCell(new Cell(2, 1, roundBtn_2_1));
            board.AddCell(new Cell(2, 2, roundBtn_2_2));
            board.AddCell(new Cell(2, 3, roundBtn_2_3));
            board.AddCell(new Cell(2, 4, roundBtn_2_4));
            board.AddCell(new Cell(2, 5, roundBtn_2_5));
            board.AddCell(new Cell(2, 6, roundBtn_2_6));

            // Row Four
            board.AddCell(new Cell(3, 0, roundBtn_3_0));
            board.AddCell(new Cell(3, 1, roundBtn_3_1));
            board.AddCell(new Cell(3, 2, roundBtn_3_2));
            board.AddCell(new Cell(3, 3, roundBtn_3_3));
            board.AddCell(new Cell(3, 4, roundBtn_3_4));
            board.AddCell(new Cell(3, 5, roundBtn_3_5));
            board.AddCell(new Cell(3, 6, roundBtn_3_6));

            // Row Five
            board.AddCell(new Cell(4, 0, roundBtn_4_0));
            board.AddCell(new Cell(4, 1, roundBtn_4_1));
            board.AddCell(new Cell(4, 2, roundBtn_4_2));
            board.AddCell(new Cell(4, 3, roundBtn_4_3));
            board.AddCell(new Cell(4, 4, roundBtn_4_4));
            board.AddCell(new Cell(4, 5, roundBtn_4_5));
            board.AddCell(new Cell(4, 6, roundBtn_4_6));

            // Row Six
            board.AddCell(new Cell(5, 0, roundBtn_5_0));
            board.AddCell(new Cell(5, 1, roundBtn_5_1));
            board.AddCell(new Cell(5, 2, roundBtn_5_2));
            board.AddCell(new Cell(5, 3, roundBtn_5_3));
            board.AddCell(new Cell(5, 4, roundBtn_5_4));
            board.AddCell(new Cell(5, 5, roundBtn_5_5));
            board.AddCell(new Cell(5, 6, roundBtn_5_6));
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();

        //Game Win Function (Kyle Bartram)
        private void CheckForWin(Cell cell)
        {
            GameWon = false;

            int BoardRows = board.GetRows();
            int BoardColumns = board.GetColumns();

            int Type = cell.PlayerNumber;

            //My logic for checking horizontal and vertical is it would be easier to check the whole row rather than to code a function 
            // that checks only possibilities based off of the piece placed

            //Check horizontal possibilities
            int Score = 0;
            for (int i = 0; i < BoardColumns; i++)
            {
                Cell CheckCell = board.GetCell(cell.X, i);
                if (CheckCell.PlayerNumber == Type) { Score++; }
                else { Score = 0; }

                if(Score == 4) { GameWon = true; }
            }

            //Check vertical possibilities
            Score = 0;
            for (int i = 0; i < BoardRows; i++)
            {
                Cell CheckCell = board.GetCell(i, cell.Y);
                if (CheckCell.PlayerNumber == Type) { Score++; }
                else { Score = 0; }

                if (Score == 4) { GameWon = true; }
            }

            //Check Diagonal Possibilities Right Up
            for (int row = 0; row < board.GetRows(); row++)                                 //Checks all possibilities going up and to the right
            {
                Cell TempCell = board.GetCell(5, row);
                if (TempCell.PlayerNumber == Type) { Score = 1; }
                else { Score = 0; }
                int Over = 1;
                for (int i = 5; i > 0; i--)
                {
                    if (row + Over >= BoardColumns || i - 1 < 0) { break; }
                    Cell CheckCell = board.GetCell(i - 1, row + Over);
                    if (CheckCell.PlayerNumber == Type) { Score++; }
                    else { Score = 0; }

                    if (Score == 4) { GameWon = true; }

                    Over++;
                }
            }

            //Check Diagonal Possibilities Left Up
            for (int row = 0; row < board.GetRows(); row++)                                 //Checks all possibilities going up and to the left
            {
                Cell TempCell = board.GetCell(5, row);
                if (TempCell.PlayerNumber == Type) { Score = 1; }
                else { Score = 0; }
                int Over = 1;
                for (int i = 5; i > 0; i--)
                {
                    if (row - Over < 0 || i - 1 < 0) { break; }
                    Cell CheckCell = board.GetCell(i - 1, row - Over);
                    if (CheckCell.PlayerNumber == Type) { Score++; }
                    else { Score = 0; }

                    if (Score == 4) { GameWon = true; }

                    Over++;
                }
            }


            /*
            //Diagonal going  up and right
            Score = 1;
            int Over = 1;
            for (int i = cell.X; i > 0; i--)
            {
                if (cell.Y + Over >= BoardColumns || i - 1 < 0) { break; }
                Cell CheckCell = board.GetCell(i - 1, cell.Y + Over);
                if (CheckCell.PlayerNumber == Type) { Score++; }
                else { Score = 0; }

                if (Score == 4) { GameWon = true; }

                Over++;
            }

            //Diagonal going  down and right
            Score = 1;
            Over = 1;
            //Console.WriteLine("Starting at Cell " + cell.X + ", " + cell.Y);
            for (int i = cell.X; i < BoardColumns; i++)
            {
                if (cell.Y - Over <= 0 || i + 1 >= BoardRows) { break; }
                Cell CheckCell = board.GetCell(i + 1, cell.Y - Over);
                if (CheckCell.PlayerNumber == Type) { Score++; }
                else { Score = 0; }

                if (Score == 4) { GameWon = true; }

                //Console.WriteLine("Checked cell" + CheckCell.X + ", " + CheckCell.Y);
                //Console.WriteLine("Score = " + Score);

                Over++;
            }

            //Diagonal going up and left
            Score = 1;
            Over = 1;
            for (int i = cell.X; i > 0; i--)
            {
                if (cell.Y - Over <= 0 || i - 1 < 0) { break; }
                Cell CheckCell = board.GetCell(i - 1, cell.Y - Over);
                if (CheckCell.PlayerNumber == Type) { Score++; }
                else { Score = 0; }

                if (Score == 4) { GameWon = true; }

                Over++;
            }

            //Diagonal going down and left
            Score = 1;
            Over = 1;
            for (int i = cell.X; i < BoardColumns; i++)
            {
                if (cell.Y - Over <= 0 || i + 1 >= BoardRows) { break; }
                Cell CheckCell = board.GetCell(i + 1, cell.Y - Over);
                if (CheckCell.PlayerNumber == Type) { Score++; }
                else { Score = 0; }

                if (Score == 4) { GameWon = true; }

                //Console.WriteLine("Checked cell" + CheckCell.X + ", " + CheckCell.Y);
                //Console.WriteLine("Score = " + Score);

                Over++;
            }*/

            if (GameWon)
            {
                MessageBox.Show("Win",
                "Win",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information  );
            }
        }

        private void roundButton_MouseEnter(object sender, EventArgs e)
        {
            RoundButton roundButton = sender as RoundButton;

            Cell cell = board.GetLowestCell(roundButton);

            if (!cell.IsPlaced)
            {
                cell.Button.ChangeHoverColor(PlayerTurn == 1 ? "Red" : "Yellow");
            }
        }
        private void roundButton_MouseLeave(object sender, EventArgs e)
        {
            RoundButton roundButton = sender as RoundButton;

            Cell cell = board.GetLowestCell(roundButton);

            if (!cell.IsPlaced)
            {
                cell.Button.ChangeHoverColor("Default");
            }
        }

        private void roundButton_Click(object sender, EventArgs e)
        {
            RoundButton roundButton = sender as RoundButton;

            Cell cell = board.GetLowestCell(roundButton);

            if (!cell.IsPlaced)
            {
                if (PlayerTurn == 1)
                {
                    cell.PlaceRed(PlayerTurn);
                    //PlayerTurn = 2;
                }
                else if (PlayerTurn == 2)
                {
                    cell.PlaceYellow(PlayerTurn);
                    //PlayerTurn = 1;
                }
                // Would you guys rather have the PlayerTurn assignments in the if or in a ternary like this?
                PlayerTurn = PlayerTurn == 1 ? 2 : 1;
                CheckForWin(cell);
                roundButton_MouseEnter(sender, e);
            } 
        }

        private void debug_reset_Click(object sender, EventArgs e)
        {
            for (int row = 0; row < board.GetRows(); row++)
            {
                for (int col = 0; col < board.GetColumns(); col++)
                {
                    board.GetCell(row, col).Reset();
                }
            }
            PlayerTurn = 1;
            GameWon = false;
        }
    }
}
