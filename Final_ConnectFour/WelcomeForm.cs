﻿using System;
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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_1player_Click(object sender, EventArgs e)
        {
            GameFormComputer gameFormComputer = new GameFormComputer(this);
            gameFormComputer.StartPosition = FormStartPosition.Manual;
            gameFormComputer.Location = this.Location;
            gameFormComputer.Show();
            this.Hide();
        }

        private void btn_2player_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm(this);
            gameForm.StartPosition = FormStartPosition.Manual;
            gameForm.Location = this.Location;
            gameForm.Show();
            this.Hide();
        }

        private void btn_viewStats_Click(object sender, EventArgs e)
        {
            StatsForm statsForm = new StatsForm(this);
            statsForm.StartPosition = FormStartPosition.Manual;
            statsForm.Location = this.Location;
            statsForm.Show();
            this.Hide();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
