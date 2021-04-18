
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
            this.lbl_stats = new System.Windows.Forms.Label();
            this.stats_lbl = new System.Windows.Forms.Label();
            this.total_lbl = new System.Windows.Forms.Label();
            this.totalGames_lbl = new System.Windows.Forms.Label();
            this.gamesTally_lbl = new System.Windows.Forms.Label();
            this.wins_lbl = new System.Windows.Forms.Label();
            this.loss_lbl = new System.Windows.Forms.Label();
            this.tie_lbl = new System.Windows.Forms.Label();
            this.winsCnt_lbl = new System.Windows.Forms.Label();
            this.lossCnt_lbl = new System.Windows.Forms.Label();
            this.tiesCnt_lbl = new System.Windows.Forms.Label();
            this.winPcntHead_lbl = new System.Windows.Forms.Label();
            this.lossPcntHead_lbl = new System.Windows.Forms.Label();
            this.winPcnt_lbl = new System.Windows.Forms.Label();
            this.lossPcnt_lbl = new System.Windows.Forms.Label();
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
            this.stats_lbl.Location = new System.Drawing.Point(219, -1);
            this.stats_lbl.Name = "stats_lbl";
            this.stats_lbl.Size = new System.Drawing.Size(348, 58);
            this.stats_lbl.TabIndex = 1;
            this.stats_lbl.Text = "Player Statistics";
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
            this.totalGames_lbl.Location = new System.Drawing.Point(147, 62);
            this.totalGames_lbl.Name = "totalGames_lbl";
            this.totalGames_lbl.Size = new System.Drawing.Size(436, 58);
            this.totalGames_lbl.TabIndex = 3;
            this.totalGames_lbl.Text = "Total Games Played:";
            // 
            // gamesTally_lbl
            // 
            this.gamesTally_lbl.AutoSize = true;
            this.gamesTally_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gamesTally_lbl.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamesTally_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.gamesTally_lbl.Location = new System.Drawing.Point(570, 62);
            this.gamesTally_lbl.Name = "gamesTally_lbl";
            this.gamesTally_lbl.Size = new System.Drawing.Size(53, 58);
            this.gamesTally_lbl.TabIndex = 4;
            this.gamesTally_lbl.Text = "0";
            // 
            // wins_lbl
            // 
            this.wins_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.wins_lbl.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wins_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.wins_lbl.Location = new System.Drawing.Point(-10, 151);
            this.wins_lbl.Name = "wins_lbl";
            this.wins_lbl.Size = new System.Drawing.Size(272, 58);
            this.wins_lbl.TabIndex = 5;
            this.wins_lbl.Text = "Wins";
            this.wins_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loss_lbl
            // 
            this.loss_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.loss_lbl.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loss_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.loss_lbl.Location = new System.Drawing.Point(262, 151);
            this.loss_lbl.Name = "loss_lbl";
            this.loss_lbl.Size = new System.Drawing.Size(272, 58);
            this.loss_lbl.TabIndex = 6;
            this.loss_lbl.Text = "Losses";
            this.loss_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tie_lbl
            // 
            this.tie_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tie_lbl.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tie_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tie_lbl.Location = new System.Drawing.Point(529, 151);
            this.tie_lbl.Name = "tie_lbl";
            this.tie_lbl.Size = new System.Drawing.Size(272, 58);
            this.tie_lbl.TabIndex = 7;
            this.tie_lbl.Text = "Ties";
            this.tie_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winsCnt_lbl
            // 
            this.winsCnt_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.winsCnt_lbl.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsCnt_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.winsCnt_lbl.Location = new System.Drawing.Point(-10, 209);
            this.winsCnt_lbl.Name = "winsCnt_lbl";
            this.winsCnt_lbl.Size = new System.Drawing.Size(272, 58);
            this.winsCnt_lbl.TabIndex = 8;
            this.winsCnt_lbl.Text = "0";
            this.winsCnt_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lossCnt_lbl
            // 
            this.lossCnt_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lossCnt_lbl.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossCnt_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lossCnt_lbl.Location = new System.Drawing.Point(262, 209);
            this.lossCnt_lbl.Name = "lossCnt_lbl";
            this.lossCnt_lbl.Size = new System.Drawing.Size(272, 58);
            this.lossCnt_lbl.TabIndex = 9;
            this.lossCnt_lbl.Text = "0";
            this.lossCnt_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tiesCnt_lbl
            // 
            this.tiesCnt_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.tiesCnt_lbl.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesCnt_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tiesCnt_lbl.Location = new System.Drawing.Point(529, 209);
            this.tiesCnt_lbl.Name = "tiesCnt_lbl";
            this.tiesCnt_lbl.Size = new System.Drawing.Size(272, 58);
            this.tiesCnt_lbl.TabIndex = 10;
            this.tiesCnt_lbl.Text = "0";
            this.tiesCnt_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winPcntHead_lbl
            // 
            this.winPcntHead_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.winPcntHead_lbl.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winPcntHead_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.winPcntHead_lbl.Location = new System.Drawing.Point(3, 292);
            this.winPcntHead_lbl.Name = "winPcntHead_lbl";
            this.winPcntHead_lbl.Size = new System.Drawing.Size(408, 58);
            this.winPcntHead_lbl.TabIndex = 11;
            this.winPcntHead_lbl.Text = "Win %";
            this.winPcntHead_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lossPcntHead_lbl
            // 
            this.lossPcntHead_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lossPcntHead_lbl.Font = new System.Drawing.Font("Candara Light", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossPcntHead_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lossPcntHead_lbl.Location = new System.Drawing.Point(393, 292);
            this.lossPcntHead_lbl.Name = "lossPcntHead_lbl";
            this.lossPcntHead_lbl.Size = new System.Drawing.Size(408, 58);
            this.lossPcntHead_lbl.TabIndex = 12;
            this.lossPcntHead_lbl.Text = "Loss %";
            this.lossPcntHead_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winPcnt_lbl
            // 
            this.winPcnt_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.winPcnt_lbl.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winPcnt_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.winPcnt_lbl.Location = new System.Drawing.Point(3, 350);
            this.winPcnt_lbl.Name = "winPcnt_lbl";
            this.winPcnt_lbl.Size = new System.Drawing.Size(408, 58);
            this.winPcnt_lbl.TabIndex = 13;
            this.winPcnt_lbl.Text = "0";
            this.winPcnt_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lossPcnt_lbl
            // 
            this.lossPcnt_lbl.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lossPcnt_lbl.Font = new System.Drawing.Font("Candara Light", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lossPcnt_lbl.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lossPcnt_lbl.Location = new System.Drawing.Point(393, 350);
            this.lossPcnt_lbl.Name = "lossPcnt_lbl";
            this.lossPcnt_lbl.Size = new System.Drawing.Size(408, 58);
            this.lossPcnt_lbl.TabIndex = 14;
            this.lossPcnt_lbl.Text = "0";
            this.lossPcnt_lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // StatsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lossPcnt_lbl);
            this.Controls.Add(this.winPcnt_lbl);
            this.Controls.Add(this.lossPcntHead_lbl);
            this.Controls.Add(this.winPcntHead_lbl);
            this.Controls.Add(this.tiesCnt_lbl);
            this.Controls.Add(this.lossCnt_lbl);
            this.Controls.Add(this.winsCnt_lbl);
            this.Controls.Add(this.tie_lbl);
            this.Controls.Add(this.loss_lbl);
            this.Controls.Add(this.wins_lbl);
            this.Controls.Add(this.gamesTally_lbl);
            this.Controls.Add(this.totalGames_lbl);
            this.Controls.Add(this.total_lbl);
            this.Controls.Add(this.stats_lbl);
            this.Controls.Add(this.lbl_stats);
            this.Name = "StatsForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StatsForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_stats;
        private System.Windows.Forms.Label stats_lbl;
        private System.Windows.Forms.Label total_lbl;
        private System.Windows.Forms.Label totalGames_lbl;
        private System.Windows.Forms.Label gamesTally_lbl;
        private System.Windows.Forms.Label wins_lbl;
        private System.Windows.Forms.Label loss_lbl;
        private System.Windows.Forms.Label tie_lbl;
        private System.Windows.Forms.Label winsCnt_lbl;
        private System.Windows.Forms.Label lossCnt_lbl;
        private System.Windows.Forms.Label tiesCnt_lbl;
        private System.Windows.Forms.Label winPcntHead_lbl;
        private System.Windows.Forms.Label lossPcntHead_lbl;
        private System.Windows.Forms.Label winPcnt_lbl;
        private System.Windows.Forms.Label lossPcnt_lbl;
    }
}