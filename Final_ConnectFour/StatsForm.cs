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

        public StatsForm()
        {
            InitializeComponent();
        }

        public StatsForm(WelcomeForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void StatsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
