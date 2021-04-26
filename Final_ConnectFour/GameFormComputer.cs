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
    public partial class GameFormComputer : Form
    {
        public WelcomeForm parent { get; }
        private readonly Board board = new Board();
        private int _playerTurn = 1;
        private int PlayerTurn
        {
            get { return _playerTurn; }

            set
            {
                _playerTurn = value;
                lbl_playerTurn.Text = value == 1 ? "Red" : "Yellow";
                lbl_playerTurn.ForeColor = value == 1 
                    ? System.Drawing.Color.FromArgb(213,46,48) 
                    : System.Drawing.Color.FromArgb(188, 171, 70);
            }
        }
        private int piecesPlaced = 0;
        private bool GameWon = false;
        private bool GameDraw = false;
        private bool shouldExit = true;

        public GameFormComputer(WelcomeForm parent)
        {
            InitializeComponent();
            this.parent = parent;
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

            for (int row = 0; row < board.GetRows(); row++)
            {
                for (int col = 0; col < board.GetColumns(); col++)
                {
                    board.GetCell(row, col).Button.SetParent(pb_board);
                }
            }
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldExit) Application.Exit();
        }

        private void DisableGame()
        {
            lbl_info.Visible = false;
            lbl_playerTurn.Visible = false;
            lbl_gameOver.Visible = true;
            for (int row = 0; row < board.GetRows(); row++)
            {
                for (int col = 0; col < board.GetColumns(); col++)
                {
                    board.GetCell(row, col).Button.Enabled = false;
                }
            }
        }

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
            for(int j = 5; j > 0; j--)
            {
                for (int row = 0; row < board.GetColumns(); row++)                                 //Checks all possibilities going up and to the right
                {
                    Cell TempCell = board.GetCell(j, row);
                    if (TempCell.PlayerNumber == Type) { Score = 1; }
                    else { Score = 0; }
                    int Over = 1;
                    for (int i = j; i > 0; i--)
                    {
                        if (row + Over >= BoardColumns || i - 1 < 0) { break; }
                        Cell CheckCell = board.GetCell(i - 1, row + Over);
                        if (CheckCell.PlayerNumber == Type) { Score++; }
                        else { Score = 0; }

                        if (Score == 4) { GameWon = true; }

                        Over++;
                    }
                }
            }

            //Check Diagonal Possibilities Left Up
            for(int j = 5; j > 0; j--)
            {
                for (int row = 0; row < board.GetColumns(); row++)                                 //Checks all possibilities going up and to the left
                {
                    Cell TempCell = board.GetCell(j, row);
                    if (TempCell.PlayerNumber == Type) { Score = 1; }
                    else { Score = 0; }
                    int Over = 1;
                    for (int i = j; i > 0; i--)
                    {
                        if (row - Over < 0 || i - 1 < 0) { break; }
                        Cell CheckCell = board.GetCell(i - 1, row - Over);
                        if (CheckCell.PlayerNumber == Type) { Score++; }
                        else { Score = 0; }

                        if (Score == 4) { GameWon = true; }

                        Over++;
                    }
                }
            }

            // Check for game draw
            if (piecesPlaced == board.GetRows() * board.GetColumns()) GameDraw = true;

            if (GameWon || GameDraw)
            {
                DisableGame();

                if (GameWon)
                {
                    GameWonForm gameWonForm = new GameWonForm(this, Type);
                    gameWonForm.StartPosition = FormStartPosition.CenterParent;
                    this.Hide();
                    gameWonForm.ShowDialog();
                } 
                else if (GameDraw)
                {
                    GameWonForm gameWonForm = new GameWonForm(this);
                    gameWonForm.StartPosition = FormStartPosition.CenterParent;
                    this.Hide();
                    gameWonForm.ShowDialog();
                }

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

        private void AIsearch(Cell cell)
        {
            int BoardRows = board.GetRows();
            int BoardColumns = board.GetColumns();

            Cell cell1 = board.GetCell(1,1);
            //just a dummy cell.
            int Type = 1;

           

            
            int Score = 0;
            for (int i = 0; i < BoardColumns; i++)
            {

                Cell CheckCell = board.GetCell(cell.X, i);
                if (Score == 3)
                {
                    
                        CheckCell.PlaceYellow(2);
                        return;
                  
                }
                else
                {
                    if (CheckCell.PlayerNumber == Type) { Score++; }
                    else { Score = 0; }

                }

            }

           Score = 0;
           for (int i = 6; i > 0; i--)
           {

               Cell CheckCell = board.GetCell(cell.X, i);
               if (Score == 3)
               {
                 CheckCell.PlaceYellow(2);
                 return;
               }
              if (CheckCell.PlayerNumber == Type) { Score++; }
              else { Score = 0; }

               

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
            for (int j = 5; j > 0; j--)
            {
                for (int row = 0; row < board.GetColumns(); row++)                                 //Checks all possibilities going up and to the right
                {
                    Cell TempCell = board.GetCell(j, row);
                    if (TempCell.PlayerNumber == Type) { Score = 1; }
                    else { Score = 0; }
                    int Over = 1;
                    for (int i = j; i > 0; i--)
                    {
                        if (row + Over >= BoardColumns || i - 1 < 0) { break; }
                        Cell CheckCell = board.GetCell(i - 1, row + Over);
                        if (CheckCell.PlayerNumber == Type) { Score++; }
                        else { Score = 0; }

                        if (Score == 4) { GameWon = true; }

                        Over++;
                    }
                }
            }

            //Check Diagonal Possibilities Left Up
            for (int j = 5; j > 0; j--)
            {
                for (int row = 0; row < board.GetColumns(); row++)                                 //Checks all possibilities going up and to the left
                {
                    Cell TempCell = board.GetCell(j, row);
                    if (TempCell.PlayerNumber == Type) { Score = 1; }
                    else { Score = 0; }
                    int Over = 1;
                    for (int i = j; i > 0; i--)
                    {
                        if (row - Over < 0 || i - 1 < 0) { break; }
                        Cell CheckCell = board.GetCell(i - 1, row - Over);
                        if (CheckCell.PlayerNumber == Type) { Score++; }
                        else { Score = 0; }

                        if (Score == 4) { GameWon = true; }

                        Over++;
                    }
                }
            }
        }

        private void AI(RoundButton roundButton, Cell cell)
        {
            //this "random" choice simply lets the game really start. 
            Cell celll = board.GetCell(cell.X, cell.Y-1);
            if (piecesPlaced == 1)
            {
                celll.PlaceYellow(2);
                //now we are cooking.
            }
            else
            {
                AIsearch(cell);
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
                // Would you guys rather have the PlayerTurn assignments in the if or in a ternary like this?
                piecesPlaced++;
                
                CheckForWin(cell);
                AI(roundButton, cell);
                if (!GameWon) roundButton_MouseEnter(sender, e);
            }
        }

        private void btn_restart_Click(object sender, EventArgs e)
        {
            piecesPlaced = 0;
            lbl_gameOver.Visible = false;
            lbl_info.Visible = true;
            lbl_playerTurn.Visible = true;
            for (int row = 0; row < board.GetRows(); row++)
            {
                for (int col = 0; col < board.GetColumns(); col++)
                {
                    board.GetCell(row, col).Reset();
                }
            }
            PlayerTurn = 1;
            GameWon = false;
            GameDraw = false;
    }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            parent.Show();
            shouldExit = false;
            this.Close();
        }
    }
}
