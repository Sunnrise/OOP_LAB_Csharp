using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_OOP_csharp
{
    public partial class Form1 : Form

    {
        DateTime time = DateTime.Now;
       
        

        Timer timer = new Timer();
        List<string> timeZoneList = new List<string>();
        public Form1()
        {
            InitializeComponent();

            // Initialize Timer
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            // Initialize textBoxTimeZone
            textBoxTimeZone = new TextBox();
            textBoxTimeZone.Text = "Enter new time zone";
            textBoxTimeZone.Click += (sender, e) => textBoxTimeZone.Text = "";
            textBoxTimeZone.Visible = true;
            textBoxTimeZone.Location = new Point(10, 100);
            textBoxTimeZone.Size = new Size(150, 20);
        
            this.Controls.Add(textBoxTimeZone); // Add textBoxTimeZone to the form's Controls collection
           
          
           
           

           
        }

        

        private void comboBoxTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Get the selected time zone from the ComboBox
            string selectedTimeZone = comboBoxTimeZones.SelectedItem.ToString();

            // Parse the selected time zone to a TimeSpan
            TimeSpan timeZoneOffset;
            if (TimeSpan.TryParse(selectedTimeZone, out timeZoneOffset))
            {
                // Get the current time
                DateTime currentTime = DateTime.Now;

                // Calculate the new time by adding the time zone offset to the current time
                DateTime newTime = currentTime.Add(timeZoneOffset);

                // Update the label to display the new time
                labelDigitalClock.Text = newTime.ToString("HH:mm:ss");
            }
            else
            {
                // Handle parsing error if needed
                labelDigitalClock.Text = "Invalid time zone format.";
            }


        }

        private void checkedListBoxTimeZones_SelectedIndexChanged(object sender, EventArgs e)
        {

           
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Add new time zone to CheckedListBox and ComboBox
            string newTimeZone = textBoxTimeZone.Text;
            if (!string.IsNullOrWhiteSpace(newTimeZone))
            {
                checkedListBoxTimeZones.Items.Add(newTimeZone);
                timeZoneList.Add(newTimeZone);
                UpdateComboBox();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            // Update selected time zone in CheckedListBox and ComboBox
            int selectedIndex = checkedListBoxTimeZones.SelectedIndex;
            if (selectedIndex != -1)
            {
                string updatedTimeZone = textBoxTimeZone.Text;
                if (!string.IsNullOrWhiteSpace(updatedTimeZone))
                {
                    checkedListBoxTimeZones.Items[selectedIndex] = updatedTimeZone;
                    timeZoneList[selectedIndex] = updatedTimeZone;
                    UpdateComboBox();
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Delete selected time zones from CheckedListBox and ComboBox
            while (checkedListBoxTimeZones.CheckedIndices.Count > 0)
            {
                int index = checkedListBoxTimeZones.CheckedIndices[0];
                checkedListBoxTimeZones.Items.RemoveAt(index);
                timeZoneList.RemoveAt(index);
                UpdateComboBox();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update digital clock display
            labelDigitalClock.Text = DateTime.Now.ToString("HH:mm:ss");
            // Change text color based on time

            if (DateTime.Now.Hour >= 8 && DateTime.Now.Hour < 20)
                labelDigitalClock.ForeColor = Color.FromName("Blue");
            else
                labelDigitalClock.ForeColor = Color.Black;
        }

        private void labelDigitalClock_Click(object sender, EventArgs e)
        {

        }
        private void UpdateComboBox()
        {
            comboBoxTimeZones.Items.Clear();

            comboBoxTimeZones.Items.AddRange(timeZoneList.ToArray());
        }

        private void labelDigitalClock_Click_1(object sender, EventArgs e)
        {

        }
    }
}
