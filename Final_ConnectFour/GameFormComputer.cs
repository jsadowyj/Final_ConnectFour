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

        private bool CheckForWin(Cell cell, Board board)
        {
            bool isWin = false;

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

                if (Score == 4) { isWin = true; }
            }

            //Check vertical possibilities
            Score = 0;
            for (int i = 0; i < BoardRows; i++)
            {
                Cell CheckCell = board.GetCell(i, cell.Y);
                if (CheckCell.PlayerNumber == Type) { Score++; }
                else { Score = 0; }

                if (Score == 4) { isWin = true; }
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

                        if (Score == 4) { isWin = true; }

                        Over++;
                    }
                }
            }

            //Check Diagonal Possibilities Left Up
            for (int j = 5; j > 0; j--)
            {
                for (int row = 0; row < board.GetColumns(); row++) //Checks all possibilities going up and to the left
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

                        if (Score == 4) { isWin = true; }

                        Over++;
                    }
                }
            }

            return isWin;

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

        private void AI()
        {
            // Try to take win
            for (int col = 0; col < board.GetColumns(); col++)
            {
                Cell startCell = board.GetCell(0, col);
                Cell cell = board.GetLowestCell(startCell);

                Board virtualBoard = board.GenerateVirtualBoard();
                Cell virtualCell = virtualBoard.GetCell(cell.X, cell.Y);
                virtualCell.PlaceYellow(2);
                //virtualBoard.Print();
                bool isWin = CheckForWin(virtualCell, virtualBoard);
                if (isWin)
                {
                    cell = board.GetCell(virtualCell.X, virtualCell.Y);
                    cell.PlaceYellow(2);
                    CheckForWin(cell);
                    return;
                }

            }
            // Try to block win
            for (int col = 0; col < board.GetColumns(); col++)
            {
                Cell startCell = board.GetCell(0, col);
                Cell cell = board.GetLowestCell(startCell);

                Board virtualBoard = board.GenerateVirtualBoard();
                Cell virtualCell = virtualBoard.GetCell(cell.X, cell.Y);
                virtualCell.PlaceRed(1);
                //virtualBoard.Print();
                bool isWin = CheckForWin(virtualCell, virtualBoard);
                if (isWin)
                {
                    cell = board.GetCell(virtualCell.X, virtualCell.Y);
                    cell.PlaceYellow(2);
                    CheckForWin(cell);
                    return;
                }

            }

            // Try to place chip on top of already placed chip
            for (int col = 0; col < board.GetColumns(); col++)
            {
                Cell startCell = board.GetCell(0, col);
                Cell cell = board.GetLowestCell(startCell);

                if (cell.X < 5) cell = board.GetCell(cell.X + 1, col);
                
                if (cell.PlayerNumber == 2)
                {
                    if (board.IsPlaceable(cell.X - 1, cell.Y))
                    {
                        board.GetCell(cell.X - 1, cell.Y).PlaceYellow(2);
                        return;
                    }
                    continue;
                }

            }


            // Try to place chip to the left or right of a placed chip

            //===================================================================================
            // Jake's non-working code
            //===================================================================================
            //for (int col = 0; col < board.GetColumns(); col++)
            //{
            //    Cell startCell = board.GetCell(0, col);
            //    Cell cell = board.GetLowestCell(startCell);
            //    // Can either be -1, 0, or 1
            //    int direction = 0;

            //    int leftPoints = 0;
            //    int rightPoints = 0;

            //    // Loop through left side
            //    for (int i = cell.Y; board.IsValidCoordinate(cell.X, i); i--)
            //    {
            //        //Console.WriteLine("Left Side");
            //        //Console.WriteLine(board.GetCell(cell.X, i).ToString());
            //        if (board.GetCell(cell.X, i).PlayerNumber == 2) leftPoints++;
            //        if (board.GetCell(cell.X, i).PlayerNumber == 1) leftPoints = 0;
            //    }
            //    // Loop through right side
            //    for (int i = cell.Y; board.IsValidCoordinate(cell.X, i); i++)
            //    {
            //        //Console.WriteLine("Right Side");
            //        //Console.WriteLine(board.GetCell(cell.X, i).ToString());
            //        if (board.GetCell(cell.X, i).PlayerNumber == 2) rightPoints++;
            //        if (board.GetCell(cell.X, i).PlayerNumber == 1) rightPoints = 0;
            //    }
            //    if (leftPoints > rightPoints) direction = -1;
            //    if (rightPoints > leftPoints) direction = 1;
            //    if (leftPoints == rightPoints)
            //    {
            //        Random rand = new Random();
            //        int randNum = rand.Next(0, 2);
            //        direction = randNum == 0 ? -1 : 1;
            //    }

            //    if (direction == -1)
            //    {
            //        // Check if piece to the left is a valid coordinate
            //        if (board.IsPlaceable(cell.X, cell.Y - 1))
            //        {
            //            board.GetCell(cell.X, cell.Y - 1).PlaceYellow(2);
            //            return;
            //        }
            //        else if (board.IsPlaceable(cell.X, cell.Y + 1))
            //        {
            //            board.GetCell(cell.X, cell.Y + 1).PlaceYellow(2);
            //            return;
            //        }
            //    }

            //    if (direction == 1)
            //    {
            //        // Check if piece to the left is a valid coordinate
            //        if (board.IsPlaceable(cell.X, cell.Y + 1))
            //        {
            //            board.GetCell(cell.X, cell.Y + 1).PlaceYellow(2);
            //            return;
            //        }
            //        else if (board.IsPlaceable(cell.X, cell.Y - 1))
            //        {
            //            board.GetCell(cell.X, cell.Y - 1).PlaceYellow(2);
            //            return;
            //        }

            //    }
            //}
            //===================================================================================

            // Worst Case Scenerio pick a random number...
            // But this should rarely happen
            MessageBox.Show("Random!");
            // I'm gonna put a pop up so we know for sure when the random happens
            Random random = new Random();
            int randomNum = random.Next(0, board.GetColumns());
            Cell randomCell = board.GetCell(0, randomNum);
            randomCell = board.GetLowestCell(randomCell);
            while(!board.IsPlaceable(randomCell.X, randomCell.Y))
            {
                randomNum = random.Next(0, board.GetColumns());
                randomCell = board.GetCell(0, randomNum);
                randomCell = board.GetLowestCell(randomCell);
            }
            randomCell.PlaceYellow(2);

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
                }
                // Would you guys rather have the PlayerTurn assignments in the if or in a ternary like this?
                piecesPlaced++;
                
                CheckForWin(cell);
                PlayerTurn = 2;
                if (!GameWon && !GameDraw) AI();
                PlayerTurn = 1;
                if (!GameWon && !GameDraw) roundButton_MouseEnter(sender, e);
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
