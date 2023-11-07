namespace Lab_9
{
    partial class CsFrom
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_phoneNum = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_phoneNum = new System.Windows.Forms.TextBox();
            this.txt_address_street = new System.Windows.Forms.TextBox();
            this.gbx_customerInfo = new System.Windows.Forms.GroupBox();
            this.txt_address_postalCode = new System.Windows.Forms.TextBox();
            this.txt_address_province = new System.Windows.Forms.TextBox();
            this.txt_address_city = new System.Windows.Forms.TextBox();
            this.btn_addNewCustomer = new System.Windows.Forms.Button();
            this.btn_cancelAddCustomer = new System.Windows.Forms.Button();
            this.gbx_customerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(16, 23);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name";
            // 
            // lbl_phoneNum
            // 
            this.lbl_phoneNum.AutoSize = true;
            this.lbl_phoneNum.Location = new System.Drawing.Point(16, 50);
            this.lbl_phoneNum.Name = "lbl_phoneNum";
            this.lbl_phoneNum.Size = new System.Drawing.Size(78, 13);
            this.lbl_phoneNum.TabIndex = 1;
            this.lbl_phoneNum.Text = "Phone Number";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(16, 82);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(45, 13);
            this.lbl_address.TabIndex = 2;
            this.lbl_address.Text = "Address";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(120, 19);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 1;
            this.txt_name.Text = "*Required";
            // 
            // txt_phoneNum
            // 
            this.txt_phoneNum.Location = new System.Drawing.Point(120, 47);
            this.txt_phoneNum.Name = "txt_phoneNum";
            this.txt_phoneNum.Size = new System.Drawing.Size(100, 20);
            this.txt_phoneNum.TabIndex = 3;
            this.txt_phoneNum.Text = "*Required";
            // 
            // txt_address_street
            // 
            this.txt_address_street.Location = new System.Drawing.Point(120, 75);
            this.txt_address_street.Name = "txt_address_street";
            this.txt_address_street.Size = new System.Drawing.Size(100, 20);
            this.txt_address_street.TabIndex = 5;
            this.txt_address_street.Text = "Street";
            // 
            // gbx_customerInfo
            // 
            this.gbx_customerInfo.Controls.Add(this.txt_address_postalCode);
            this.gbx_customerInfo.Controls.Add(this.txt_address_province);
            this.gbx_customerInfo.Controls.Add(this.txt_address_city);
            this.gbx_customerInfo.Controls.Add(this.txt_address_street);
            this.gbx_customerInfo.Controls.Add(this.txt_phoneNum);
            this.gbx_customerInfo.Controls.Add(this.txt_name);
            this.gbx_customerInfo.Controls.Add(this.lbl_address);
            this.gbx_customerInfo.Controls.Add(this.lbl_phoneNum);
            this.gbx_customerInfo.Controls.Add(this.lbl_name);
            this.gbx_customerInfo.Location = new System.Drawing.Point(12, 26);
            this.gbx_customerInfo.Name = "gbx_customerInfo";
            this.gbx_customerInfo.Size = new System.Drawing.Size(256, 188);
            this.gbx_customerInfo.TabIndex = 6;
            this.gbx_customerInfo.TabStop = false;
            this.gbx_customerInfo.Text = "Customer Information";
            // 
            // txt_address_postalCode
            // 
            this.txt_address_postalCode.Location = new System.Drawing.Point(120, 153);
            this.txt_address_postalCode.Name = "txt_address_postalCode";
            this.txt_address_postalCode.Size = new System.Drawing.Size(100, 20);
            this.txt_address_postalCode.TabIndex = 13;
            this.txt_address_postalCode.Text = "Postal Code";
            // 
            // txt_address_province
            // 
            this.txt_address_province.Location = new System.Drawing.Point(120, 127);
            this.txt_address_province.Name = "txt_address_province";
            this.txt_address_province.Size = new System.Drawing.Size(100, 20);
            this.txt_address_province.TabIndex = 11;
            this.txt_address_province.Text = "Province";
            // 
            // txt_address_city
            // 
            this.txt_address_city.Location = new System.Drawing.Point(120, 101);
            this.txt_address_city.Name = "txt_address_city";
            this.txt_address_city.Size = new System.Drawing.Size(100, 20);
            this.txt_address_city.TabIndex = 7;
            this.txt_address_city.Text = "City";
            // 
            // btn_addNewCustomer
            // 
            this.btn_addNewCustomer.Location = new System.Drawing.Point(31, 220);
            this.btn_addNewCustomer.Name = "btn_addNewCustomer";
            this.btn_addNewCustomer.Size = new System.Drawing.Size(75, 23);
            this.btn_addNewCustomer.TabIndex = 7;
            this.btn_addNewCustomer.Text = "Add";
            this.btn_addNewCustomer.UseVisualStyleBackColor = true;
            this.btn_addNewCustomer.Click += new System.EventHandler(this.btn_addNewCustomer_Click);
            // 
            // btn_cancelAddCustomer
            // 
            this.btn_cancelAddCustomer.Location = new System.Drawing.Point(157, 220);
            this.btn_cancelAddCustomer.Name = "btn_cancelAddCustomer";
            this.btn_cancelAddCustomer.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelAddCustomer.TabIndex = 8;
            this.btn_cancelAddCustomer.Text = "Cancel";
            this.btn_cancelAddCustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 265);
            this.Controls.Add(this.btn_cancelAddCustomer);
            this.Controls.Add(this.btn_addNewCustomer);
            this.Controls.Add(this.gbx_customerInfo);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.gbx_customerInfo.ResumeLayout(false);
            this.gbx_customerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_phoneNum;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_phoneNum;
        private System.Windows.Forms.TextBox txt_address_street;
        private System.Windows.Forms.GroupBox gbx_customerInfo;
        private System.Windows.Forms.Button btn_addNewCustomer;
        private System.Windows.Forms.Button btn_cancelAddCustomer;
        private System.Windows.Forms.TextBox txt_address_province;
        private System.Windows.Forms.TextBox txt_address_city;
        private System.Windows.Forms.TextBox txt_address_postalCode;
    }
}