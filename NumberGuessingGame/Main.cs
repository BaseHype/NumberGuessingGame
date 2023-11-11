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

        public Main()
        {
            InitializeComponent();
        }

        private void btnLevelSelect_Click(object sender, EventArgs e)
        {
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
