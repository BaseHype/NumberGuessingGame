using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows.Storage.Streams;

namespace NumberGuessingGame
{
    public partial class Main : Form
    {
        Random rand = new Random();
        int maxRange = 0;
        int winningNumber = 0;
        int numOfAttempts = 0;
        bool hasWon = false;

        int[] highScores = new [] {0,0,0,0,0,0,0,0,0,0};
        static string folderDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GuessRoulette");
        static string saveFile = Path.Combine(folderDirectory, "save.txt");

        public Main()
        {
            InitializeComponent();

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
            maxRange = (int)nudLevel.Value * 10;
            lblGuess.Text = $"Guess(0-{maxRange}):";

            // get our winning number
            winningNumber = rand.Next(0, maxRange);

            // set focus on the geuss textbox
            txtGuess.Focus();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            int guessNumber;

            //verify if user guess input is valid
            if (VerifyGuessFormat(out guessNumber))
            {
                // check the users attempt and provide feedback
                CheckUserAttempt(guessNumber);
            }
            else
                MessageBox.Show("Please enter the correct format, when guessing the winning number.");

            if (hasWon)
            {
                // clear guess textbox and disable hte play button
                txtGuess.Clear();
                btnPlay.Enabled = false;
            }
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // clear outputs
            rtbOut.Clear();

            // reset UI components to start condition
            nudLevel.Enabled = true;
            btnLevelSelect.Enabled = true;
            cbxSelected.Checked = false;

            lblGuess.Text = "Guess: ";
            txtGuess.Clear();
            btnPlay.Enabled = true;
            lblAttempts.Text = "";

            // reset variables
            hasWon = false;
            numOfAttempts = 0;
        }

        /********************  User-Defined Functions  ********************/
        private bool VerifyGuessFormat(out int guess)
        {
            if (!string.IsNullOrEmpty(txtGuess.Text.Trim()))
            {
                return int.TryParse(txtGuess.Text.Trim(), out guess);
            }
            else
            {
                guess = 0;
                return false;
            }
        }

        private void CheckUserAttempt(int guessAttempt)
        {
            // add upper and lower bounds to help the user guess
            int upperBoundGuess = winningNumber + (maxRange / 100 * 10);
            int lowerBoundGuess = winningNumber - (maxRange / 100 * 10);

            // increment attempts amd display
            numOfAttempts += 1;
            lblAttempts.Text = numOfAttempts.ToString();

            // determine whether the guess is correct or not
            if (guessAttempt > maxRange | guessAttempt < 0)
                rtbOut.Text += "Out of bounds! Keep your guessed within the range\n";
            else if (guessAttempt > upperBoundGuess)
                rtbOut.Text += "Too high! Try guessing lower...\n";
            else if (guessAttempt > winningNumber)
                rtbOut.Text += "A bit high! Try guessing lower...\n";
            else if (guessAttempt < winningNumber)
                rtbOut.Text += "A bit low! Try guessing higher...\n";
            else if (guessAttempt < lowerBoundGuess)
                rtbOut.Text += "Too low! Try guessing higher...\n";
            else
            {
                hasWon = true;
                rtbOut.Text += $"\nCongratulations! You got the winning number in {numOfAttempts} attempts!\n";
            }
        }

        private void DisplayHighscoreBoard()
        {
            rtbScores.Clear();

            // show the current high scores
            rtbScores.Text = $"{this.Text} Highscore Board\n";
            rtbScores.Text += "Difficulty Level\t\tScore\n";
            rtbScores.Text += "------------------------------------\n";

            // display the highscores within the richtextbox scores
            for (int i = 1; i <= highScores.Length; i++)
            {
                string levelFormat = $"Level {i}:";
                if (highScores[i - 1] != 0)
                    rtbScores.Text += $"{levelFormat.PadRight(45)} {highScores[i - 1]}\n";
                else rtbScores.Text += $"{levelFormat.PadRight(45)} -\n";
            }
        }

        private void ReadHighScoreFile()
        {
            using (StreamReader reader = new StreamReader(saveFile))
            {
                string? line;
                int count = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    int index = line.IndexOf(':');

                    if (index != -1)
                        highScores[count] = int.Parse(line.Substring(index + 2, line.Length - index + 2));

                    count++;
                }
            }
        }

        private void WriteHighScoreFile()
        {
            using (StreamWriter writer = new StreamWriter(saveFile))
            {
                writer.WriteLine("Guess Roulette High Scores");

                for (int i = 0; i < highScores.Length; i++)
                    writer.WriteLine($"Level {i+1}: {highScores[i]}");
            }
        }
    }
}
