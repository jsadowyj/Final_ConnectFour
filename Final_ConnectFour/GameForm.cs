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
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void debug_red_Click(object sender, EventArgs e)
        {
            roundBtn_0_0.SetRed();
        }

        private void debug_yellow_Click(object sender, EventArgs e)
        {
            roundBtn_0_0.SetYellow();
        }

        private void debug_reset_Click(object sender, EventArgs e)
        {
            roundBtn_0_0.ResetButton();
        }
    }
}
