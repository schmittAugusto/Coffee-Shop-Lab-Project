﻿using CoffeeShop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AddOrderForm
{
    public partial class AddOrderItemForm : Form
    {
        // create function that add one upandodnw to it 
        Order _order = new Order();
        IMenuItem publicMenuItem;

        //Augusto Schmitt 301245327
        public AddOrderItemForm(Order order) //add the parameter Order order)
        {
            InitializeComponent();
            MenuItemsList.Text = "Coffee";
            _order = order;
            dtpOrder.MinDate = DateTime.Now;
        }

        //Maksym Bezverkhnii 301287637
        private void AddOrderItemButton_Click(object sender, EventArgs e)
        {

            IMenuItem menuItem = CreateMenuItem(MenuItemsList.Text);
            NumericUpDown[] numerics = { MilkUpDown, SugarUpDown, SweetenerUpDown, LettuceUpDown, TomatoUpDown, CheeseUpDown, MayoUpDown };
            publicMenuItem = menuItem;

            foreach (NumericUpDown item in numerics)
            {
                if (item.Value != 0)
                {
                    menuItem = CreateItemWithAdditions(item , menuItem);
                    publicMenuItem = menuItem;
                }
            }
            TestDiaplay.Items.Add($"{menuItem.Description}");
            _order.AddOrderItem(menuItem);
            foreach(NumericUpDown item in numerics)
            {
                item.Value = 0;
            }
            DisplayTotalCost();
        }
        //Zakhar Hamarnyk 301250102
        private CoffeeShop.IMenuItem CreateItemWithAdditions(NumericUpDown numeric , IMenuItem item)
        {
            IMenuItem menuItem = item;
            for (int i = 0; i < numeric.Value; i++)
            {
                switch (numeric.Name)
                {
                    case "MilkUpDown":
                        menuItem = new Milk(menuItem);
                        break;
                    case "SugarUpDown":
                        menuItem = new Sugar(menuItem);
                        break;
                    case "SweetenerUpDown":
                        menuItem = new Sweetener(menuItem);
                        break;
                    case "LettuceUpDown":
                        menuItem = new Lettuce(menuItem);
                        break;
                    case "TomatoUpDown":
                        menuItem = new Tomato(menuItem);
                        break;
                    case "CheeseUpDown":
                        menuItem = new Cheese(menuItem);
                        break;
                    case "MayoUpDown":
                        menuItem = new Mayo(menuItem);
                        break;
                    default:
                        break;
                }
            }
            return menuItem;
        }
        //Maksym Bezverkhnii 301287637
        private CoffeeShop.IMenuItem CreateMenuItem(string orderItem)
        {
           IMenuItem menuItem = new Coffee();
            switch (orderItem)
            {
                case "Coffee":
                    menuItem = new Coffee();
                    gbx_drinkAddition.Visible = true;
                    gbx_mealAddition.Visible = false;
                    break;
                case "Coffee Dark Roast":
                    menuItem = new CoffeeDarkRoast();
                    gbx_drinkAddition.Visible = true;
                    gbx_mealAddition.Visible = false;
                    break;
                case "Tea":
                    menuItem = new Tea();
                    gbx_drinkAddition.Visible = true;
                    gbx_mealAddition.Visible = false;
                    break;
                case "Sandwich with Bacon":
                    menuItem = new SandwichWithBacon();
                    gbx_mealAddition.Visible =  true;
                    gbx_drinkAddition.Visible = false;
                    gbx_mealAddition.Location = gbx_drinkAddition.Location;
                    break;
                case "Sandwich with Roasted Beef":
                    menuItem = new SandwichWithRoastedBeef();
                    gbx_mealAddition.Location = gbx_drinkAddition.Location;
                    gbx_mealAddition.Visible = true;
                    gbx_drinkAddition.Visible = false;
                    break;
                case "Sandwich with Egg Salad":
                    menuItem = new SandwichWithEggSalad();
                    gbx_mealAddition.Location = gbx_drinkAddition.Location;
                    gbx_mealAddition.Visible = true;
                    gbx_drinkAddition.Visible = false;
                    break;
                default:
                    break;
                    
            }              

            return menuItem;
        }
        //Zakhar Hamarnyk 301250102
        private void MenuItemsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            IMenuItem menuItem = CreateMenuItem(MenuItemsList.Text);
            NumericUpDown[] numerics = { MilkUpDown, SugarUpDown, SweetenerUpDown, LettuceUpDown, TomatoUpDown, CheeseUpDown, MayoUpDown };
            UpdateOrderPicture(menuItem.Description);
            foreach (NumericUpDown item in numerics )
            {
                if (item.Value != 0)
                {
                    menuItem = CreateItemWithAdditions(item, menuItem);
                }
            }
            if (menuItem != null)
            {
                CostOrderItem.Text = menuItem.Description + menuItem.BaseCost;
                CostOrderItem.Text = $"Cost: {menuItem.BaseCost:C}";
                CostOrderItem.Visible = true;
            }
        }

        //Augusto Schmitt 301245327
        private void UpdateOrderPicture(string description)
        {
            pcbxMenuItems.Image = Image.FromFile(@"images\" + $"{description}" + ".jpg");
        }
        //Zakhar Hamarnyk 301250102
        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
        //Maksym Bezverkhnii 301287637
        private void TestDiaplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            OKButton.Enabled = _order.Items.Count > 0;
        }
        //Maksym Bezverkhnii 301287637
        private void OKButton_Click(object sender, EventArgs e)
        {
            //PUT HERE A REFERNCE TO ANOTHER FORM 
            //NewForm newForm = new NewForm();
            //newForm.ShowDialog();
            _order.DeliveryTime = dtpOrder.Value;
            if (_order.Items.Count == 0)
            {
                MessageBox.Show("Sorry, but you didn`t add any order, please try again");
            }
            else
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
            

        }
       
        //Zakhar Hamarnyk 301250102
        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            if (TestDiaplay.SelectedItems.Count > 0)
            {
                int index = TestDiaplay.SelectedIndex;
                decimal itemCost = _order.Items[index].Cost;
                _order.Items.RemoveAt(index);
                TestDiaplay.Items.RemoveAt(index);
                _order.Cost -= itemCost;
                DisplayTotalCost();
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
            

        }
        //Augusto Schmitt 301245327
        private void rdbtnDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnDelivery.Checked)
            {
                OKButton.Enabled = true;
                dtpOrder.Enabled = true;
                _order.IsDelivered = false;
                _order.OrderType = OrderType.PhoneOrder;
            }
        }
        //Augusto Schmitt 301245327
        private void rdbtnRestaurant_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbtnRestaurant.Checked)
            {
                OKButton.Enabled = true;
                dtpOrder.Enabled = true;
                _order.IsDelivered = false;
                _order.OrderType = OrderType.RestaurantOrder;
            }       
        }
        //Augusto Schmitt 301245327
        private void DisplayTotalCost()
        {
            lbl_totalCost.Text = $"CAD {_order.Cost:C}";
        }
    }
}
