using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ooplabwweek2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkBox1.Checked = true; // Checkbox checked by default
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                {
                    
                    button1.Text = "Generate and Calculate";
                }
                else
                {
                    button1.Text = "Generate";
                    label2.Text = "Average: ";

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {



            int n;
            if (!int.TryParse(textBox1.Text, out n) || n < 1)
            {
                MessageBox.Show("Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            long[] fibNumbers = new long[n];

            if (n > 1)
            { 
                fibNumbers[0] = 1;
            fibNumbers[1] = 1;
        }
            else
                fibNumbers[0] = 1;

                for (int i = 2; i < n; i++)
                {
                    fibNumbers[i] = fibNumbers[i - 1] + fibNumbers[i - 2];
                }

                string fibSeriesText = string.Join(Environment.NewLine, fibNumbers);
            double average = fibNumbers.Average();
            if (checkBox1.Checked)
                label2.Text = $"Average: {average:F2}";

            textBox2.Text = fibSeriesText;




        }

        private void label2_Click(object sender, EventArgs e)
        {
            ;

        }
    }
}
