
namespace Final_ConnectFour
{
    partial class StatsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsForm));
            this.lbl_stats = new System.Windows.Forms.Label();
            this.stats_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.totalGames_lbl = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.wins_lbl = new System.Windows.Forms.Label();
            this.tie_lbl = new System.Windows.Forms.Label();
            this.lbl_wins_player = new System.Windows.Forms.Label();
            this.lbl_ties = new System.Windows.Forms.Label();
            this.winPcntHead_lbl = new System.Windows.Forms.Label();
            this.lbl_percentage_player = new System.Windows.Forms.Label();
            this.lbl_player = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_wins_computer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_percentage_computer = new System.Windows.Forms.Label();
            this.btn_viewStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_stats
            // 
            this.lbl_stats.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_stats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_stats.Location = new System.Drawing.Point(0, -1);
            this.lbl_stats.Name = "lbl_stats";
            this.lbl_stats.Size = new System.Drawing.Size(801, 63);
            this.lbl_stats.TabIndex = 0;
            // 
            // stats_lbl
            // 
            this.stats_lbl.AutoSize = true;
            this.stats_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.stats_lbl.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stats_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.stats_lbl.Location = new System.Drawing.Point(301, -1);
            this.stats_lbl.Name = "stats_lbl";
            this.stats_lbl.Size = new System.Drawing.Size(212, 58);
            this.stats_lbl.TabIndex = 1;
            this.stats_lbl.Text = "Statistics";
            // 
            // total_lbl
            // 
            this.total_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.total_lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.total_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_lbl.Location = new System.Drawing.Point(0, 62);
            this.total_lbl.Name = "total_lbl";
            this.total_lbl.Size = new System.Drawing.Size(801, 63);
            this.total_lbl.TabIndex = 2;
            // 
            // totalGames_lbl
            // 
            this.totalGames_lbl.AutoSize = true;
            this.totalGames_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.totalGames_lbl.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGames_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.totalGames_lbl.Location = new System.Drawing.Point(157, 62);
            this.totalGames_lbl.Name = "totalGames_lbl";
            this.totalGames_lbl.Size = new System.Drawing.Size(436, 58);
            this.totalGames_lbl.TabIndex = 3;
            this.totalGames_lbl.Text = "Total Games Played:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_total.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_total.Location = new System.Drawing.Point(589, 62);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(53, 58);
            this.lbl_total.TabIndex = 4;
            this.lbl_total.Text = "0";
            // 
            // wins_lbl
            // 
            this.wins_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.wins_lbl.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.wins_lbl.Location = new System.Drawing.Point(17, 199);
            this.wins_lbl.Name = "wins_lbl";
            this.wins_lbl.Size = new System.Drawing.Size(272, 58);
            this.wins_lbl.TabIndex = 5;
            this.wins_lbl.Text = "Wins";
            this.wins_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tie_lbl
            // 
            this.tie_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tie_lbl.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tie_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tie_lbl.Location = new System.Drawing.Point(266, 199);
            this.tie_lbl.Name = "tie_lbl";
            this.tie_lbl.Size = new System.Drawing.Size(272, 58);
            this.tie_lbl.TabIndex = 7;
            this.tie_lbl.Text = "Ties";
            this.tie_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_wins_player
            // 
            this.lbl_wins_player.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_wins_player.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wins_player.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_wins_player.Location = new System.Drawing.Point(17, 257);
            this.lbl_wins_player.Name = "lbl_wins_player";
            this.lbl_wins_player.Size = new System.Drawing.Size(272, 58);
            this.lbl_wins_player.TabIndex = 8;
            this.lbl_wins_player.Text = "0";
            this.lbl_wins_player.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_ties
            // 
            this.lbl_ties.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_ties.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ties.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_ties.Location = new System.Drawing.Point(266, 257);
            this.lbl_ties.Name = "lbl_ties";
            this.lbl_ties.Size = new System.Drawing.Size(272, 58);
            this.lbl_ties.TabIndex = 10;
            this.lbl_ties.Text = "0";
            this.lbl_ties.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winPcntHead_lbl
            // 
            this.winPcntHead_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.winPcntHead_lbl.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winPcntHead_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.winPcntHead_lbl.Location = new System.Drawing.Point(512, 199);
            this.winPcntHead_lbl.Name = "winPcntHead_lbl";
            this.winPcntHead_lbl.Size = new System.Drawing.Size(272, 58);
            this.winPcntHead_lbl.TabIndex = 11;
            this.winPcntHead_lbl.Text = "Win %";
            this.winPcntHead_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_percentage_player
            // 
            this.lbl_percentage_player.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_percentage_player.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percentage_player.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_percentage_player.Location = new System.Drawing.Point(512, 257);
            this.lbl_percentage_player.Name = "lbl_percentage_player";
            this.lbl_percentage_player.Size = new System.Drawing.Size(272, 58);
            this.lbl_percentage_player.TabIndex = 13;
            this.lbl_percentage_player.Text = "0";
            this.lbl_percentage_player.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_player
            // 
            this.lbl_player.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_player.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold);
            this.lbl_player.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(46)))), ((int)(((byte)(48)))));
            this.lbl_player.Location = new System.Drawing.Point(266, 132);
            this.lbl_player.Name = "lbl_player";
            this.lbl_player.Size = new System.Drawing.Size(272, 58);
            this.lbl_player.TabIndex = 7;
            this.lbl_player.Text = "Player";
            this.lbl_player.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label1.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(150, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 58);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wins";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(266, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 58);
            this.label3.TabIndex = 7;
            this.label3.Text = "Computer";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_wins_computer
            // 
            this.lbl_wins_computer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_wins_computer.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_wins_computer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_wins_computer.Location = new System.Drawing.Point(151, 448);
            this.lbl_wins_computer.Name = "lbl_wins_computer";
            this.lbl_wins_computer.Size = new System.Drawing.Size(272, 58);
            this.lbl_wins_computer.TabIndex = 8;
            this.lbl_wins_computer.Text = "0";
            this.lbl_wins_computer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label6.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(369, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(272, 58);
            this.label6.TabIndex = 11;
            this.label6.Text = "Win %";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_percentage_computer
            // 
            this.lbl_percentage_computer.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_percentage_computer.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percentage_computer.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lbl_percentage_computer.Location = new System.Drawing.Point(370, 448);
            this.lbl_percentage_computer.Name = "lbl_percentage_computer";
            this.lbl_percentage_computer.Size = new System.Drawing.Size(272, 58);
            this.lbl_percentage_computer.TabIndex = 13;
            this.lbl_percentage_computer.Text = "0";
            this.lbl_percentage_computer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_viewStats
            // 
            this.btn_viewStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.btn_viewStats.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_viewStats.FlatAppearance.BorderSize = 3;
            this.btn_viewStats.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_viewStats.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewStats.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_viewStats.Location = new System.Drawing.Point(12, 11);
            this.btn_viewStats.Name = "btn_viewStats";
            this.btn_viewStats.Size = new System.Drawing.Size(87, 41);
            this.btn_viewStats.TabIndex = 51;
            this.btn_viewStats.Text = "Menu";
            this.btn_viewStats.UseVisualStyleBackColor = false;
            this.btn_viewStats.Click += new System.EventHandler(this.btn_viewStats_Click);
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.btn_viewStats);
            this.Controls.Add(this.lbl_percentage_computer);
            this.Controls.Add(this.lbl_percentage_player);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.winPcntHead_lbl);
            this.Controls.Add(this.lbl_ties);
            this.Controls.Add(this.lbl_wins_computer);
            this.Controls.Add(this.lbl_wins_player);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_player);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tie_lbl);
            this.Controls.Add(this.wins_lbl);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.totalGames_lbl);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.stats_lbl);
            this.Controls.Add(this.lbl_stats);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatsForm";
            this.Text = "Statistics";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatsForm_FormClosing);
            this.Load += new System.EventHandler(this.StatsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stats;
        private System.Windows.Forms.Label stats_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label totalGames_lbl;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label wins_lbl;
        private System.Windows.Forms.Label tie_lbl;
        private System.Windows.Forms.Label lbl_wins_player;
        private System.Windows.Forms.Label lbl_ties;
        private System.Windows.Forms.Label winPcntHead_lbl;
        private System.Windows.Forms.Label lbl_percentage_player;
        private System.Windows.Forms.Label lbl_player;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_wins_computer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_percentage_computer;
        private System.Windows.Forms.Button btn_viewStats;
    }
}