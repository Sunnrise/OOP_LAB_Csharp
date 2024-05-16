using OOP_ex07;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace OOP_ex07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listboxhistory.Visible = false;
        }


        private void btnhistory_Click(object sender, EventArgs e)
        {
            if (listboxhistory.Visible == false)
            {
                listboxhistory.Visible = true;
            }
            else
            {
                listboxhistory.Visible = false;
            }
        }

        private void btnLeftPhar_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "(";
        }

        private void btnRightPhar_Click(object sender, EventArgs e)
        {
            textboxinput.Text += ")";
        }

        private void btnpercent_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "%";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {

            if (textboxinput.Text.Length > 0)
            {
                // Son karakteri geçici değişkende sakla
                string lastChar = textboxinput.Text;

                // Son karakteri sil
                textboxinput.Text = textboxinput.Text = "";

                // Geçici değeri history listbox'ına ekle
                listboxhistory.Items.Add(lastChar);
            }


        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "9";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "/";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "6";
        }

        private void btnmultip_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "*";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "3";
        }

        private void btnsubstract_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "-";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "0";
        }

        private void btndot_Click(object sender, EventArgs e)
        {
            textboxinput.Text += ".";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "+";
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "sin(";
        }

        private void btnln_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "ln(";
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "cos(";
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "log(";
        }

        private void btntan_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "tan(";
        }

        private void btnroot_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "sqrt(";
        }

        private void btntenoverx_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "10^(";
        }

        private void btnexp_Click(object sender, EventArgs e)
        {

        }

        private void btnInv_Click(object sender, EventArgs e)
        {

        }

        private void btnpi_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "pi";
        }

        private void btnxovery_Click(object sender, EventArgs e)
        {
            textboxinput.Text += "()^()";
        }


        // İfadeyi değerlendiren fonksiyon
        private double Evaluate(string expression)
        {

            return Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            try
            {
                // Hesap ekranındaki ifadeyi hesapla
                string expression = textboxinput.Text;
                DataTable dataTable = new DataTable();
                var result = dataTable.Compute(expression, "");

                // Sonucu ekrana yazdır
                textboxinput.Text = result.ToString();
            }
            catch (SyntaxErrorException)
            {
                MessageBox.Show("Hatalı ifade!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCE_Click_1(object sender, EventArgs e)
        {
            if (textboxinput.Text.Length > 0)
            {
                string temp = textboxinput.Text;
                textboxinput.Text = "";
                listboxhistory.Items.Add(temp);

            }
        }

        private void listboxhistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listboxhistory.Items.Add(textboxinput.Text);
            textboxinput.Text = listboxhistory.SelectedItem.ToString();
        }

        private void btnmultip_Click_1(object sender, EventArgs e)
        {
            textboxinput.Text += "*";
        }

        private void btndiv_Click_1(object sender, EventArgs e)
        {
            textboxinput.Text += "/";
        }
    }
}    
  
            

        
    


