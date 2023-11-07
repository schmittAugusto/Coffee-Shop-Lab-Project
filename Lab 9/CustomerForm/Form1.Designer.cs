namespace CustomerForm
{
    partial class Form1
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
            this.addressGrpGox = new System.Windows.Forms.GroupBox();
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.postalCodeTxtBox = new System.Windows.Forms.TextBox();
            this.cityTxtBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.provinceLabel = new System.Windows.Forms.Label();
            this.cityLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTxtBox = new System.Windows.Forms.TextBox();
            this.lnameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.telephoneNumberTxtBox = new System.Windows.Forms.TextBox();
            this.fnameTxtBox = new System.Windows.Forms.TextBox();
            this.cancelBttn = new System.Windows.Forms.Button();
            this.okBttn = new System.Windows.Forms.Button();
            this.telephoneNumberLabel = new System.Windows.Forms.Label();
            this.fnameLabel = new System.Windows.Forms.Label();
            this.addressGrpGox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addressGrpGox
            // 
            this.addressGrpGox.Controls.Add(this.provinceComboBox);
            this.addressGrpGox.Controls.Add(this.postalCodeTxtBox);
            this.addressGrpGox.Controls.Add(this.cityTxtBox);
            this.addressGrpGox.Controls.Add(this.postalCodeLabel);
            this.addressGrpGox.Controls.Add(this.provinceLabel);
            this.addressGrpGox.Controls.Add(this.cityLabel);
            this.addressGrpGox.Controls.Add(this.streetLabel);
            this.addressGrpGox.Controls.Add(this.streetTxtBox);
            this.addressGrpGox.Location = new System.Drawing.Point(369, 60);
            this.addressGrpGox.Name = "addressGrpGox";
            this.addressGrpGox.Size = new System.Drawing.Size(277, 252);
            this.addressGrpGox.TabIndex = 28;
            this.addressGrpGox.TabStop = false;
            this.addressGrpGox.Text = "Address";
            // 
            // provinceComboBox
            // 
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Items.AddRange(new object[] {
            "ON",
            "QC",
            "BC",
            "AB",
            "MB",
            "SK",
            "NS",
            "NB",
            "NL",
            "PE",
            "NT",
            "NU",
            "YT"});
            this.provinceComboBox.Location = new System.Drawing.Point(26, 143);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(49, 21);
            this.provinceComboBox.TabIndex = 15;
            // 
            // postalCodeTxtBox
            // 
            this.postalCodeTxtBox.Location = new System.Drawing.Point(26, 194);
            this.postalCodeTxtBox.Name = "postalCodeTxtBox";
            this.postalCodeTxtBox.Size = new System.Drawing.Size(161, 20);
            this.postalCodeTxtBox.TabIndex = 14;
            this.postalCodeTxtBox.Text = "*No Spaces*";
            this.postalCodeTxtBox.TextChanged += new System.EventHandler(this.postalCodeTxtBox_TextChanged);
            this.postalCodeTxtBox.Enter += new System.EventHandler(this.postalCodeTxtBox_Enter);
            this.postalCodeTxtBox.Leave += new System.EventHandler(this.postalCodeTxtBox_Leave);
            // 
            // cityTxtBox
            // 
            this.cityTxtBox.Location = new System.Drawing.Point(26, 96);
            this.cityTxtBox.Name = "cityTxtBox";
            this.cityTxtBox.Size = new System.Drawing.Size(161, 20);
            this.cityTxtBox.TabIndex = 12;
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Location = new System.Drawing.Point(23, 177);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(67, 13);
            this.postalCodeLabel.TabIndex = 11;
            this.postalCodeLabel.Text = "Postal Code:";
            // 
            // provinceLabel
            // 
            this.provinceLabel.AutoSize = true;
            this.provinceLabel.Location = new System.Drawing.Point(23, 127);
            this.provinceLabel.Name = "provinceLabel";
            this.provinceLabel.Size = new System.Drawing.Size(52, 13);
            this.provinceLabel.TabIndex = 10;
            this.provinceLabel.Text = "Province:";
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(23, 80);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 9;
            this.cityLabel.Text = "City:";
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(23, 32);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 8;
            this.streetLabel.Text = "Street:";
            // 
            // streetTxtBox
            // 
            this.streetTxtBox.Location = new System.Drawing.Point(26, 48);
            this.streetTxtBox.Name = "streetTxtBox";
            this.streetTxtBox.Size = new System.Drawing.Size(161, 20);
            this.streetTxtBox.TabIndex = 7;
            // 
            // lnameTxtBox
            // 
            this.lnameTxtBox.Location = new System.Drawing.Point(157, 156);
            this.lnameTxtBox.Name = "lnameTxtBox";
            this.lnameTxtBox.Size = new System.Drawing.Size(161, 20);
            this.lnameTxtBox.TabIndex = 27;
            this.lnameTxtBox.Text = "*Required*";
            this.lnameTxtBox.Enter += new System.EventHandler(this.lnameTxtBox_Enter);
            this.lnameTxtBox.Leave += new System.EventHandler(this.lnameTxtBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Last Name:";
            // 
            // telephoneNumberTxtBox
            // 
            this.telephoneNumberTxtBox.Location = new System.Drawing.Point(157, 203);
            this.telephoneNumberTxtBox.Name = "telephoneNumberTxtBox";
            this.telephoneNumberTxtBox.Size = new System.Drawing.Size(161, 20);
            this.telephoneNumberTxtBox.TabIndex = 25;
            this.telephoneNumberTxtBox.Text = "*Required*";
            this.telephoneNumberTxtBox.TextChanged += new System.EventHandler(this.telephoneNumberTxtBox_TextChanged_2);
            this.telephoneNumberTxtBox.Enter += new System.EventHandler(this.telephoneNumberTxtBox_Enter);
            this.telephoneNumberTxtBox.Leave += new System.EventHandler(this.telephoneNumberTxtBox_Leave);
            // 
            // fnameTxtBox
            // 
            this.fnameTxtBox.Location = new System.Drawing.Point(157, 108);
            this.fnameTxtBox.Name = "fnameTxtBox";
            this.fnameTxtBox.Size = new System.Drawing.Size(161, 20);
            this.fnameTxtBox.TabIndex = 24;
            this.fnameTxtBox.Text = "*Required*";
            this.fnameTxtBox.Enter += new System.EventHandler(this.fnameTxtBox_Enter);
            this.fnameTxtBox.Leave += new System.EventHandler(this.fnameTxtBox_Leave);
            // 
            // cancelBttn
            // 
            this.cancelBttn.Location = new System.Drawing.Point(423, 368);
            this.cancelBttn.Name = "cancelBttn";
            this.cancelBttn.Size = new System.Drawing.Size(75, 23);
            this.cancelBttn.TabIndex = 23;
            this.cancelBttn.Text = "Cancel";
            this.cancelBttn.UseVisualStyleBackColor = true;
            this.cancelBttn.Click += new System.EventHandler(this.cancelBttn_Click);
            // 
            // okBttn
            // 
            this.okBttn.Location = new System.Drawing.Point(279, 368);
            this.okBttn.Name = "okBttn";
            this.okBttn.Size = new System.Drawing.Size(75, 23);
            this.okBttn.TabIndex = 22;
            this.okBttn.Text = "OK";
            this.okBttn.UseVisualStyleBackColor = true;
            this.okBttn.Click += new System.EventHandler(this.okBttn_Click);
            // 
            // telephoneNumberLabel
            // 
            this.telephoneNumberLabel.AutoSize = true;
            this.telephoneNumberLabel.Location = new System.Drawing.Point(154, 187);
            this.telephoneNumberLabel.Name = "telephoneNumberLabel";
            this.telephoneNumberLabel.Size = new System.Drawing.Size(101, 13);
            this.telephoneNumberLabel.TabIndex = 21;
            this.telephoneNumberLabel.Text = "Telephone Number:";
            // 
            // fnameLabel
            // 
            this.fnameLabel.AutoSize = true;
            this.fnameLabel.Location = new System.Drawing.Point(154, 92);
            this.fnameLabel.Name = "fnameLabel";
            this.fnameLabel.Size = new System.Drawing.Size(60, 13);
            this.fnameLabel.TabIndex = 20;
            this.fnameLabel.Text = "First Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 441);
            this.Controls.Add(this.addressGrpGox);
            this.Controls.Add(this.lnameTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.telephoneNumberTxtBox);
            this.Controls.Add(this.fnameTxtBox);
            this.Controls.Add(this.cancelBttn);
            this.Controls.Add(this.okBttn);
            this.Controls.Add(this.telephoneNumberLabel);
            this.Controls.Add(this.fnameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.addressGrpGox.ResumeLayout(false);
            this.addressGrpGox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox addressGrpGox;
        private System.Windows.Forms.ComboBox provinceComboBox;
        private System.Windows.Forms.TextBox postalCodeTxtBox;
        private System.Windows.Forms.TextBox cityTxtBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.Label provinceLabel;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox streetTxtBox;
        private System.Windows.Forms.TextBox lnameTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox telephoneNumberTxtBox;
        private System.Windows.Forms.TextBox fnameTxtBox;
        private System.Windows.Forms.Button cancelBttn;
        private System.Windows.Forms.Button okBttn;
        private System.Windows.Forms.Label telephoneNumberLabel;
        private System.Windows.Forms.Label fnameLabel;
    }
}

