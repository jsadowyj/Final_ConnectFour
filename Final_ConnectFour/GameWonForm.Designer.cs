
namespace Final_ConnectFour
{
    partial class GameWonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWonForm));
            this.dsn_lbl_1 = new System.Windows.Forms.Label();
            this.lbl_header = new System.Windows.Forms.Label();
            this.dsn_lbl_6 = new System.Windows.Forms.Label();
            this.btn_replay = new System.Windows.Forms.Button();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.lbl_playerWins = new System.Windows.Forms.Label();
            this.lbl_computerWins = new System.Windows.Forms.Label();
            this.lbl_draws = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dsn_lbl_1
            // 
            this.dsn_lbl_1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dsn_lbl_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dsn_lbl_1.Location = new System.Drawing.Point(-3, -1);
            this.dsn_lbl_1.Name = "dsn_lbl_1";
            this.dsn_lbl_1.Size = new System.Drawing.Size(360, 78);
            this.dsn_lbl_1.TabIndex = 5;
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_header.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_header.Location = new System.Drawing.Point(-3, 11);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(360, 57);
            this.lbl_header.TabIndex = 7;
            this.lbl_header.Text = "{Color} Wins!";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dsn_lbl_6
            // 
            this.dsn_lbl_6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dsn_lbl_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dsn_lbl_6.Location = new System.Drawing.Point(12, 91);
            this.dsn_lbl_6.Name = "dsn_lbl_6";
            this.dsn_lbl_6.Size = new System.Drawing.Size(327, 207);
            this.dsn_lbl_6.TabIndex = 10;
            // 
            // btn_replay
            // 
            this.btn_replay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.btn_replay.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_replay.FlatAppearance.BorderSize = 3;
            this.btn_replay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_replay.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replay.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_replay.Location = new System.Drawing.Point(25, 101);
            this.btn_replay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(304, 89);
            this.btn_replay.TabIndex = 11;
            this.btn_replay.Text = "Review Game";
            this.btn_replay.UseVisualStyleBackColor = false;
            this.btn_replay.Click += new System.EventHandler(this.btn_replay_Click);
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.btn_playAgain.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_playAgain.FlatAppearance.BorderSize = 3;
            this.btn_playAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_playAgain.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playAgain.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btn_playAgain.Location = new System.Drawing.Point(25, 197);
            this.btn_playAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(304, 89);
            this.btn_playAgain.TabIndex = 11;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = false;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // lbl_playerWins
            // 
            this.lbl_playerWins.AutoSize = true;
            this.lbl_playerWins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_playerWins.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWins.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_playerWins.Location = new System.Drawing.Point(5, 315);
            this.lbl_playerWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_playerWins.Name = "lbl_playerWins";
            this.lbl_playerWins.Size = new System.Drawing.Size(155, 33);
            this.lbl_playerWins.TabIndex = 13;
            this.lbl_playerWins.Text = "Player Wins: ";
            // 
            // lbl_computerWins
            // 
            this.lbl_computerWins.AutoSize = true;
            this.lbl_computerWins.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computerWins.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_computerWins.Location = new System.Drawing.Point(5, 361);
            this.lbl_computerWins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_computerWins.Name = "lbl_computerWins";
            this.lbl_computerWins.Size = new System.Drawing.Size(198, 33);
            this.lbl_computerWins.TabIndex = 13;
            this.lbl_computerWins.Text = "Computer Wins: ";
            // 
            // lbl_draws
            // 
            this.lbl_draws.AutoSize = true;
            this.lbl_draws.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_draws.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_draws.Location = new System.Drawing.Point(8, 407);
            this.lbl_draws.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_draws.Name = "lbl_draws";
            this.lbl_draws.Size = new System.Drawing.Size(96, 33);
            this.lbl_draws.TabIndex = 13;
            this.lbl_draws.Text = "Draws: ";
            // 
            // GameWonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(351, 457);
            this.Controls.Add(this.lbl_draws);
            this.Controls.Add(this.lbl_computerWins);
            this.Controls.Add(this.lbl_playerWins);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.btn_replay);
            this.Controls.Add(this.dsn_lbl_6);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.dsn_lbl_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GameWonForm";
            this.Text = "Winner!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameWonForm_FormClosing);
            this.Load += new System.EventHandler(this.GameWonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dsn_lbl_1;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label dsn_lbl_6;
        private System.Windows.Forms.Button btn_replay;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Label lbl_playerWins;
        private System.Windows.Forms.Label lbl_computerWins;
        private System.Windows.Forms.Label lbl_draws;
    }
}