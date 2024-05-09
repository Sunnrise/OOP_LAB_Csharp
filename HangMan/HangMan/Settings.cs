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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            radioButtonEasy.Checked = true;
            listBox1.SelectedIndex = 0;
            radioButtonClue.Checked = true;
            radioButtonNoTime.Checked = true;
            this.BackgroundImage = Image.FromFile("C:\\Users\\alper\\Documents\\vsstudio project\\HangMan\\HangMan\\Images\\cover2.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           GameForm gameForm = new GameForm();
            gameForm.Show();
            
        }
        

    }
}
