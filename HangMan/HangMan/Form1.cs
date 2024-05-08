using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HangMan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
            this.BackgroundImage = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\cover2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Startbutton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            gameForm.Show();
            this.Hide();
        }

       
    }
}
