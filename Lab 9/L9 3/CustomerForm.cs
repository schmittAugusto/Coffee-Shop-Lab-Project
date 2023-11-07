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
    public partial class CustomerForm : Form
    {
        public Customer _customer;

        public CustomerForm()
        {
            _customer = new Customer();
            InitializeComponent();
            provinceComboBox.SelectedItem = "ON";
        }
        /* 301261086 Yi-Chen, Hsu */
        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            try
            {
                this.Text = customer.Name.ToString();
                fnameTxtBox.Text = customer.Name.Split(' ')[0];
                lnameTxtBox.Text = customer.Name.Split(' ')[1];
                telephoneNumberTxtBox.Text = Convert.ToString(customer.Phone);
                streetTxtBox.Text = Convert.ToString(customer.Address.Street);
                cityTxtBox.Text = Convert.ToString(customer.Address.City);
                provinceComboBox.SelectedItem = customer.Address.Province;
                postalCodeTxtBox.Text = Convert.ToString(customer.Address.PostalCode);
                okBttn.Text = "Save";
            }
            catch(IndexOutOfRangeException)
            {
                fnameTxtBox.Text = customer.Name;
            }
            fnameTxtBox.Enabled = false;
            lnameTxtBox.Enabled = false;

        }
        // 301139479 Markhill Rodulf Robles
        private void okBttn_Click(object sender, EventArgs e)
        {
            Address address = new Address();

            int formVerify = 0;
            int nameVerify = 0;

            // Warning Message
            string context = "Please fill the following fields";
            string message = "";
            string addressMessage = "";
            string addressOneMessage = "";

            // Customer - fname, lname, tele, phone
            if (fnameTxtBox.Text.Length == 0 || fnameTxtBox.Text == null || fnameTxtBox.Text == "*Required*")
            {
                nameVerify++;
                formVerify++;
                message += "First Name\n";
            }
            if (lnameTxtBox.Text.Length == 0 || lnameTxtBox.Text == null || lnameTxtBox.Text == "*Required*")
            {
                nameVerify++;
                formVerify++;
                message += "Last Name\n";
            }
            if (nameVerify == 0)
            {
                _customer.Name = $"{fnameTxtBox.Text} {lnameTxtBox.Text}";
            }
            if (ulong.TryParse(telephoneNumberTxtBox.Text, out ulong phoneNumber))
            {
                _customer.Phone = phoneNumber;
            }
            else
            {
                formVerify++;
                message += "Telephone Number\n";
            }
            int addressVerify = 0;
            if (streetTxtBox.Text.Length == 0 || streetTxtBox.Text == null)
            {
                addressVerify++;
                addressMessage += "Street\n";
            }
            else
            {
                address.Street = streetTxtBox.Text;
            }

            if (cityTxtBox.Text.Length == 0 || cityTxtBox.Text == null)
            {
                addressVerify++;
                addressMessage += "City\n";
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
                addressMessage += "Province\n";
            }

            //if (postalCodeTxtBox.Text.Length != 6)
            //{
            //    if (postalCodeTxtBox.Text.Length == 7 && !postalCodeTxtBox.Text.Contains(" "))
            //    {
            //        addressVerify++;
            //        if (postalCodeTxtBox.Text != "*No Spaces*")
            //        {
            //            addressVerify++;
            //        }
            //    }
            //    addressMessage += "Postal Code\n";
            //}
            //else
            //{
            //    address.PostalCode = postalCodeTxtBox.Text.ToUpper().Insert(3, " ");
            //}
            if (postalCodeTxtBox.Text.Length == 6 && !postalCodeTxtBox.Text.Contains(" "))
            {
                address.PostalCode = postalCodeTxtBox.Text.ToUpper().Insert(3, " ");
            }
            else if (postalCodeTxtBox.Text.Length == 7 && postalCodeTxtBox.Text.Contains(" "))
            {
                address.PostalCode = postalCodeTxtBox.Text.ToUpper().Replace(" ", "");
                address.PostalCode = address.PostalCode.Insert(3, " ");
            }
            else
            {
                addressVerify++;
                if (postalCodeTxtBox.Text == "*No Spaces*")
                {
                    addressVerify++;
                }
                addressMessage += "Postal Code\n";
            }


            // Verify
            if (addressVerify > 0)
            {
                formVerify++;
                if (addressVerify == 4)
                {
                    formVerify--;
                }
                else
                {
                    addressOneMessage = addressMessage;
                }
            }
            if (formVerify != 0)
            {
                MessageBox.Show(message + addressOneMessage, context, MessageBoxButtons.OK);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                _customer.Address = address;
                Close();
            }
        }
        // 301139479 Markhill Rodulf Robles
        private void cancelBttn_Click(object sender, EventArgs e)
        {
            Close();
        }
        // 301139479 Markhill Rodulf Robles
        private void fnameTxtBox_Enter(object sender, EventArgs e)
        {
            if (fnameTxtBox.Text == "*Required*")
            {
                fnameTxtBox.Text = "";
            }
        }
        // 301139479 Markhill Rodulf Robles
        private void fnameTxtBox_Leave(object sender, EventArgs e)
        {
            if (fnameTxtBox.Text.Length == 0 || fnameTxtBox.Text == null)
            {
                fnameTxtBox.Text = "*Required*";
            }
        }
        // 301139479 Markhill Rodulf Robles
        private void lnameTxtBox_Enter(object sender, EventArgs e)
        {
            if (lnameTxtBox.Text == "*Required*")
            {
                lnameTxtBox.Text = "";
            }
        }
        // 301139479 Markhill Rodulf Robles
        private void lnameTxtBox_Leave(object sender, EventArgs e)
        {
            if (lnameTxtBox.Text.Length == 0 || lnameTxtBox.Text == null)
            {
                lnameTxtBox.Text = "*Required*";
            }
        }
        // 301139479 Markhill Rodulf Robles
        private void telephoneNumberTxtBox_Enter(object sender, EventArgs e)
        {
            if (telephoneNumberTxtBox.Text == "*Required*")
            {
                telephoneNumberTxtBox.Text = "";
            }
        }
        // 301139479 Markhill Rodulf Robles
        private void telephoneNumberTxtBox_Leave(object sender, EventArgs e)
        {
            if (telephoneNumberTxtBox.Text.Length == 0 || telephoneNumberTxtBox.Text == null)
            {
                telephoneNumberTxtBox.Text = "*Required*";
            }
        }
        // 301139479 Markhill Rodulf Robles
        private void postalCodeTxtBox_Enter(object sender, EventArgs e)
        {
            if (postalCodeTxtBox.Text == "*No Spaces*")
            {
                postalCodeTxtBox.Text = "";
            }
        }
        // 301139479 Markhill Rodulf Robles
        private void postalCodeTxtBox_Leave(object sender, EventArgs e)
        {
            if (postalCodeTxtBox.Text.Length == 0 || postalCodeTxtBox.Text == null)
            {
                postalCodeTxtBox.Text = "*No Spaces*";
            }
        }
    }
}
