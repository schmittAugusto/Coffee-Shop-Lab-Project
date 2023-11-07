namespace L9_3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_account = new System.Windows.Forms.Label();
            this.lbl_passwd = new System.Windows.Forms.Label();
            this.gbx_login = new System.Windows.Forms.GroupBox();
            this.btn_login_enter = new System.Windows.Forms.Button();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.txt_account = new System.Windows.Forms.TextBox();
            this.panel_right = new System.Windows.Forms.Panel();
            this.btn_addOrder = new System.Windows.Forms.Button();
            this.panel_left = new System.Windows.Forms.Panel();
            this.gbx_customers_info = new System.Windows.Forms.GroupBox();
            this.gbx_latestOrder = new System.Windows.Forms.GroupBox();
            this.lbl_totalCost_display = new System.Windows.Forms.Label();
            this.lbl_orderItems_display = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_numOrders_display = new System.Windows.Forms.Label();
            this.lbl_address_display = new System.Windows.Forms.Label();
            this.lbl_phone_display = new System.Windows.Forms.Label();
            this.lbl_id_display = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbx_customers_list = new System.Windows.Forms.GroupBox();
            this.lbx_customers = new System.Windows.Forms.ListBox();
            this.btn_edit_customer = new System.Windows.Forms.Button();
            this.btn_add_customer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.btn_completedOrder = new System.Windows.Forms.Button();
            this.gbx_pendingOrders = new System.Windows.Forms.GroupBox();
            this.lbx_pendingOrders = new System.Windows.Forms.ListBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbx_login.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.gbx_customers_info.SuspendLayout();
            this.gbx_latestOrder.SuspendLayout();
            this.gbx_customers_list.SuspendLayout();
            this.gbx_pendingOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(997, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.uploadToolStripMenuItem});
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Visible = false;
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // uploadToolStripMenuItem
            // 
            this.uploadToolStripMenuItem.BackColor = System.Drawing.Color.AntiqueWhite;
            this.uploadToolStripMenuItem.Name = "uploadToolStripMenuItem";
            this.uploadToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.uploadToolStripMenuItem.Text = "Upload";
            this.uploadToolStripMenuItem.Click += new System.EventHandler(this.uploadToolStripMenuItem_Click);
            // 
            // lbl_account
            // 
            this.lbl_account.AutoSize = true;
            this.lbl_account.Location = new System.Drawing.Point(3, 33);
            this.lbl_account.Name = "lbl_account";
            this.lbl_account.Size = new System.Drawing.Size(89, 20);
            this.lbl_account.TabIndex = 6;
            this.lbl_account.Text = "User Name";
            // 
            // lbl_passwd
            // 
            this.lbl_passwd.AutoSize = true;
            this.lbl_passwd.Location = new System.Drawing.Point(3, 67);
            this.lbl_passwd.Name = "lbl_passwd";
            this.lbl_passwd.Size = new System.Drawing.Size(78, 20);
            this.lbl_passwd.TabIndex = 7;
            this.lbl_passwd.Text = "Password";
            // 
            // gbx_login
            // 
            this.gbx_login.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbx_login.Controls.Add(this.btn_login_enter);
            this.gbx_login.Controls.Add(this.txt_passwd);
            this.gbx_login.Controls.Add(this.txt_account);
            this.gbx_login.Controls.Add(this.lbl_account);
            this.gbx_login.Controls.Add(this.lbl_passwd);
            this.gbx_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_login.ForeColor = System.Drawing.SystemColors.InfoText;
            this.gbx_login.Location = new System.Drawing.Point(14, 170);
            this.gbx_login.Name = "gbx_login";
            this.gbx_login.Size = new System.Drawing.Size(252, 152);
            this.gbx_login.TabIndex = 8;
            this.gbx_login.TabStop = false;
            this.gbx_login.Text = "Log in";
            // 
            // btn_login_enter
            // 
            this.btn_login_enter.BackColor = System.Drawing.Color.Maroon;
            this.btn_login_enter.Enabled = false;
            this.btn_login_enter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login_enter.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login_enter.ForeColor = System.Drawing.Color.White;
            this.btn_login_enter.Location = new System.Drawing.Point(146, 118);
            this.btn_login_enter.Name = "btn_login_enter";
            this.btn_login_enter.Size = new System.Drawing.Size(100, 28);
            this.btn_login_enter.TabIndex = 5;
            this.btn_login_enter.Text = "Enter";
            this.btn_login_enter.UseVisualStyleBackColor = false;
            this.btn_login_enter.Click += new System.EventHandler(this.btn_login_enter_Click);
            this.btn_login_enter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btn_login_enter_KeyPress);
            // 
            // txt_passwd
            // 
            this.txt_passwd.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_passwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_passwd.Enabled = false;
            this.txt_passwd.Location = new System.Drawing.Point(111, 67);
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.Size = new System.Drawing.Size(135, 26);
            this.txt_passwd.TabIndex = 3;
            this.txt_passwd.TextChanged += new System.EventHandler(this.txt_passwd_TextChanged);
            // 
            // txt_account
            // 
            this.txt_account.BackColor = System.Drawing.Color.LavenderBlush;
            this.txt_account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_account.Location = new System.Drawing.Point(111, 33);
            this.txt_account.Name = "txt_account";
            this.txt_account.Size = new System.Drawing.Size(135, 26);
            this.txt_account.TabIndex = 1;
            this.txt_account.TextChanged += new System.EventHandler(this.txt_account_TextChanged);
            // 
            // panel_right
            // 
            this.panel_right.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel_right.Controls.Add(this.gbx_pendingOrders);
            this.panel_right.Controls.Add(this.btn_addOrder);
            this.panel_right.Controls.Add(this.gbx_login);
            this.panel_right.Location = new System.Drawing.Point(709, 25);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(285, 497);
            this.panel_right.TabIndex = 9;
            // 
            // btn_addOrder
            // 
            this.btn_addOrder.BackColor = System.Drawing.Color.Maroon;
            this.btn_addOrder.Enabled = false;
            this.btn_addOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addOrder.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addOrder.ForeColor = System.Drawing.Color.White;
            this.btn_addOrder.Location = new System.Drawing.Point(21, 15);
            this.btn_addOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_addOrder.Name = "btn_addOrder";
            this.btn_addOrder.Size = new System.Drawing.Size(115, 47);
            this.btn_addOrder.TabIndex = 5;
            this.btn_addOrder.Text = "Add Order";
            this.btn_addOrder.UseVisualStyleBackColor = false;
            this.btn_addOrder.Visible = false;
            this.btn_addOrder.Click += new System.EventHandler(this.btn_addOrder_Click);
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel_left.BackgroundImage = global::Lab_9.Properties.Resources.BackgroundWelcome;
            this.panel_left.Controls.Add(this.gbx_customers_info);
            this.panel_left.Controls.Add(this.gbx_customers_list);
            this.panel_left.Location = new System.Drawing.Point(2, 25);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(701, 497);
            this.panel_left.TabIndex = 5;
            // 
            // gbx_customers_info
            // 
            this.gbx_customers_info.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbx_customers_info.Controls.Add(this.btn_completedOrder);
            this.gbx_customers_info.Controls.Add(this.gbx_latestOrder);
            this.gbx_customers_info.Controls.Add(this.lbl_numOrders_display);
            this.gbx_customers_info.Controls.Add(this.lbl_address_display);
            this.gbx_customers_info.Controls.Add(this.lbl_phone_display);
            this.gbx_customers_info.Controls.Add(this.lbl_id_display);
            this.gbx_customers_info.Controls.Add(this.label1);
            this.gbx_customers_info.Controls.Add(this.label4);
            this.gbx_customers_info.Controls.Add(this.label3);
            this.gbx_customers_info.Controls.Add(this.label2);
            this.gbx_customers_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_customers_info.Location = new System.Drawing.Point(306, 1);
            this.gbx_customers_info.Name = "gbx_customers_info";
            this.gbx_customers_info.Size = new System.Drawing.Size(382, 455);
            this.gbx_customers_info.TabIndex = 9;
            this.gbx_customers_info.TabStop = false;
            this.gbx_customers_info.Text = "Customer Info";
            this.gbx_customers_info.Visible = false;
            // 
            // gbx_latestOrder
            // 
            this.gbx_latestOrder.BackColor = System.Drawing.Color.AntiqueWhite;
            this.gbx_latestOrder.Controls.Add(this.lbl_deliveryDate);
            this.gbx_latestOrder.Controls.Add(this.label7);
            this.gbx_latestOrder.Controls.Add(this.lbl_totalCost_display);
            this.gbx_latestOrder.Controls.Add(this.lbl_orderItems_display);
            this.gbx_latestOrder.Controls.Add(this.label6);
            this.gbx_latestOrder.Controls.Add(this.label5);
            this.gbx_latestOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_latestOrder.Location = new System.Drawing.Point(6, 146);
            this.gbx_latestOrder.Name = "gbx_latestOrder";
            this.gbx_latestOrder.Size = new System.Drawing.Size(370, 248);
            this.gbx_latestOrder.TabIndex = 9;
            this.gbx_latestOrder.TabStop = false;
            this.gbx_latestOrder.Text = "Recent Order ";
            // 
            // lbl_totalCost_display
            // 
            this.lbl_totalCost_display.AutoSize = true;
            this.lbl_totalCost_display.Location = new System.Drawing.Point(284, 37);
            this.lbl_totalCost_display.Name = "lbl_totalCost_display";
            this.lbl_totalCost_display.Size = new System.Drawing.Size(0, 16);
            this.lbl_totalCost_display.TabIndex = 3;
            // 
            // lbl_orderItems_display
            // 
            this.lbl_orderItems_display.AutoSize = true;
            this.lbl_orderItems_display.Location = new System.Drawing.Point(11, 55);
            this.lbl_orderItems_display.MaximumSize = new System.Drawing.Size(300, 300);
            this.lbl_orderItems_display.Name = "lbl_orderItems_display";
            this.lbl_orderItems_display.Size = new System.Drawing.Size(0, 16);
            this.lbl_orderItems_display.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(193, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Items";
            // 
            // lbl_numOrders_display
            // 
            this.lbl_numOrders_display.AutoSize = true;
            this.lbl_numOrders_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_numOrders_display.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_numOrders_display.Location = new System.Drawing.Point(120, 123);
            this.lbl_numOrders_display.Name = "lbl_numOrders_display";
            this.lbl_numOrders_display.Size = new System.Drawing.Size(0, 16);
            this.lbl_numOrders_display.TabIndex = 7;
            // 
            // lbl_address_display
            // 
            this.lbl_address_display.AutoSize = true;
            this.lbl_address_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address_display.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_address_display.Location = new System.Drawing.Point(120, 92);
            this.lbl_address_display.Name = "lbl_address_display";
            this.lbl_address_display.Size = new System.Drawing.Size(0, 16);
            this.lbl_address_display.TabIndex = 6;
            // 
            // lbl_phone_display
            // 
            this.lbl_phone_display.AutoSize = true;
            this.lbl_phone_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone_display.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_phone_display.Location = new System.Drawing.Point(120, 61);
            this.lbl_phone_display.Name = "lbl_phone_display";
            this.lbl_phone_display.Size = new System.Drawing.Size(0, 16);
            this.lbl_phone_display.TabIndex = 5;
            // 
            // lbl_id_display
            // 
            this.lbl_id_display.AutoSize = true;
            this.lbl_id_display.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id_display.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_id_display.Location = new System.Drawing.Point(120, 31);
            this.lbl_id_display.Name = "lbl_id_display";
            this.lbl_id_display.Size = new System.Drawing.Size(0, 16);
            this.lbl_id_display.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Member ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(16, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Orders ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone";
            // 
            // gbx_customers_list
            // 
            this.gbx_customers_list.BackColor = System.Drawing.Color.Transparent;
            this.gbx_customers_list.Controls.Add(this.lbx_customers);
            this.gbx_customers_list.Controls.Add(this.btn_edit_customer);
            this.gbx_customers_list.Controls.Add(this.btn_add_customer);
            this.gbx_customers_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_customers_list.Location = new System.Drawing.Point(10, 0);
            this.gbx_customers_list.Name = "gbx_customers_list";
            this.gbx_customers_list.Size = new System.Drawing.Size(290, 456);
            this.gbx_customers_list.TabIndex = 5;
            this.gbx_customers_list.TabStop = false;
            this.gbx_customers_list.Text = "Member List";
            this.gbx_customers_list.Visible = false;
            // 
            // lbx_customers
            // 
            this.lbx_customers.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbx_customers.FormattingEnabled = true;
            this.lbx_customers.ItemHeight = 20;
            this.lbx_customers.Location = new System.Drawing.Point(21, 27);
            this.lbx_customers.Margin = new System.Windows.Forms.Padding(2);
            this.lbx_customers.Name = "lbx_customers";
            this.lbx_customers.Size = new System.Drawing.Size(249, 324);
            this.lbx_customers.TabIndex = 4;
            this.lbx_customers.SelectedIndexChanged += new System.EventHandler(this.lbx_customers_SelectedIndexChanged);
            this.lbx_customers.DisplayMemberChanged += new System.EventHandler(this.lbx_customers_DisplayMemberChanged);
            // 
            // btn_edit_customer
            // 
            this.btn_edit_customer.BackColor = System.Drawing.Color.Maroon;
            this.btn_edit_customer.Enabled = false;
            this.btn_edit_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_customer.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit_customer.ForeColor = System.Drawing.Color.White;
            this.btn_edit_customer.Location = new System.Drawing.Point(155, 395);
            this.btn_edit_customer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_edit_customer.Name = "btn_edit_customer";
            this.btn_edit_customer.Size = new System.Drawing.Size(115, 47);
            this.btn_edit_customer.TabIndex = 3;
            this.btn_edit_customer.Text = "Edit Customer";
            this.btn_edit_customer.UseVisualStyleBackColor = false;
            this.btn_edit_customer.Click += new System.EventHandler(this.btn_edit_customer_Click);
            // 
            // btn_add_customer
            // 
            this.btn_add_customer.BackColor = System.Drawing.Color.Maroon;
            this.btn_add_customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_customer.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_customer.ForeColor = System.Drawing.Color.White;
            this.btn_add_customer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_customer.Location = new System.Drawing.Point(21, 395);
            this.btn_add_customer.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_customer.Name = "btn_add_customer";
            this.btn_add_customer.Size = new System.Drawing.Size(116, 47);
            this.btn_add_customer.TabIndex = 2;
            this.btn_add_customer.Text = "Add Customer";
            this.btn_add_customer.UseVisualStyleBackColor = false;
            this.btn_add_customer.Click += new System.EventHandler(this.btn_add_customer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Delivery Date";
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Location = new System.Drawing.Point(200, 13);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(0, 16);
            this.lbl_deliveryDate.TabIndex = 5;
            // 
            // btn_completedOrder
            // 
            this.btn_completedOrder.BackColor = System.Drawing.Color.Maroon;
            this.btn_completedOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_completedOrder.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_completedOrder.ForeColor = System.Drawing.Color.White;
            this.btn_completedOrder.Location = new System.Drawing.Point(261, 399);
            this.btn_completedOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btn_completedOrder.Name = "btn_completedOrder";
            this.btn_completedOrder.Size = new System.Drawing.Size(115, 47);
            this.btn_completedOrder.TabIndex = 9;
            this.btn_completedOrder.Text = "Complete Order";
            this.btn_completedOrder.UseVisualStyleBackColor = false;
            this.btn_completedOrder.Visible = false;
            this.btn_completedOrder.Click += new System.EventHandler(this.btn_completedOrder_Click);
            // 
            // gbx_pendingOrders
            // 
            this.gbx_pendingOrders.Controls.Add(this.lbx_pendingOrders);
            this.gbx_pendingOrders.Enabled = false;
            this.gbx_pendingOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_pendingOrders.Location = new System.Drawing.Point(14, 80);
            this.gbx_pendingOrders.Name = "gbx_pendingOrders";
            this.gbx_pendingOrders.Size = new System.Drawing.Size(261, 376);
            this.gbx_pendingOrders.TabIndex = 9;
            this.gbx_pendingOrders.TabStop = false;
            this.gbx_pendingOrders.Text = "Pending Orders";
            this.gbx_pendingOrders.Visible = false;
            // 
            // lbx_pendingOrders
            // 
            this.lbx_pendingOrders.Enabled = false;
            this.lbx_pendingOrders.FormattingEnabled = true;
            this.lbx_pendingOrders.ItemHeight = 16;
            this.lbx_pendingOrders.Location = new System.Drawing.Point(7, 33);
            this.lbx_pendingOrders.Name = "lbx_pendingOrders";
            this.lbx_pendingOrders.Size = new System.Drawing.Size(245, 324);
            this.lbx_pendingOrders.TabIndex = 0;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(CoffeeShop.Customer);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(997, 524);
            this.Controls.Add(this.panel_left);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel_right);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbx_login.ResumeLayout(false);
            this.gbx_login.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.gbx_customers_info.ResumeLayout(false);
            this.gbx_customers_info.PerformLayout();
            this.gbx_latestOrder.ResumeLayout(false);
            this.gbx_latestOrder.PerformLayout();
            this.gbx_customers_list.ResumeLayout(false);
            this.gbx_pendingOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button btn_add_customer;
        private System.Windows.Forms.Button btn_edit_customer;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem uploadToolStripMenuItem;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.ListBox lbx_customers;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Label lbl_account;
        private System.Windows.Forms.Label lbl_passwd;
        private System.Windows.Forms.GroupBox gbx_login;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.TextBox txt_account;
        private System.Windows.Forms.Button btn_login_enter;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.GroupBox gbx_customers_list;
        private System.Windows.Forms.GroupBox gbx_customers_info;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_numOrders_display;
        private System.Windows.Forms.Label lbl_address_display;
        private System.Windows.Forms.Label lbl_phone_display;
        private System.Windows.Forms.Label lbl_id_display;
        private System.Windows.Forms.GroupBox gbx_latestOrder;
        private System.Windows.Forms.Label lbl_totalCost_display;
        private System.Windows.Forms.Label lbl_orderItems_display;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_addOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Button btn_completedOrder;
        private System.Windows.Forms.GroupBox gbx_pendingOrders;
        private System.Windows.Forms.ListBox lbx_pendingOrders;
    }
}

