using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace games.TicTacToeGame
{
    public partial class TicTacGame : Form
    {
        bool turn = true;
        string whichPlayer = "";
        bool thereIsAWinner = false;
        int counter = 0;
        public TicTacGame()
        {
            InitializeComponent();
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Mohamed Elfnagily", "Tic Tac Toe");
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            counter++;
            if (this.turn)
            {
                b.Text = "X";
                this.whichPlayer = "player 1";
            }
            else
            {
                b.Text = "O";
                this.whichPlayer = "player 2";
            }
            turn = !turn;
            b.Enabled = false;
            checkForWinner();
        }
        private void playAgainCheck()
        {
            DialogResult d = MessageBox.Show("Do you want to play again?", "Play again?", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                thereIsAWinner = false;
                whichPlayer = "";
                counter = 0;
                foreach (Control c in Controls)
                {
                    c.Enabled = true;
                    c.Text = "";
                    turn = true;
                }
            }
            else
            {
                Application.Exit();
            }
        }

        //This function is responsible for checking for the winner with each button press
        private void checkForWinner()
        {
            if((A1.Text == A2.Text) && (A2.Text == A3.Text)&& (!A1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
            {
                thereIsAWinner = true;
            }
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
            {
                thereIsAWinner = true;
            }
            if(thereIsAWinner)
            {
                
                MessageBox.Show($"{whichPlayer} is the winner :)");
                playAgainCheck();

            }
            else
            {
                if(counter==9)
                {
                    MessageBox.Show($"Equal game :( !");
                    playAgainCheck();
                }
            }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thereIsAWinner = false;
            whichPlayer = "";
            counter = 0;
            foreach (Control c in Controls)
            {
                c.Enabled = true;
                c.Text = "";
                turn = true;
            }
        }
    }
}
