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
    public partial class GameWonForm : Form
    {
        // This is probably a really bad way to go about this...
        // but I would rather we just reuse this form than make a whole new winner form
        // for the Player vs Computer
        private dynamic parent;
        private bool shouldExit = true;
        private int playerNumber;
        public GameWonForm(dynamic parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.Text = "Draw!";
            lbl_header.Text = "Draw!";
        }

        public GameWonForm(dynamic parent, int playerNumber)
        {
            InitializeComponent();
            this.parent = parent;
            this.playerNumber = playerNumber;
        }

        private void GameWonForm_Load(object sender, EventArgs e)
        {
            switch (playerNumber)
            {
                case 1:
                    lbl_header.Text = "Red Wins!";
                    break;
                case 2:
                    lbl_header.Text = "Yellow Wins!";
                    break;
                default:
                    break;
            }
            Stats stats = new Stats();
            stats.Populate();

            lbl_computerWins.Text += stats.ComputerWins;
            lbl_playerWins.Text += stats.PlayerWins;
            lbl_draws.Text += stats.Draws;
        }

        private void GameWonForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldExit) Application.Exit();
        }

        private void btn_replay_Click(object sender, EventArgs e)
        {
            shouldExit = false;
            parent.Show();
            this.Close();
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            if (parent is GameForm)
            {
                GameForm gameForm = new GameForm(this.parent.parent);
                gameForm.StartPosition = FormStartPosition.CenterScreen;
                gameForm.Show();
                shouldExit = false;
                this.Close();
            }
            else
            {
                GameFormComputer gameFormComputer = new GameFormComputer(this.parent.parent);
                gameFormComputer.StartPosition = FormStartPosition.CenterScreen;
                gameFormComputer.Show();
                shouldExit = false;
                this.Close();
            }

        }


    }
}
