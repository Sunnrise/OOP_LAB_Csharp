using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class MainForm : Form
    {
        private GameForm form1;
        private GameForm form2;

        public MainForm()
        {
            InitializeComponent();
            InitializeMainForm();
        }

        private void InitializeMainForm()
        {
            Button startGameButton = new Button();
            startGameButton.Text = "Start Game";
            startGameButton.Location = new Point(50, 50);
            startGameButton.Click += StartGameButton_Click;
            Controls.Add(startGameButton);
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            form1 = new GameForm();
            form2 = new GameForm();
            form1.FormClosed += GameFormClosed;
            form2.FormClosed += GameFormClosed;
            form1.Show();
            form2.Show();
        }

        private void GameFormClosed(object sender, FormClosedEventArgs e)
        {
            if (form1.IsDisposed && form2.IsDisposed)
            {
                CalculateScores();
            }
        }

        private void CalculateScores()
        {
            int actual1 = form1.GetActualCount();
            int guess1 = form1.GetUserGuess();
            int error1 = Math.Abs(actual1 - guess1);

            int actual2 = form2.GetActualCount();
            int guess2 = form2.GetUserGuess();
            int error2 = Math.Abs(actual2 - guess2);

            string winner = error1 < error2 ? "User 1" : "User 2";
            if (error1 == error2)
            {
                winner = "It's a tie!";
            }

            MessageBox.Show($"User 1 Error: {error1}\nUser 2 Error: {error2}\nWinner: {winner}");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
