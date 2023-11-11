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
            numericUpDown1 = new NumericUpDown();
            cbxSelected = new CheckBox();
            btnLevelSelect = new Button();
            label2 = new Label();
            textBox1 = new TextBox();
            btnPlay = new Button();
            rtbOut = new RichTextBox();
            label3 = new Label();
            lblAttempts = new Label();
            btnNewGame = new Button();
            btnSave = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 25);
            label1.Name = "label1";
            label1.Size = new Size(40, 14);
            label1.TabIndex = 0;
            label1.Text = "Level:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.BorderStyle = BorderStyle.FixedSingle;
            numericUpDown1.Location = new Point(100, 21);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(50, 22);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TextAlign = HorizontalAlignment.Right;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbxSelected
            // 
            cbxSelected.AutoSize = true;
            cbxSelected.BackColor = Color.White;
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
            btnLevelSelect.Location = new Point(180, 20);
            btnLevelSelect.Name = "btnLevelSelect";
            btnLevelSelect.Size = new Size(75, 25);
            btnLevelSelect.TabIndex = 3;
            btnLevelSelect.Text = "Select";
            btnLevelSelect.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 60);
            label2.Name = "label2";
            label2.Size = new Size(44, 14);
            label2.TabIndex = 4;
            label2.Text = "Guess:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(100, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(55, 22);
            textBox1.TabIndex = 5;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.White;
            btnPlay.FlatAppearance.BorderColor = Color.Gray;
            btnPlay.FlatAppearance.MouseDownBackColor = Color.LightGreen;
            btnPlay.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btnPlay.Location = new Point(180, 55);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 25);
            btnPlay.TabIndex = 6;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            // 
            // rtbOut
            // 
            rtbOut.BorderStyle = BorderStyle.FixedSingle;
            rtbOut.Location = new Point(15, 129);
            rtbOut.Name = "rtbOut";
            rtbOut.Size = new Size(300, 90);
            rtbOut.TabIndex = 8;
            rtbOut.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 100);
            label3.Name = "label3";
            label3.Size = new Size(63, 14);
            label3.TabIndex = 9;
            label3.Text = "Attempts:";
            // 
            // lblAttempts
            // 
            lblAttempts.AutoSize = true;
            lblAttempts.Location = new Point(250, 100);
            lblAttempts.Name = "lblAttempts";
            lblAttempts.Size = new Size(0, 14);
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
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Location = new Point(320, 10);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(280, 209);
            richTextBox1.TabIndex = 13;
            richTextBox1.Text = "";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 266);
            Controls.Add(richTextBox1);
            Controls.Add(btnSave);
            Controls.Add(btnNewGame);
            Controls.Add(lblAttempts);
            Controls.Add(label3);
            Controls.Add(rtbOut);
            Controls.Add(btnPlay);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(btnLevelSelect);
            Controls.Add(cbxSelected);
            Controls.Add(numericUpDown1);
            Controls.Add(label1);
            Font = new Font("HP Simplified Hans", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Main";
            Text = "Guess Roulette";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown numericUpDown1;
        private CheckBox cbxSelected;
        private Button btnLevelSelect;
        private Label label2;
        private TextBox textBox1;
        private Button btnPlay;
        private RichTextBox rtbOut;
        private Label label3;
        private Label lblAttempts;
        private Button btnNewGame;
        private Button btnSave;
        private RichTextBox richTextBox1;
    }
}