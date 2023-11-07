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

namespace L9_3
{
    public partial class MainForm : Form
    {
        Dictionary<string, Customer> _data = new Dictionary<string, Customer>();
        CustomerRepository Repository { get; set; } = new CustomerRepository();
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }
        /* 301261086 Yi-Chen, Hsu */
        private void CheckAccount()
        {
            if (txt_account.Text == "Admin" && txt_passwd.Text == "1234")
            {
                if (MessageBox.Show("Welcome!") == DialogResult.OK)
                {
                    gbx_login.Enabled = false;
                    gbx_login.Visible = false;
                    gbx_customers_list.Visible = true;
                    panel_left.BackgroundImage = null;
                    fileToolStripMenuItem.Enabled = true;
                    fileToolStripMenuItem.Visible = true;
                }
            }
            else if (txt_account.Text != null && txt_passwd.Text != null)
            {
                MessageBox.Show("Invalid User Name or Password , please try again");
            }

        }
        /* 301261086 Yi-Chen, Hsu */
        private void btn_login_enter_Click(object sender, EventArgs e)
        {
            CheckAccount();
        }
        /* 301261086 Yi-Chen, Hsu */
        private void btn_login_enter_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckAccount();
        }
        /* 301261086 Yi-Chen, Hsu */
        private void txt_account_TextChanged(object sender, EventArgs e)
        {
            txt_passwd.Enabled = true;
            txt_passwd.UseSystemPasswordChar = true;
        }
        /* 301261086 Yi-Chen, Hsu */
        private void txt_passwd_TextChanged(object sender, EventArgs e)
        {
            btn_login_enter.Enabled = true;
        }
        /* 301261086 Yi-Chen, Hsu */
        private void uploadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName;
                Repository.Load(fileName);
                for (int i = 0; i < Repository.Customers.Count(); i++)
                {
                    _data.Add($"{Repository.Customers[i].IdNumber,5} {Repository.Customers[i].Name}", Repository.Customers[i]);
                    uploadToolStripMenuItem.Enabled = false;
                }
            }
            UpdateCustomerListDisplay();
        }
        /* 301261086 Yi-Chen, Hsu */
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Repository.Customers.Clear();
            foreach (KeyValuePair<string, Customer> data in _data)
            {
                Repository.Customers.Add(data.Value);
            }
            Repository.Save("Customers.json");
            uploadToolStripMenuItem.Enabled = true;
        }
        /* 301261086 Yi-Chen, Hsu */
        private void UpdateCustomerListDisplay()
        {
            lbx_customers.Items.Clear();
            foreach (string key in _data.Keys)
            {
                lbx_customers.Items.Add(key);
            }
        }
        /* 301261086 Yi-Chen, Hsu */
        private void UpdateCustomerInfoDisplay()
        {
            try
            {
                int index = lbx_customers.SelectedIndex;
                string key = lbx_customers.SelectedItem.ToString();
                int lastElementIndex = _data[key].Orders.Count - 1;
                btn_addOrder.Enabled = true;
                btn_addOrder.Visible = true;
                lbl_deliveryDate.BackColor = Color.Transparent;
                btn_edit_customer.Enabled = true;
                gbx_customers_info.Visible = true;
                lbl_orderItems_display.Text = "";
                lbl_totalCost_display.Text = "";
                gbx_customers_info.Text = _data[key].Name.ToString();
                lbl_phone_display.Text = _data[key].Phone.ToString();
                lbl_id_display.Text = _data[key].IdNumber.ToString();
                lbl_address_display.Text = _data[key].Address.ToString();
                lbl_numOrders_display.Text = _data[key].Orders.Count.ToString();
                if (lastElementIndex < 0)
                {
                    lastElementIndex = 0;
                    lbl_deliveryDate.Text = "No order yet.";
                }
                else
                {
                    lbl_deliveryDate.Text = _data[key].Orders[lastElementIndex].DeliveryTime.ToString("MMM-dd-yy HH:mm");   
                }
                if (_data[key].Orders[lastElementIndex].IsDelivered)
                {
                    lbl_deliveryDate.BackColor = Color.Green;
                }
                else
                {
                    lbl_deliveryDate.BackColor = Color.Yellow;
                }
                foreach (OrderItem item in _data[key].Orders[lastElementIndex].Items)
                {
                    lbl_orderItems_display.Text += $"{item} \n";
                }
                lbl_totalCost_display.Text = $"{_data[key].Orders[lastElementIndex].Cost:c}";
                lbx_customers.SelectedItem = lbx_customers.Items[index];
            }
            catch(NullReferenceException)
            {

            }
            catch(ArgumentOutOfRangeException)
            {

            }
            PendingOrdersDisplay();

        }
        /* 301261086 Yi-Chen, Hsu */
        private void lbx_customers_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateCustomerInfoDisplay();                
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please select the customer.");
            }
            catch (ArgumentOutOfRangeException)
            {
            }
        }
        /* 301261086 Yi-Chen, Hsu */
        private void lbx_customers_DisplayMemberChanged(object sender, EventArgs e)
        {
            UpdateCustomerInfoDisplay();
        }
        /* 301261086 Yi-Chen, Hsu */
        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            CustomerForm.CustomerForm customerForm = new CustomerForm.CustomerForm();
            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                _data.Add($"{customerForm._customer.IdNumber,5} {customerForm._customer.Name}", customerForm._customer);
                UpdateCustomerListDisplay();
            }
        }
        /* 301261086 Yi-Chen, Hsu */
        private void btn_edit_customer_Click(object sender, EventArgs e)
        {
            string key = lbx_customers.SelectedItem.ToString();
            int index = lbx_customers.SelectedIndex;
            CustomerForm.CustomerForm customerForm = new CustomerForm.CustomerForm(_data[key]);
            Customer updateCustomer = _data[key];
            if (customerForm.ShowDialog() == DialogResult.OK)
            {
                updateCustomer.Phone = customerForm._customer.Phone;
                updateCustomer.Address = customerForm._customer.Address;
                UpdateCustomerListDisplay();
            }
            try
            {
                lbx_customers.SelectedItem = lbx_customers.Items[index];
            }
            catch (IndexOutOfRangeException)
            {
                
            }
            UpdateCustomerInfoDisplay();
        }
        //Augusto Schmitt 301245327
        private void btn_addOrder_Click(object sender, EventArgs e)
        {
            Order newOrder = new Order();
            string key = lbx_customers.SelectedItem.ToString();
            newOrder.Customer = _data[key];
            AddOrderForm.AddOrderItemForm orderForm = new AddOrderForm.AddOrderItemForm(newOrder);
            if (orderForm.ShowDialog() == DialogResult.OK)
            {
                _data[key].Orders.Add(newOrder);
                UpdateCustomerInfoDisplay();
            }
        }
        //Zakhar Hamarnyk 301250102
        private void PendingOrdersDisplay()
        {
            lbx_pendingOrders.Items.Clear();
            if (_data != null)
            {
                gbx_pendingOrders.Enabled = true;
                gbx_pendingOrders.Visible = true;
                foreach (KeyValuePair<string, Customer> data in _data)
                {
                    for (int i = 0; i < data.Value.Orders.Count; i++)
                    {
                        Order anOrder = data.Value.Orders[i];
                        if (!anOrder.IsDelivered && anOrder.DeliveryTime >= DateTime.Today)
                            lbx_pendingOrders.Items.Add($"{anOrder.OrderId}:{anOrder.Customer.Name}, {anOrder.DeliveryTime.ToString("MMM-dd")}");
                    }
                }
            }
            btn_completedOrder.Visible = true;
        }
        //Maksym Bezverkhnii 301287637
        private void btn_completedOrder_Click(object sender, EventArgs e)
        {
            string key = lbx_customers.SelectedItem.ToString();
            int lastElementIndex = _data[key].Orders.Count - 1;
            _data[key].Orders[lastElementIndex].Deliver();
            UpdateCustomerInfoDisplay();
        }
    }
}
