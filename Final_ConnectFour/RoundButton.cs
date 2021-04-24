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

        public Cell GetCell(Board board)
        {
            string[] splitStr = this.Name.Split('_');
            return board.GetCell(int.Parse(splitStr[1]), int.Parse(splitStr[2]));
        }

        public void Reset()
        {
            this.BackgroundImage = null;
        }

        public void SetRed()
        {
            this.BackgroundImage = Properties.Resources.red_piece;
        }

        public void SetYellow()
        {
            this.BackgroundImage = Properties.Resources.yellow_piece;
        }

        public void ChangeHoverColor(string option)
        {
            switch (option)
            {
                case "Red":
                    this.BackgroundImage = Properties.Resources.red_piece_hover;
                    break;
                case "Yellow":
                    this.BackgroundImage = Properties.Resources.yellow_piece_hover;
                    break;
                default:
                    this.BackgroundImage = null;
                    break;
            }
        }
    }

}