
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
            this.dsn_lbl_3 = new System.Windows.Forms.Label();
            this.dsn_lbl_6 = new System.Windows.Forms.Label();
            this.btn_replay = new System.Windows.Forms.Button();
            this.btn_return = new System.Windows.Forms.Button();
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
            // dsn_lbl_3
            // 
            this.dsn_lbl_3.AutoSize = true;
            this.dsn_lbl_3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.dsn_lbl_3.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dsn_lbl_3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.dsn_lbl_3.Location = new System.Drawing.Point(33, 9);
            this.dsn_lbl_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dsn_lbl_3.Name = "dsn_lbl_3";
            this.dsn_lbl_3.Size = new System.Drawing.Size(299, 59);
            this.dsn_lbl_3.TabIndex = 7;
            this.dsn_lbl_3.Text = "Player 1 Wins!";
            this.dsn_lbl_3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dsn_lbl_6
            // 
            this.dsn_lbl_6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.dsn_lbl_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dsn_lbl_6.Location = new System.Drawing.Point(12, 91);
            this.dsn_lbl_6.Name = "dsn_lbl_6";
            this.dsn_lbl_6.Size = new System.Drawing.Size(327, 107);
            this.dsn_lbl_6.TabIndex = 10;
            // 
            // btn_replay
            // 
            this.btn_replay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.btn_replay.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_replay.FlatAppearance.BorderSize = 3;
            this.btn_replay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_replay.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_replay.Location = new System.Drawing.Point(25, 101);
            this.btn_replay.Margin = new System.Windows.Forms.Padding(4);
            this.btn_replay.Name = "btn_replay";
            this.btn_replay.Size = new System.Drawing.Size(138, 88);
            this.btn_replay.TabIndex = 11;
            this.btn_replay.Text = "Play Again";
            this.btn_replay.UseVisualStyleBackColor = false;
            // 
            // btn_return
            // 
            this.btn_return.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(215)))), ((int)(((byte)(166)))));
            this.btn_return.FlatAppearance.BorderColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_return.FlatAppearance.BorderSize = 3;
            this.btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_return.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_return.Location = new System.Drawing.Point(191, 101);
            this.btn_return.Margin = new System.Windows.Forms.Padding(4);
            this.btn_return.Name = "btn_return";
            this.btn_return.Size = new System.Drawing.Size(138, 88);
            this.btn_return.TabIndex = 12;
            this.btn_return.Text = "Return to Menu";
            this.btn_return.UseVisualStyleBackColor = false;
            // 
            // GameWonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(351, 207);
            this.Controls.Add(this.btn_return);
            this.Controls.Add(this.btn_replay);
            this.Controls.Add(this.dsn_lbl_6);
            this.Controls.Add(this.dsn_lbl_3);
            this.Controls.Add(this.dsn_lbl_1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameWonForm";
            this.Text = "Winner!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dsn_lbl_1;
        private System.Windows.Forms.Label dsn_lbl_3;
        private System.Windows.Forms.Label dsn_lbl_6;
        private System.Windows.Forms.Button btn_replay;
        private System.Windows.Forms.Button btn_return;
    }
}