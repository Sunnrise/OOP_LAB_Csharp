namespace HangMan
{
    partial class GameForm
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
            this.wordLabel = new System.Windows.Forms.Label();
            this.clueLabel = new System.Windows.Forms.Label();
            this.pointsLabel = new System.Windows.Forms.Label();
            this.letterTextBox = new System.Windows.Forms.TextBox();
            this.EndGameButton = new System.Windows.Forms.Button();
            this.hangmanPictureBox = new System.Windows.Forms.PictureBox();
            this.GuessButton = new System.Windows.Forms.Button();
            this.incorrectWordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.BackColor = System.Drawing.Color.Transparent;
            this.wordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wordLabel.Location = new System.Drawing.Point(34, 162);
            this.wordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(87, 31);
            this.wordLabel.TabIndex = 0;
            this.wordLabel.Text = "guess";
            // 
            // clueLabel
            // 
            this.clueLabel.AutoSize = true;
            this.clueLabel.BackColor = System.Drawing.Color.Transparent;
            this.clueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clueLabel.Location = new System.Drawing.Point(34, 280);
            this.clueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clueLabel.Name = "clueLabel";
            this.clueLabel.Size = new System.Drawing.Size(64, 31);
            this.clueLabel.TabIndex = 1;
            this.clueLabel.Text = "clue";
            // 
            // pointsLabel
            // 
            this.pointsLabel.AutoSize = true;
            this.pointsLabel.BackColor = System.Drawing.Color.Transparent;
            this.pointsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pointsLabel.Location = new System.Drawing.Point(34, 218);
            this.pointsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pointsLabel.Name = "pointsLabel";
            this.pointsLabel.Size = new System.Drawing.Size(87, 31);
            this.pointsLabel.TabIndex = 1;
            this.pointsLabel.Text = "points";
            // 
            // letterTextBox
            // 
            this.letterTextBox.Location = new System.Drawing.Point(51, 459);
            this.letterTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.letterTextBox.Name = "letterTextBox";
            this.letterTextBox.Size = new System.Drawing.Size(132, 22);
            this.letterTextBox.TabIndex = 2;
            // 
            // EndGameButton
            // 
            this.EndGameButton.Location = new System.Drawing.Point(867, 410);
            this.EndGameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EndGameButton.Name = "EndGameButton";
            this.EndGameButton.Size = new System.Drawing.Size(100, 28);
            this.EndGameButton.TabIndex = 3;
            this.EndGameButton.Text = "End Game";
            this.EndGameButton.UseVisualStyleBackColor = true;
            this.EndGameButton.Click += new System.EventHandler(this.EndGameButton_Click_1);
            // 
            // hangmanPictureBox
            // 
            this.hangmanPictureBox.Location = new System.Drawing.Point(355, 52);
            this.hangmanPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hangmanPictureBox.Name = "hangmanPictureBox";
            this.hangmanPictureBox.Size = new System.Drawing.Size(612, 351);
            this.hangmanPictureBox.TabIndex = 4;
            this.hangmanPictureBox.TabStop = false;
            // 
            // GuessButton
            // 
            this.GuessButton.Location = new System.Drawing.Point(51, 489);
            this.GuessButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GuessButton.Name = "GuessButton";
            this.GuessButton.Size = new System.Drawing.Size(100, 28);
            this.GuessButton.TabIndex = 5;
            this.GuessButton.Text = "guess";
            this.GuessButton.UseVisualStyleBackColor = true;
            // 
            // incorrectWordLabel
            // 
            this.incorrectWordLabel.AutoSize = true;
            this.incorrectWordLabel.BackColor = System.Drawing.Color.Transparent;
            this.incorrectWordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.incorrectWordLabel.Location = new System.Drawing.Point(34, 323);
            this.incorrectWordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incorrectWordLabel.Name = "incorrectWordLabel";
            this.incorrectWordLabel.Size = new System.Drawing.Size(171, 31);
            this.incorrectWordLabel.TabIndex = 1;
            this.incorrectWordLabel.Text = "incorret word";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.GuessButton);
            this.Controls.Add(this.hangmanPictureBox);
            this.Controls.Add(this.EndGameButton);
            this.Controls.Add(this.letterTextBox);
            this.Controls.Add(this.pointsLabel);
            this.Controls.Add(this.incorrectWordLabel);
            this.Controls.Add(this.clueLabel);
            this.Controls.Add(this.wordLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hangmanPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wordLabel;
        private System.Windows.Forms.Label clueLabel;
        private System.Windows.Forms.Label pointsLabel;
        private System.Windows.Forms.TextBox letterTextBox;
        private System.Windows.Forms.Button EndGameButton;
        private System.Windows.Forms.PictureBox hangmanPictureBox;
        private System.Windows.Forms.Button GuessButton;
        private System.Windows.Forms.Label incorrectWordLabel;
    }
}