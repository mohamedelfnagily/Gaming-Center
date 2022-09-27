using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Timer and width setting, 
        //width will be increased by 5 till reaching main form width
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.loadingPanel.Width += 5;
            if(this.loadingPanel.Width >= 500)
            {
                this.timer1.Stop();
                mainPage mainGamingPage = new mainPage();
                mainGamingPage.Show();
                this.Hide();
            }
        }

    }
}
