using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShop;

namespace Lab_9
{
    public partial class CsFrom : Form
    {
        public Customer _customer;
        public CsFrom()
        {
            InitializeComponent();
            this.Text = "New Customer";
            _customer = new Customer();
        }
        public CsFrom(Customer customer)
        {
            InitializeComponent();
            this.Text = customer.Name.ToString();
            _customer = customer;
            txt_name.Text = customer.Name;
            txt_phoneNum.Text = Convert.ToString(customer.Phone);
            txt_address_street.Text = Convert.ToString(customer.Address.Street);
            txt_address_city.Text = Convert.ToString(customer.Address.City);
            txt_address_province.Text = Convert.ToString(customer.Address.Province);
            txt_address_postalCode.Text = Convert.ToString(customer.Address.PostalCode);
            btn_addNewCustomer.Text = "Save";

        }
        /* 301261086 Yi-Chen, Hsu */
        private void btn_addNewCustomer_Click(object sender, EventArgs e)
        {
            _customer.Name = txt_name.Text;
            _customer.Phone = Convert.ToUInt32(this.txt_phoneNum.Text);
            _customer.Address = new Address(txt_address_street.Text, txt_address_city.Text, txt_address_province.Text, txt_address_postalCode.Text);
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
