using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCreateOrder_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter a username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus(); // Set focus back to the username TextBox
                return; // Exit the event handler
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("Please enter a phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus(); // Set focus back to the phone number TextBox
                return; // Exit the event handler
            }
            if (listBoxBrand.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a brand.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxBrand.Focus(); // Set focus back to the brand ListBox
                return; // Exit the event handler
            }
            if (listBoxCity.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a city.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxCity.Focus(); // Set focus back to the city ListBox
                return; // Exit the event handler
            }
            if (listBoxDistrict.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a district.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listBoxDistrict.Focus(); // Set focus back to the district ListBox
                return; // Exit the event handler
            }
            if (GetSelectedRadioButton(groupBox1) == null)
            {
                MessageBox.Show("Please select a size.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the event handler
            }
            // Kullanımı
            RadioButton selectedRadioButton= GetSelectedRadioButton(groupBox1);

            
            // Get user inputs
            string username = txtUsername.Text;
            string size = selectedRadioButton.Text;
            string phone = txtPhone.Text;
            string brand = listBoxBrand.SelectedItem.ToString();
            
            //string size = listBoxSize.SelectedItem.ToString(); // Changed from CheckBox to ListBox
            string city = listBoxCity.SelectedItem.ToString();
            string district = listBoxDistrict.SelectedItem.ToString();
            string order = $"{DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")} - {username}, {phone}, {brand} , Size: {size}, City: {city}, District: {district}";

            // Add order to ListBox
            listBoxOrders.Items.Add(order);

            string phoneNumber = txtPhone.Text;

            if (IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Valid phone number.");
            }
            else
            {
                MessageBox.Show("Invalid phone number. Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus(); // Set focus back to the phone number TextBox
                txtPhone.SelectAll(); // Select all text in the TextBox for easy correction
            }
            

            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Invalid phone number. Please enter a valid phone number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            label1.Text = order;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize ListBox items
            listBoxBrand.Items.AddRange(new string[] { "Adidas", "Nike", "Puma" });
             // Example shoe sizes
            listBoxCity.Items.AddRange(new string[] { "Eskişehir", "Ankara" });
            // Populate districts based on selected city
            PopulateDistricts("Eskişehir");
        }

        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Populate districts based on selected city
            string selectedCity = listBoxCity.SelectedItem.ToString();
            PopulateDistricts(selectedCity);
        }
        private void PopulateDistricts(string city)
        {
            listBoxDistrict.Items.Clear();
            if (city == "Eskişehir")
            {
                listBoxDistrict.Items.AddRange(new string[] { "Sivrihisar", "Odunpazarı", "Tepebaşı" });
            }
            else if (city == "Ankara")
            {
                listBoxDistrict.Items.AddRange(new string[] { "Mamak", "Çankaya", "Polatlı" });
            }
           
        }
        static bool IsValidPhoneNumber(string phoneNumber)
        {
            // Regex pattern to match common phone number formats
            string pattern = @"^(\+?90|0)?(\d{3})?(\d{3})(\d{2})(\d{2})$";
            // Adjust this pattern based on your requirements

            // Create a Regex object
            Regex regex = new Regex(pattern);

            // Use the IsMatch method to check if the phone number matches the pattern
            return regex.IsMatch(phoneNumber);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private RadioButton GetSelectedRadioButton(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton;
                }
            }
            return null; // Seçili bir radyo butonu bulunamazsa null döner
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtUsername_Click(object sender, EventArgs e)
        {
            txtUsername.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}