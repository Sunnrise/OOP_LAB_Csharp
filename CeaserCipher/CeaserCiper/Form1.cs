using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CeaserCiper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ceaserTextBox.Visible = false;
            headChipherCode.Text = "";
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string password = passwordTextBox.Text;
            string encryptedMessage;
            bool success;

            if (rot2RadioButton.Checked)
            {
                Encipher(password, 2, out success, out encryptedMessage);
            }
            else if (ceaserCipherRadioButton.Checked)
            {
                int shiftAmount;
                if (int.TryParse(ceaserTextBox.Text, out shiftAmount))
                {
                    Encipher(password, shiftAmount, out success, out encryptedMessage);
                }
                else if (ceaserTextBox.Text == "")
                {
                    Encipher(password, 1, out success, out encryptedMessage);
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer for Caesar Cipher shift amount.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please select a cipher option.");
                return;
            }

            if (success)
            {
                successLabel.Text = "Success";
                successLabel.BackColor = System.Drawing.Color.Green;
                cipherLabel.Text = "CIPHER: " + encryptedMessage;
            }
            else
            {
                successLabel.Text = "Encryption failed";
                successLabel.BackColor = System.Drawing.Color.Red;
                cipherLabel.Text = "Cipher: N/A";
            }
        }

        private void ceaserCipherRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            ceaserTextBox.Visible = ceaserCipherRadioButton.Checked;
            headChipherCode.Text = "CHIPER CODE";
        }

        private void Encipher(string input, int shift, out bool success, out string encryptedMessage)
        {
            success = true;
            encryptedMessage = "";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    if (char.IsUpper(c))
                    {
                        char shifted = (char)(((c - 'A') + shift) % 26 + 'A');
                        encryptedMessage += shifted;
                    }
                    else
                    {
                        char shifted = (char)(((c - 'a') + shift) % 26 + 'a');
                        encryptedMessage += shifted;
                    }
                }
                else
                {
                    // If character is not a letter, leave it unchanged
                    encryptedMessage += c;
                }
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            // Replace entered characters with '*'
            passwordTextBox.PasswordChar = '*';
        }
        private void cipherLabel_Click(object sender, EventArgs e)
        {

        }

        private void ceaserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void successLabel_Click(object sender, EventArgs e)
        {

        }

        private void rot2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            headChipherCode.Text = "";
        }
    }



}
