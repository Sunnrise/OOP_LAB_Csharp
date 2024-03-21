using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculate
{
    public partial class Calculation : Form
    {
        public Calculation()
        {
            InitializeComponent();
            Addition.MouseEnter += buttonOperation_MouseEnter;
            Addition.MouseLeave += buttonOperation_MouseLeave;
            Substaction.MouseEnter += buttonOperation_MouseEnter;
            Substaction.MouseLeave += buttonOperation_MouseLeave;
            Multiplication.MouseEnter += buttonOperation_MouseEnter;
            Multiplication.MouseLeave += buttonOperation_MouseLeave;
            Division.MouseEnter += buttonOperation_MouseEnter;
            Division.MouseLeave += buttonOperation_MouseLeave;
            textBox1.Click += textBox1_Enter;
            textBox2.Click += textBox2_Enter;


        }

        private void CalculateResult(string operation)
        {
            try
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);
                double result = 0;

                switch (operation)
                {
                    case "Addition":
                        result = num1 + num2;
                        break;
                    case "Subtraction":
                        result = num1 - num2;
                        break;
                    case "Multiplication":
                        result = num1 * num2;
                        break;
                    case "Division":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            MessageBox.Show("Cannot divide by zero!");
                        break;
                }

                label1.Text = result.ToString();
                label1.BackColor = result > 0 ? Color.Green : Color.Red;
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input. Please enter valid numbers.");
            }
        }



        private void buttonOperation_MouseEnter(object sender, EventArgs e)
        {
            
            ((Button)sender).BackColor = Color.White; // Arka plan rengini değiştirir
            ((Button)sender).ForeColor = Color.Red; // Metin rengini değiştirir
        }

        private void buttonOperation_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).ForeColor = SystemColors.ControlText;
           

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "First Number")
            {
                textBox1.Text = "";
                textBox1.ForeColor = SystemColors.ControlText; // Varsayılan metin rengi
            }
        }
        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Second Number")
            {
                textBox2.Text = "";
                textBox2.ForeColor = SystemColors.ControlText; // Varsayılan metin rengi
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                textBox1.Text = "Enter your name";
                textBox1.ForeColor = SystemColors.GrayText; // Gri renkli metin
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateResult("Addition");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CalculateResult("Subtraction");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalculateResult("Multiplication");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculateResult("Division");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
