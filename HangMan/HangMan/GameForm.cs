using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HangMan
{
    public partial class GameForm : Form
    {
        private readonly string[] words = { "phonee", "computerr", "keyboardd", "chairr", "tablee" };
        private string wordToGuess;
        private List<char> guessedLetters = new List<char>();
        private int points = 100; // Starting points
        private readonly Random random = new Random();

        public GameForm()
        {
            InitializeComponent();
            InitializeGame();
            GuessButton.Click += GuessButton_Click;
            this.BackgroundImage = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\cover2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            hangmanPictureBox.Visible = false;

        }


        private void InitializeGame()
        {
            wordToGuess = words[random.Next(words.Length)];
            wordLabel.Text = DisplayWordToGuess(); // Call DisplayWordToGuess() without any arguments
            clueLabel.Text = GetClue(wordToGuess);
            pointsLabel.Text = "Points: " + points;
            incorrectWordLabel.Text = "Wrong Chars: ";
        }


        private string DisplayWordToGuess() // Remove char parameter
        {
            string displayWord = "";
            foreach (char letter in wordToGuess)
            {
                if (guessedLetters.Contains(char.ToUpper(letter))) // Convert letter to uppercase for comparison
                    displayWord += letter + " ";
                else
                {
                    displayWord += "_ ";
                    

                }
                   


            }
            return displayWord;
        }


        private string GetClue(string word)
        {
            // Add clues for each word here
            switch (word)
            {
                case "phonee":
                    return $"It is used to communicate. Words Length is: {word.Length} ";
                case "computerr":
                    return $"It processes data.Words Length is: {word.Length}";
                case "keyboardd":
                    return $"It's an input device.Words Length is: {word.Length}";
                case "chairr":
                    return $"You sit on it.Words Length is: {word.Length}";
                case "tablee":
                    return $"You eat on it.Words Length is: {word.Length}";
                default:
                    return "";
            }
        }

        private void CheckLetter(char letter)
        {
            letter = char.ToUpper(letter); // Convert guessed letter to uppercase

            if (!char.IsLetter(letter))
            {
                MessageBox.Show("Please enter a valid letter!", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!guessedLetters.Contains(letter))
            {
                guessedLetters.Add(letter);
                if (!wordToGuess.ToUpper().Contains(letter)) // Convert word to uppercase for comparison
                {
                    points -= 10;
                    pointsLabel.Text = "Points: " + points;
                    UpdateHangmanImage();
                    incorrectWordLabel.Text += letter+ "";
                }
                wordLabel.Text = DisplayWordToGuess();
                if (wordLabel.Text.Replace(" ", "") == wordToGuess)
                {
                    MessageBox.Show("Congratulations! You've won!", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BackColor = Color.LightGreen;
                    this.Close();
                }
                else if (points == 0)
                {
                    MessageBox.Show("You've lost! The word was: " + wordToGuess, "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.BackColor=Color.Red;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You've already guessed this letter!", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void UpdateHangmanImage()
        {
            hangmanPictureBox.Visible = true;

            switch (points)
            {
                case 90:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-01.jpg");
                    hangmanPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    break;
                case 80:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-02.jpg");
                    break;
                case 70:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-03.jpg");
                    break;
                case 60:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-04.jpg");
                    break;
                case 50:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-05.jpg");
                    break;
                case 40:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-06.jpg");
                    break;
                case 30:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-07.jpg");
                    break;
                case 20:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-08.jpg");
                    break;
                case 10:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-09.jpg");
                    break;
                case 0:
                    hangmanPictureBox.Image = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\man-10.jpg");
                    MessageBox.Show("You've lost! The word was: " + wordToGuess, "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    break;
            }

        }

        private void GuessButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(letterTextBox.Text) && letterTextBox.Text.Length == 1)
            {
                char guessedLetter = letterTextBox.Text[0];
                CheckLetter(guessedLetter);
            }
            else
            {
                MessageBox.Show("Please enter a valid letter!", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            letterTextBox.Clear();
        }

        private void EndGameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are leaving the game.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            this.Close();
        }
    





    private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void EndGameButton_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the game?", "Hangman", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You are leaving the game.", "Hangman", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }

        }
    }
}
