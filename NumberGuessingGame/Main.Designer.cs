namespace NumberGuessingGame
{
    partial class Main
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
            label1 = new Label();
            nudLevel = new NumericUpDown();
            cbxSelected = new CheckBox();
            btnLevelSelect = new Button();
            lblGuess = new Label();
            txtGuess = new TextBox();
            btnPlay = new Button();
            rtbScores = new RichTextBox();
            label3 = new Label();
            lblAttempts = new Label();
            btnNewGame = new Button();
            btnSave = new Button();
            rtbOut = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)nudLevel).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 16);
            label1.TabIndex = 0;
            label1.Text = "Level:";
            // 
            // nudLevel
            // 
            nudLevel.BorderStyle = BorderStyle.FixedSingle;
            nudLevel.Location = new Point(100, 21);
            nudLevel.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudLevel.Name = "nudLevel";
            nudLevel.Size = new Size(55, 22);
            nudLevel.TabIndex = 1;
            nudLevel.TextAlign = HorizontalAlignment.Right;
            nudLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxSelected
            // 
            cbxSelected.AutoSize = true;
            cbxSelected.BackColor = SystemColors.Control;
            cbxSelected.Enabled = false;
            cbxSelected.Location = new Point(270, 25);
            cbxSelected.Name = "cbxSelected";
            cbxSelected.Size = new Size(15, 14);
            cbxSelected.TabIndex = 2;
            cbxSelected.UseVisualStyleBackColor = false;
            // 
            // btnLevelSelect
            // 
            btnLevelSelect.BackColor = Color.White;
            btnLevelSelect.FlatAppearance.BorderColor = Color.Gray;
            btnLevelSelect.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnLevelSelect.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnLevelSelect.FlatStyle = FlatStyle.Popup;
            btnLevelSelect.Location = new Point(180, 20);
            btnLevelSelect.Name = "btnLevelSelect";
            btnLevelSelect.Size = new Size(75, 25);
            btnLevelSelect.TabIndex = 3;
            btnLevelSelect.Text = "Select";
            btnLevelSelect.UseVisualStyleBackColor = false;
            btnLevelSelect.Click += btnLevelSelect_Click;
            // 
            // lblGuess
            // 
            lblGuess.AutoSize = true;
            lblGuess.Location = new Point(20, 60);
            lblGuess.Name = "lblGuess";
            lblGuess.Size = new Size(49, 16);
            lblGuess.TabIndex = 4;
            lblGuess.Text = "Guess:";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(100, 56);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(55, 22);
            txtGuess.TabIndex = 5;
            txtGuess.TextAlign = HorizontalAlignment.Center;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.White;
            btnPlay.FlatAppearance.BorderColor = Color.Gray;
            btnPlay.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPlay.FlatStyle = FlatStyle.Popup;
            btnPlay.Location = new Point(180, 55);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 25);
            btnPlay.TabIndex = 6;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // rtbScores
            // 
            rtbScores.BackColor = Color.White;
            rtbScores.BorderStyle = BorderStyle.FixedSingle;
            rtbScores.Location = new Point(15, 129);
            rtbScores.Name = "rtbScores";
            rtbScores.ReadOnly = true;
            rtbScores.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbScores.Size = new Size(300, 90);
            rtbScores.TabIndex = 8;
            rtbScores.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 100);
            label3.Name = "label3";
            label3.Size = new Size(62, 16);
            label3.TabIndex = 9;
            label3.Text = "Attempts:";
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(250, 100);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(0, 16);
            lblAttempts.TabIndex = 10;
            // 
            // btnNewGame
            // 
            btnNewGame.Location = new Point(20, 225);
            btnNewGame.Name = "btnNewGame";
            btnNewGame.Size = new Size(100, 30);
            btnNewGame.TabIndex = 11;
            btnNewGame.Text = "New Game";
            btnNewGame.UseVisualStyleBackColor = true;
            btnNewGame.Click += btnNewGame_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(126, 225);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 30);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // rtbOut
            // 
            rtbOut.BackColor = Color.White;
            rtbOut.BorderStyle = BorderStyle.FixedSingle;
            rtbOut.Location = new Point(320, 10);
            rtbOut.Name = "rtbOut";
            rtbOut.ReadOnly = true;
            rtbOut.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtbOut.Size = new Size(280, 245);
            rtbOut.TabIndex = 13;
            rtbOut.Text = "";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 266);
            Controls.Add(rtbOut);
            Controls.Add(btnSave);
            Controls.Add(btnNewGame);
            Controls.Add(lblAttempts);
            Controls.Add(label3);
            Controls.Add(rtbScores);
            Controls.Add(btnPlay);
            Controls.Add(txtGuess);
            Controls.Add(lblGuess);
            Controls.Add(btnLevelSelect);
            Controls.Add(cbxSelected);
            Controls.Add(nudLevel);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            MaximizeBox = false;
            Name = "Main";
            Text = "Guess Roulette";
            ((System.ComponentModel.ISupportInitialize)nudLevel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown nudLevel;
        private CheckBox cbxSelected;
        private Button btnLevelSelect;
        private Label lblGuess;
        private TextBox txtGuess;
        private Button btnPlay;
        private RichTextBox rtbScores;
        private Label label3;
        private Label lblAttempts;
        private Button btnNewGame;
        private Button btnSave;
        private RichTextBox rtbOut;
    }
}