namespace AddOrderForm
{
    partial class AddOrderItemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MilkUpDown = new System.Windows.Forms.NumericUpDown();
            this.MilkAddition = new System.Windows.Forms.Label();
            this.SugarAddition = new System.Windows.Forms.Label();
            this.SweetenerAddition = new System.Windows.Forms.Label();
            this.SweetenerUpDown = new System.Windows.Forms.NumericUpDown();
            this.SugarUpDown = new System.Windows.Forms.NumericUpDown();
            this.LettuceAddition = new System.Windows.Forms.Label();
            this.LettuceUpDown = new System.Windows.Forms.NumericUpDown();
            this.TomatoAddition = new System.Windows.Forms.Label();
            this.TomatoUpDown = new System.Windows.Forms.NumericUpDown();
            this.CheeseAddition = new System.Windows.Forms.Label();
            this.CheeseUpDown = new System.Windows.Forms.NumericUpDown();
            this.MayoAddition = new System.Windows.Forms.Label();
            this.MayoUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddOrderItemButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MenuItemsList = new System.Windows.Forms.ListBox();
            this.CostOrderItem = new System.Windows.Forms.GroupBox();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.TestDiaplay = new System.Windows.Forms.ListBox();
            this.gbx_drinkAddition = new System.Windows.Forms.GroupBox();
            this.lblAdditions = new System.Windows.Forms.Label();
            this.gbx_mealAddition = new System.Windows.Forms.GroupBox();
            this.lblAdditions2 = new System.Windows.Forms.Label();
            this.rdbtnDelivery = new System.Windows.Forms.RadioButton();
            this.gpbxRadioDelivery = new System.Windows.Forms.GroupBox();
            this.rdbtnRestaurant = new System.Windows.Forms.RadioButton();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.lblMenuItems = new System.Windows.Forms.Label();
            this.lblCurrentOrder = new System.Windows.Forms.Label();
            this.pcbxMenuItems = new System.Windows.Forms.PictureBox();
            this.gbx_totalCost = new System.Windows.Forms.GroupBox();
            this.lbl_totalCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MilkUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SweetenerUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SugarUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LettuceUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomatoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheeseUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MayoUpDown)).BeginInit();
            this.gbx_drinkAddition.SuspendLayout();
            this.gbx_mealAddition.SuspendLayout();
            this.gpbxRadioDelivery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMenuItems)).BeginInit();
            this.gbx_totalCost.SuspendLayout();
            this.SuspendLayout();
            // 
            // MilkUpDown
            // 
            this.MilkUpDown.BackColor = System.Drawing.Color.LavenderBlush;
            this.MilkUpDown.Location = new System.Drawing.Point(39, 54);
            this.MilkUpDown.Name = "MilkUpDown";
            this.MilkUpDown.Size = new System.Drawing.Size(35, 20);
            this.MilkUpDown.TabIndex = 2;
            this.MilkUpDown.ValueChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // MilkAddition
            // 
            this.MilkAddition.AutoSize = true;
            this.MilkAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.MilkAddition.Location = new System.Drawing.Point(11, 56);
            this.MilkAddition.Name = "MilkAddition";
            this.MilkAddition.Size = new System.Drawing.Size(26, 13);
            this.MilkAddition.TabIndex = 3;
            this.MilkAddition.Text = "Milk";
            // 
            // SugarAddition
            // 
            this.SugarAddition.AutoSize = true;
            this.SugarAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.SugarAddition.Location = new System.Drawing.Point(113, 32);
            this.SugarAddition.Name = "SugarAddition";
            this.SugarAddition.Size = new System.Drawing.Size(35, 13);
            this.SugarAddition.TabIndex = 4;
            this.SugarAddition.Text = "Sugar";
            // 
            // SweetenerAddition
            // 
            this.SweetenerAddition.AutoSize = true;
            this.SweetenerAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.SweetenerAddition.Location = new System.Drawing.Point(90, 56);
            this.SweetenerAddition.Name = "SweetenerAddition";
            this.SweetenerAddition.Size = new System.Drawing.Size(58, 13);
            this.SweetenerAddition.TabIndex = 6;
            this.SweetenerAddition.Text = "Sweetener";
            // 
            // SweetenerUpDown
            // 
            this.SweetenerUpDown.BackColor = System.Drawing.Color.LavenderBlush;
            this.SweetenerUpDown.ForeColor = System.Drawing.Color.Black;
            this.SweetenerUpDown.Location = new System.Drawing.Point(154, 54);
            this.SweetenerUpDown.Name = "SweetenerUpDown";
            this.SweetenerUpDown.Size = new System.Drawing.Size(35, 20);
            this.SweetenerUpDown.TabIndex = 7;
            this.SweetenerUpDown.ValueChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // SugarUpDown
            // 
            this.SugarUpDown.BackColor = System.Drawing.Color.LavenderBlush;
            this.SugarUpDown.Location = new System.Drawing.Point(154, 27);
            this.SugarUpDown.Name = "SugarUpDown";
            this.SugarUpDown.Size = new System.Drawing.Size(35, 20);
            this.SugarUpDown.TabIndex = 8;
            this.SugarUpDown.ValueChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // LettuceAddition
            // 
            this.LettuceAddition.AutoSize = true;
            this.LettuceAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.LettuceAddition.Location = new System.Drawing.Point(10, 32);
            this.LettuceAddition.Name = "LettuceAddition";
            this.LettuceAddition.Size = new System.Drawing.Size(43, 13);
            this.LettuceAddition.TabIndex = 9;
            this.LettuceAddition.Text = "Lettuce";
            // 
            // LettuceUpDown
            // 
            this.LettuceUpDown.BackColor = System.Drawing.Color.LavenderBlush;
            this.LettuceUpDown.Location = new System.Drawing.Point(55, 29);
            this.LettuceUpDown.Name = "LettuceUpDown";
            this.LettuceUpDown.Size = new System.Drawing.Size(36, 20);
            this.LettuceUpDown.TabIndex = 10;
            this.LettuceUpDown.ValueChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // TomatoAddition
            // 
            this.TomatoAddition.AutoSize = true;
            this.TomatoAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.TomatoAddition.Location = new System.Drawing.Point(10, 65);
            this.TomatoAddition.Name = "TomatoAddition";
            this.TomatoAddition.Size = new System.Drawing.Size(43, 13);
            this.TomatoAddition.TabIndex = 11;
            this.TomatoAddition.Text = "Tomato";
            // 
            // TomatoUpDown
            // 
            this.TomatoUpDown.BackColor = System.Drawing.Color.LavenderBlush;
            this.TomatoUpDown.Location = new System.Drawing.Point(55, 62);
            this.TomatoUpDown.Name = "TomatoUpDown";
            this.TomatoUpDown.Size = new System.Drawing.Size(36, 20);
            this.TomatoUpDown.TabIndex = 12;
            this.TomatoUpDown.ValueChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // CheeseAddition
            // 
            this.CheeseAddition.AutoSize = true;
            this.CheeseAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.CheeseAddition.Location = new System.Drawing.Point(101, 32);
            this.CheeseAddition.Name = "CheeseAddition";
            this.CheeseAddition.Size = new System.Drawing.Size(43, 13);
            this.CheeseAddition.TabIndex = 13;
            this.CheeseAddition.Text = "Cheese";
            this.CheeseAddition.VisibleChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // CheeseUpDown
            // 
            this.CheeseUpDown.BackColor = System.Drawing.Color.LavenderBlush;
            this.CheeseUpDown.Location = new System.Drawing.Point(148, 30);
            this.CheeseUpDown.Name = "CheeseUpDown";
            this.CheeseUpDown.Size = new System.Drawing.Size(36, 20);
            this.CheeseUpDown.TabIndex = 14;
            this.CheeseUpDown.ValueChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // MayoAddition
            // 
            this.MayoAddition.AutoSize = true;
            this.MayoAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.MayoAddition.Location = new System.Drawing.Point(110, 65);
            this.MayoAddition.Name = "MayoAddition";
            this.MayoAddition.Size = new System.Drawing.Size(33, 13);
            this.MayoAddition.TabIndex = 15;
            this.MayoAddition.Text = "Mayo";
            // 
            // MayoUpDown
            // 
            this.MayoUpDown.BackColor = System.Drawing.Color.LavenderBlush;
            this.MayoUpDown.Location = new System.Drawing.Point(148, 62);
            this.MayoUpDown.Name = "MayoUpDown";
            this.MayoUpDown.Size = new System.Drawing.Size(36, 20);
            this.MayoUpDown.TabIndex = 16;
            this.MayoUpDown.ValueChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // AddOrderItemButton
            // 
            this.AddOrderItemButton.BackColor = System.Drawing.Color.Maroon;
            this.AddOrderItemButton.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.AddOrderItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderItemButton.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrderItemButton.ForeColor = System.Drawing.SystemColors.Control;
            this.AddOrderItemButton.Location = new System.Drawing.Point(354, 437);
            this.AddOrderItemButton.Name = "AddOrderItemButton";
            this.AddOrderItemButton.Size = new System.Drawing.Size(132, 53);
            this.AddOrderItemButton.TabIndex = 18;
            this.AddOrderItemButton.Text = "Add Item";
            this.AddOrderItemButton.UseVisualStyleBackColor = false;
            this.AddOrderItemButton.Click += new System.EventHandler(this.AddOrderItemButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.BackColor = System.Drawing.Color.Maroon;
            this.OKButton.Enabled = false;
            this.OKButton.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.OKButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OKButton.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.OKButton.Location = new System.Drawing.Point(492, 437);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(132, 53);
            this.OKButton.TabIndex = 20;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(633, 437);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(132, 53);
            this.CancelButton.TabIndex = 21;
            this.CancelButton.Text = "Cancel ";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MenuItemsList
            // 
            this.MenuItemsList.BackColor = System.Drawing.Color.LavenderBlush;
            this.MenuItemsList.FormattingEnabled = true;
            this.MenuItemsList.Items.AddRange(new object[] {
            "Coffee",
            "Coffee Dark Roast",
            "Tea",
            "Sandwich with Bacon",
            "Sandwich with Roasted Beef",
            "Sandwich with Egg Salad"});
            this.MenuItemsList.Location = new System.Drawing.Point(35, 69);
            this.MenuItemsList.Name = "MenuItemsList";
            this.MenuItemsList.Size = new System.Drawing.Size(213, 134);
            this.MenuItemsList.TabIndex = 22;
            this.MenuItemsList.SelectedIndexChanged += new System.EventHandler(this.MenuItemsList_SelectedIndexChanged);
            // 
            // CostOrderItem
            // 
            this.CostOrderItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.CostOrderItem.Location = new System.Drawing.Point(327, 252);
            this.CostOrderItem.Name = "CostOrderItem";
            this.CostOrderItem.Size = new System.Drawing.Size(58, 52);
            this.CostOrderItem.TabIndex = 25;
            this.CostOrderItem.TabStop = false;
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.BackColor = System.Drawing.Color.Sienna;
            this.DeleteOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.LavenderBlush;
            this.DeleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrderButton.Font = new System.Drawing.Font("Leelawadee", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderButton.ForeColor = System.Drawing.Color.White;
            this.DeleteOrderButton.Location = new System.Drawing.Point(713, 243);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteOrderButton.TabIndex = 26;
            this.DeleteOrderButton.Text = "Delete Item";
            this.DeleteOrderButton.UseVisualStyleBackColor = false;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // TestDiaplay
            // 
            this.TestDiaplay.BackColor = System.Drawing.Color.LavenderBlush;
            this.TestDiaplay.FormattingEnabled = true;
            this.TestDiaplay.Location = new System.Drawing.Point(327, 69);
            this.TestDiaplay.Name = "TestDiaplay";
            this.TestDiaplay.Size = new System.Drawing.Size(461, 160);
            this.TestDiaplay.TabIndex = 27;
            // 
            // gbx_drinkAddition
            // 
            this.gbx_drinkAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbx_drinkAddition.Controls.Add(this.lblAdditions);
            this.gbx_drinkAddition.Controls.Add(this.SugarAddition);
            this.gbx_drinkAddition.Controls.Add(this.MilkUpDown);
            this.gbx_drinkAddition.Controls.Add(this.MilkAddition);
            this.gbx_drinkAddition.Controls.Add(this.SweetenerAddition);
            this.gbx_drinkAddition.Controls.Add(this.SweetenerUpDown);
            this.gbx_drinkAddition.Controls.Add(this.SugarUpDown);
            this.gbx_drinkAddition.Location = new System.Drawing.Point(35, 371);
            this.gbx_drinkAddition.Margin = new System.Windows.Forms.Padding(0);
            this.gbx_drinkAddition.Name = "gbx_drinkAddition";
            this.gbx_drinkAddition.Padding = new System.Windows.Forms.Padding(0);
            this.gbx_drinkAddition.Size = new System.Drawing.Size(213, 79);
            this.gbx_drinkAddition.TabIndex = 29;
            this.gbx_drinkAddition.TabStop = false;
            this.gbx_drinkAddition.Visible = false;
            // 
            // lblAdditions
            // 
            this.lblAdditions.AutoSize = true;
            this.lblAdditions.Location = new System.Drawing.Point(6, 9);
            this.lblAdditions.Name = "lblAdditions";
            this.lblAdditions.Size = new System.Drawing.Size(53, 13);
            this.lblAdditions.TabIndex = 9;
            this.lblAdditions.Text = "Additions:";
            // 
            // gbx_mealAddition
            // 
            this.gbx_mealAddition.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbx_mealAddition.Controls.Add(this.lblAdditions2);
            this.gbx_mealAddition.Controls.Add(this.TomatoAddition);
            this.gbx_mealAddition.Controls.Add(this.LettuceAddition);
            this.gbx_mealAddition.Controls.Add(this.LettuceUpDown);
            this.gbx_mealAddition.Controls.Add(this.TomatoUpDown);
            this.gbx_mealAddition.Controls.Add(this.CheeseAddition);
            this.gbx_mealAddition.Controls.Add(this.CheeseUpDown);
            this.gbx_mealAddition.Controls.Add(this.MayoAddition);
            this.gbx_mealAddition.Controls.Add(this.MayoUpDown);
            this.gbx_mealAddition.Location = new System.Drawing.Point(36, 456);
            this.gbx_mealAddition.Name = "gbx_mealAddition";
            this.gbx_mealAddition.Size = new System.Drawing.Size(212, 90);
            this.gbx_mealAddition.TabIndex = 30;
            this.gbx_mealAddition.TabStop = false;
            this.gbx_mealAddition.Visible = false;
            // 
            // lblAdditions2
            // 
            this.lblAdditions2.AutoSize = true;
            this.lblAdditions2.Location = new System.Drawing.Point(6, 9);
            this.lblAdditions2.Name = "lblAdditions2";
            this.lblAdditions2.Size = new System.Drawing.Size(53, 13);
            this.lblAdditions2.TabIndex = 39;
            this.lblAdditions2.Text = "Additions:";
            // 
            // rdbtnDelivery
            // 
            this.rdbtnDelivery.AutoSize = true;
            this.rdbtnDelivery.Location = new System.Drawing.Point(6, 10);
            this.rdbtnDelivery.Name = "rdbtnDelivery";
            this.rdbtnDelivery.Size = new System.Drawing.Size(63, 17);
            this.rdbtnDelivery.TabIndex = 31;
            this.rdbtnDelivery.TabStop = true;
            this.rdbtnDelivery.Text = "Delivery";
            this.rdbtnDelivery.UseVisualStyleBackColor = true;
            this.rdbtnDelivery.CheckedChanged += new System.EventHandler(this.rdbtnDelivery_CheckedChanged);
            // 
            // gpbxRadioDelivery
            // 
            this.gpbxRadioDelivery.Controls.Add(this.rdbtnRestaurant);
            this.gpbxRadioDelivery.Controls.Add(this.rdbtnDelivery);
            this.gpbxRadioDelivery.Location = new System.Drawing.Point(492, 358);
            this.gpbxRadioDelivery.Name = "gpbxRadioDelivery";
            this.gpbxRadioDelivery.Size = new System.Drawing.Size(212, 31);
            this.gpbxRadioDelivery.TabIndex = 33;
            this.gpbxRadioDelivery.TabStop = false;
            // 
            // rdbtnRestaurant
            // 
            this.rdbtnRestaurant.AutoSize = true;
            this.rdbtnRestaurant.Location = new System.Drawing.Point(106, 10);
            this.rdbtnRestaurant.Name = "rdbtnRestaurant";
            this.rdbtnRestaurant.Size = new System.Drawing.Size(77, 17);
            this.rdbtnRestaurant.TabIndex = 32;
            this.rdbtnRestaurant.TabStop = true;
            this.rdbtnRestaurant.Text = "Restaurant";
            this.rdbtnRestaurant.UseVisualStyleBackColor = true;
            this.rdbtnRestaurant.CheckedChanged += new System.EventHandler(this.rdbtnRestaurant_CheckedChanged);
            // 
            // dtpOrder
            // 
            this.dtpOrder.CalendarMonthBackground = System.Drawing.Color.LavenderBlush;
            this.dtpOrder.CalendarTitleBackColor = System.Drawing.Color.LavenderBlush;
            this.dtpOrder.Enabled = false;
            this.dtpOrder.Location = new System.Drawing.Point(492, 408);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(212, 20);
            this.dtpOrder.TabIndex = 34;
            // 
            // lblMenuItems
            // 
            this.lblMenuItems.AutoSize = true;
            this.lblMenuItems.Location = new System.Drawing.Point(35, 52);
            this.lblMenuItems.Name = "lblMenuItems";
            this.lblMenuItems.Size = new System.Drawing.Size(65, 13);
            this.lblMenuItems.TabIndex = 36;
            this.lblMenuItems.Text = "Menu Items:";
            // 
            // lblCurrentOrder
            // 
            this.lblCurrentOrder.AutoSize = true;
            this.lblCurrentOrder.Location = new System.Drawing.Point(327, 51);
            this.lblCurrentOrder.Name = "lblCurrentOrder";
            this.lblCurrentOrder.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentOrder.TabIndex = 37;
            this.lblCurrentOrder.Text = "Current Order:";
            // 
            // pcbxMenuItems
            // 
            this.pcbxMenuItems.Location = new System.Drawing.Point(34, 209);
            this.pcbxMenuItems.Name = "pcbxMenuItems";
            this.pcbxMenuItems.Size = new System.Drawing.Size(214, 156);
            this.pcbxMenuItems.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbxMenuItems.TabIndex = 35;
            this.pcbxMenuItems.TabStop = false;
            // 
            // gbx_totalCost
            // 
            this.gbx_totalCost.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbx_totalCost.Controls.Add(this.lbl_totalCost);
            this.gbx_totalCost.Location = new System.Drawing.Point(354, 369);
            this.gbx_totalCost.Name = "gbx_totalCost";
            this.gbx_totalCost.Size = new System.Drawing.Size(111, 52);
            this.gbx_totalCost.TabIndex = 26;
            this.gbx_totalCost.TabStop = false;
            this.gbx_totalCost.Text = "Total Cost";
            // 
            // lbl_totalCost
            // 
            this.lbl_totalCost.AutoSize = true;
            this.lbl_totalCost.Location = new System.Drawing.Point(7, 20);
            this.lbl_totalCost.Name = "lbl_totalCost";
            this.lbl_totalCost.Size = new System.Drawing.Size(35, 13);
            this.lbl_totalCost.TabIndex = 0;
            this.lbl_totalCost.Text = "CAD$";
            // 
            // AddOrderItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(800, 551);
            this.Controls.Add(this.gbx_totalCost);
            this.Controls.Add(this.lblCurrentOrder);
            this.Controls.Add(this.lblMenuItems);
            this.Controls.Add(this.pcbxMenuItems);
            this.Controls.Add(this.dtpOrder);
            this.Controls.Add(this.gpbxRadioDelivery);
            this.Controls.Add(this.gbx_mealAddition);
            this.Controls.Add(this.gbx_drinkAddition);
            this.Controls.Add(this.TestDiaplay);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.CostOrderItem);
            this.Controls.Add(this.MenuItemsList);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.AddOrderItemButton);
            this.Name = "AddOrderItemForm";
            this.Text = "New Order";
            ((System.ComponentModel.ISupportInitialize)(this.MilkUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SweetenerUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SugarUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LettuceUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TomatoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheeseUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MayoUpDown)).EndInit();
            this.gbx_drinkAddition.ResumeLayout(false);
            this.gbx_drinkAddition.PerformLayout();
            this.gbx_mealAddition.ResumeLayout(false);
            this.gbx_mealAddition.PerformLayout();
            this.gpbxRadioDelivery.ResumeLayout(false);
            this.gpbxRadioDelivery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxMenuItems)).EndInit();
            this.gbx_totalCost.ResumeLayout(false);
            this.gbx_totalCost.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown MilkUpDown;
        private System.Windows.Forms.Label MilkAddition;
        private System.Windows.Forms.Label SugarAddition;
        private System.Windows.Forms.Label SweetenerAddition;
        private System.Windows.Forms.NumericUpDown SweetenerUpDown;
        private System.Windows.Forms.NumericUpDown SugarUpDown;
        private System.Windows.Forms.Label LettuceAddition;
        private System.Windows.Forms.NumericUpDown LettuceUpDown;
        private System.Windows.Forms.Label TomatoAddition;
        private System.Windows.Forms.NumericUpDown TomatoUpDown;
        private System.Windows.Forms.Label CheeseAddition;
        private System.Windows.Forms.NumericUpDown CheeseUpDown;
        private System.Windows.Forms.Label MayoAddition;
        private System.Windows.Forms.NumericUpDown MayoUpDown;
        private System.Windows.Forms.Button AddOrderItemButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ListBox MenuItemsList;
        private System.Windows.Forms.GroupBox CostOrderItem;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.ListBox TestDiaplay;
        private System.Windows.Forms.GroupBox gbx_drinkAddition;
        private System.Windows.Forms.GroupBox gbx_mealAddition;
        private System.Windows.Forms.RadioButton rdbtnDelivery;
        private System.Windows.Forms.GroupBox gpbxRadioDelivery;
        private System.Windows.Forms.RadioButton rdbtnRestaurant;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.PictureBox pcbxMenuItems;
        private System.Windows.Forms.Label lblAdditions;
        private System.Windows.Forms.Label lblMenuItems;
        private System.Windows.Forms.Label lblCurrentOrder;
        private System.Windows.Forms.Label lblAdditions2;
        private System.Windows.Forms.GroupBox gbx_totalCost;
        private System.Windows.Forms.Label lbl_totalCost;
    }
}

