using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class Main : Form
    {
        Random rand = new Random();
        int winningNumber = 0;
        int numOfAttempts = 0;

        public Main()
        {
            InitializeComponent();

            
            // show the current high scores
            rtbScores.Text = $"{this.Text} Highscore Board\n";
            rtbScores.Text += "Difficulty Level\t\tScore\n";
            rtbScores.Text += "------------------------------------\n";

            // display a welcome message and explaing the game
            rtbOut.Text = $"Welcome to {this.Text}\n";
            rtbOut.Text += "How to Play:\n";
            rtbOut.Text += " -User selects a level of difficulty between 1 and 10.\n";
            rtbOut.Text += " -Afterwards a winning number is generated and the user has to guess the winning number.\n";
            rtbOut.Text += " -When guessing the user will be prompted whether their guess is high or low\n";
            rtbOut.Text += " -The aim is to guess the winning number is the least amount of attempts\n";
            rtbOut.Text += "\nAll the best! Hope you enjoy the game!\n";
            
        }

        private void btnLevelSelect_Click(object sender, EventArgs e)
        {
            // clear the output box
            rtbOut.Clear();

            // disable level dial
            nudLevel.Enabled = false;

            // check the selected checkbox
            cbxSelected.Checked = true;

            // calculate guessing range and update label
            int maxRange = (int)nudLevel.Value * 10;
            lblGuess.Text = $"Guess(0-{maxRange}):";

            // get our winning number
            winningNumber = rand.Next(0, maxRange);

            // set focus on the geuss textbox
            txtGuess.Focus();
        }
    }
}
