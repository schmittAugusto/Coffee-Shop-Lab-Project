using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using CoffeeShop;

namespace CustomerForm
{
    public partial class Form1 : Form
    {
        //string[] validProvinces = { "ON", "QC", "BC", "AB", "MB", "SK", "NS", "NB", "NL", "PE", "NT", "NU", "YT" };

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void okBttn_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            Address address = new Address();

            int formVerify = 0;
            int nameVerify = 0;

            // Customer - fname, lname, tele, phone
            if (fnameTxtBox.Text.Length == 0 || fnameTxtBox.Text == null)
            {
                nameVerify++;
                formVerify++;
                MessageBox.Show("Please enter a valid first name.");
            }
            if (lnameTxtBox.Text.Length == 0 || lnameTxtBox.Text == null)
            {
                nameVerify++;
                MessageBox.Show("Please enter a valid last name.");
            }
            if (nameVerify == 0) 
            {
                customer.Name = $"{fnameTxtBox.Text} {lnameTxtBox.Text}";
            }
            try
            {
                uint phoneNumber = uint.Parse(telephoneNumberTxtBox.Text);
            }
            catch (FormatException)
            {
                formVerify++;
                MessageBox.Show("Please enter a valid phone number.");
            }

            // Address - street, city, province, postalcode
            // If one of the address field is manipulated, others cant be null
            int addressVerify = 0;
            if (streetTxtBox.Text.Length == 0 || streetTxtBox.Text == null)
            {
                addressVerify++;
                MessageBox.Show("Please enter a valid street address.");
            }
            else
            {
                address.Street = streetTxtBox.Text;
            }
            if (cityTxtBox.Text.Length == 0 || cityTxtBox.Text == null)
            {
                addressVerify++;
                MessageBox.Show("Please enter a valid street address.");
            }
            else
            {
                address.City = cityTxtBox.Text;
            }
            if (provinceComboBox.SelectedItem != null)
            {
                address.Province = provinceComboBox.SelectedItem.ToString();
            }
            else
            {
                addressVerify++;
                MessageBox.Show("Province cannot be empty.");
            }
            if (postalCodeTxtBox.Text.Length > 6)
            {
                addressVerify++;
                MessageBox.Show("Invalid postal code entered.");
            }
            else
            {
                address.PostalCode = postalCodeTxtBox.Text;
            }
            
            // Verify
            if (addressVerify > 1)
            {
                formVerify++;
                if (addressVerify >= 4)
                {
                    formVerify--;
                }
            }
            if (formVerify == 0)
            {
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void cancelBttn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fnameTxtBox_Enter(object sender, EventArgs e)
        {
            if (fnameTxtBox.Text == "*Required*")
            {
                fnameTxtBox.Text = "";
            }
        }

        private void fnameTxtBox_Leave(object sender, EventArgs e)
        {
            if (fnameTxtBox.Text.Length == 0 || fnameTxtBox.Text == null)
            {
                fnameTxtBox.Text = "*Required*";
            }
        }

        private void lnameTxtBox_Enter(object sender, EventArgs e)
        {
            if (lnameTxtBox.Text == "*Required*")
            {
                lnameTxtBox.Text = "";
            }
        }

        private void lnameTxtBox_Leave(object sender, EventArgs e)
        {
            if (lnameTxtBox.Text.Length == 0 || lnameTxtBox.Text == null)
            {
                lnameTxtBox.Text = "*Required*";
            }
        }

        private void telephoneNumberTxtBox_Enter(object sender, EventArgs e)
        {
            if (telephoneNumberTxtBox.Text == "*Required*")
            {
                telephoneNumberTxtBox.Text = "";
            }
        }

        private void telephoneNumberTxtBox_Leave(object sender, EventArgs e)
        {
            if (telephoneNumberTxtBox.Text.Length == 0 || telephoneNumberTxtBox.Text == null)
            {
                telephoneNumberTxtBox.Text = "*Required*";
            }
        }

        private void postalCodeTxtBox_Enter(object sender, EventArgs e)
        {
            if (postalCodeTxtBox.Text == "*No Spaces*")
            {
                postalCodeTxtBox.Text = "";
            }
        }

        private void postalCodeTxtBox_Leave(object sender, EventArgs e)
        {
            if (postalCodeTxtBox.Text.Length == 0 || postalCodeTxtBox.Text == null)
            {
                postalCodeTxtBox.Text = "*No Spaces*";
            }
        }

        private void addressTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephoneNumberTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fnameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cityTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void postalCodeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void telephoneNumberTxtBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void telephoneNumberTxtBox_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}
