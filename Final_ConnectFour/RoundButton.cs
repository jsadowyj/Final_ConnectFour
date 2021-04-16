using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace Final_ConnectFour
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }

        public void ResetButton()
        {
            this.BackgroundImage = null;
        }

        public void PlaceRed()
        {
            this.BackgroundImage = Properties.Resources.red_piece;
        }

        public void PlaceYellow()
        {
            this.BackgroundImage = Properties.Resources.yellow_piece;
        }

        public void ChangeHoverColor(string option)
        {
            if (option == "Red")
            {
                this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(255, 122, 122);
            }
            else if (option == "Yellow")
            {
                this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(228, 246, 146);
            }
            else
            {
                this.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            }
        }
    }

}