using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class GameForm : Form
    {
        private PictureBox pictureBox;
        private TextBox inputTextBox;
        private Timer symbolTimer;
        private int actualCount;
        private Random random;
        private Font symbolFont;

        public GameForm()
        {
            InitializeComponent();
            InitializeGameForm();
        }

        private void InitializeGameForm()
        {
            random = new Random();

            // Initialize PictureBox
            pictureBox = new PictureBox();
            pictureBox.Size = new Size(300, 300);
            pictureBox.Location = new Point(50, 50);
            pictureBox.BackColor = Color.Gray;
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(pictureBox);

            // Add a label for the TextBox
            Label inputLabel = new Label();
            inputLabel.Text = "Enter your guess:";
            inputLabel.Location = new Point(10, 400);
            Controls.Add(inputLabel);

            // Initialize TextBox
            inputTextBox = new TextBox();
            inputTextBox.Location = new Point(10, 420);
            Controls.Add(inputTextBox);

            // Initialize Timer
            symbolTimer = new Timer();
            symbolTimer.Interval = 5000; // 5 seconds
            symbolTimer.Tick += SymbolTimer_Tick;
            symbolTimer.Start();

            // Initialize Font
            symbolFont = new Font("Arial", 24, FontStyle.Bold);

            // Display symbols
            DisplaySymbols();
        }

        private void DisplaySymbols()
        {
            string symbol = "*";
            actualCount = random.Next(1, 10);

            pictureBox.Paint += (sender, e) =>
            {
                e.Graphics.Clear(pictureBox.BackColor); // Clear previous drawings

                for (int i = 0; i < actualCount; i++)
                {
                    int x = random.Next(0, pictureBox.Width - 40); // Adjust for symbol size
                    int y = random.Next(0, pictureBox.Height - 40); // Adjust for symbol size
                    e.Graphics.DrawString(symbol, symbolFont, Brushes.Black, new PointF(x, y));
                }
            };
            pictureBox.Invalidate(); // Force redraw to show the symbols
        }

        private void SymbolTimer_Tick(object sender, EventArgs e)
        {
            pictureBox.Paint += (s, pe) =>
            {
                pe.Graphics.Clear(pictureBox.BackColor);
            };
            pictureBox.Invalidate(); // Force redraw to clear symbols
            symbolTimer.Stop();
        }

        public int GetActualCount()
        {
            return actualCount;
        }

        public int GetUserGuess()
        {
            return int.Parse(inputTextBox.Text);
        }
    }
}
