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
    public partial class StatsForm : Form
    {
        private WelcomeForm parent;
        bool shouldExit = true;

        public StatsForm()
        {
            InitializeComponent();
        }

        public StatsForm(WelcomeForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void StatsForm_Load(object sender, EventArgs e)
        {
            Stats stats = new Stats();
            stats.Populate();

            double totalGames = stats.PlayerWins + stats.ComputerWins + stats.Draws;
            double playerPercentage = Math.Round((stats.PlayerWins / totalGames), 3) * 100;
            double computerPercentage = Math.Round((stats.ComputerWins / totalGames), 3) * 100;

            lbl_total.Text = totalGames.ToString();
            lbl_wins_player.Text = stats.PlayerWins.ToString();
            lbl_wins_computer.Text = stats.ComputerWins.ToString();
            lbl_ties.Text = stats.Draws.ToString();
            lbl_percentage_player.Text = playerPercentage.ToString() + "%";
            lbl_percentage_computer.Text = computerPercentage.ToString() + "%";
        }

        private void StatsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (shouldExit) Application.Exit();
        }

        private void btn_viewStats_Click(object sender, EventArgs e)
        {
            parent.Show();
            shouldExit = false;
            this.Close();
        }


    }
}
