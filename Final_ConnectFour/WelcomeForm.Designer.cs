﻿
namespace Final_ConnectFour
{
    partial class WelcomeForm
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
            this.btn_1player = new System.Windows.Forms.Button();
            this.btn_2player = new System.Windows.Forms.Button();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_wins = new System.Windows.Forms.Label();
            this.lbl_losses = new System.Windows.Forms.Label();
            this.wins_count = new System.Windows.Forms.TextBox();
            this.losses_count = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_1player
            // 
            this.btn_1player.BackColor = System.Drawing.Color.Turquoise;
            this.btn_1player.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1player.Location = new System.Drawing.Point(151, 322);
            this.btn_1player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_1player.Name = "btn_1player";
            this.btn_1player.Size = new System.Drawing.Size(316, 182);
            this.btn_1player.TabIndex = 0;
            this.btn_1player.Text = "1 Player";
            this.btn_1player.UseVisualStyleBackColor = false;
            // 
            // btn_2player
            // 
            this.btn_2player.BackColor = System.Drawing.Color.Turquoise;
            this.btn_2player.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_2player.Location = new System.Drawing.Point(616, 322);
            this.btn_2player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_2player.Name = "btn_2player";
            this.btn_2player.Size = new System.Drawing.Size(316, 182);
            this.btn_2player.TabIndex = 1;
            this.btn_2player.Text = "2 Player";
            this.btn_2player.UseVisualStyleBackColor = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(352, 11);
            this.lbl_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(341, 58);
            this.lbl_1.TabIndex = 2;
            this.lbl_1.Text = "Connect Four";
            this.lbl_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(475, 502);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(133, 63);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // lbl_wins
            // 
            this.lbl_wins.AutoSize = true;
            this.lbl_wins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wins.Location = new System.Drawing.Point(265, 105);
            this.lbl_wins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_wins.Name = "lbl_wins";
            this.lbl_wins.Size = new System.Drawing.Size(111, 39);
            this.lbl_wins.TabIndex = 4;
            this.lbl_wins.Text = "WINS";
            // 
            // lbl_losses
            // 
            this.lbl_losses.AutoSize = true;
            this.lbl_losses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_losses.Location = new System.Drawing.Point(689, 105);
            this.lbl_losses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_losses.Name = "lbl_losses";
            this.lbl_losses.Size = new System.Drawing.Size(160, 39);
            this.lbl_losses.TabIndex = 5;
            this.lbl_losses.Text = "LOSSES";
            // 
            // wins_count
            // 
            this.wins_count.BackColor = System.Drawing.Color.DodgerBlue;
            this.wins_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.wins_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins_count.Location = new System.Drawing.Point(251, 178);
            this.wins_count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.wins_count.Name = "wins_count";
            this.wins_count.Size = new System.Drawing.Size(133, 38);
            this.wins_count.TabIndex = 6;
            this.wins_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // losses_count
            // 
            this.losses_count.BackColor = System.Drawing.Color.DodgerBlue;
            this.losses_count.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.losses_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losses_count.Location = new System.Drawing.Point(697, 178);
            this.losses_count.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.losses_count.Name = "losses_count";
            this.losses_count.Size = new System.Drawing.Size(133, 38);
            this.losses_count.TabIndex = 7;
            this.losses_count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 565);
            this.Controls.Add(this.losses_count);
            this.Controls.Add(this.wins_count);
            this.Controls.Add(this.lbl_losses);
            this.Controls.Add(this.lbl_wins);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.btn_2player);
            this.Controls.Add(this.btn_1player);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1player;
        private System.Windows.Forms.Button btn_2player;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_wins;
        private System.Windows.Forms.Label lbl_losses;
        private System.Windows.Forms.TextBox wins_count;
        private System.Windows.Forms.TextBox losses_count;
    }
}