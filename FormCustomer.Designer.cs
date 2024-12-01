namespace PawnShop
{
    partial class FormCustomer
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
            label1 = new Label();
            tbFirstName = new TextBox();
            rtbAddress = new RichTextBox();
            tbMiddleName = new TextBox();
            label2 = new Label();
            tbLastName = new TextBox();
            label3 = new Label();
            label4 = new Label();
            tbEmail = new TextBox();
            label5 = new Label();
            tbPhoneNumber = new TextBox();
            label6 = new Label();
            btnCreate = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            tbIdentificationNumber = new TextBox();
            label8 = new Label();
            cbIdentificationType = new ComboBox();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "First Name *";
            // 
            // tbFirstName
            // 
            tbFirstName.Location = new Point(7, 38);
            tbFirstName.Margin = new Padding(4, 3, 4, 3);
            tbFirstName.Name = "tbFirstName";
            tbFirstName.Size = new Size(185, 23);
            tbFirstName.TabIndex = 1;
            // 
            // rtbAddress
            // 
            rtbAddress.Location = new Point(200, 38);
            rtbAddress.Margin = new Padding(4, 3, 4, 3);
            rtbAddress.Name = "rtbAddress";
            rtbAddress.Size = new Size(264, 112);
            rtbAddress.TabIndex = 2;
            rtbAddress.Text = "";
            // 
            // tbMiddleName
            // 
            tbMiddleName.Location = new Point(7, 83);
            tbMiddleName.Margin = new Padding(4, 3, 4, 3);
            tbMiddleName.Name = "tbMiddleName";
            tbMiddleName.Size = new Size(185, 23);
            tbMiddleName.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 64);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Middle Name";
            // 
            // tbLastName
            // 
            tbLastName.Location = new Point(7, 128);
            tbLastName.Margin = new Padding(4, 3, 4, 3);
            tbLastName.Name = "tbLastName";
            tbLastName.Size = new Size(185, 23);
            tbLastName.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 109);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 5;
            label3.Text = "Last Name *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(196, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Address *";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(7, 172);
            tbEmail.Margin = new Padding(4, 3, 4, 3);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(185, 23);
            tbEmail.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 154);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Email *";
            // 
            // tbPhoneNumber
            // 
            tbPhoneNumber.Location = new Point(7, 218);
            tbPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            tbPhoneNumber.Name = "tbPhoneNumber";
            tbPhoneNumber.Size = new Size(185, 23);
            tbPhoneNumber.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 199);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(96, 15);
            label6.TabIndex = 10;
            label6.Text = "Phone Number *";
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(374, 346);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(115, 43);
            btnCreate.TabIndex = 12;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbFirstName);
            groupBox1.Controls.Add(tbPhoneNumber);
            groupBox1.Controls.Add(rtbAddress);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(tbMiddleName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbLastName);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(477, 249);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Informations";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbIdentificationNumber);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(cbIdentificationType);
            groupBox2.Controls.Add(label7);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(12, 267);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(477, 73);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Identification Informations";
            // 
            // tbIdentificationNumber
            // 
            tbIdentificationNumber.Location = new Point(200, 38);
            tbIdentificationNumber.Margin = new Padding(4, 3, 4, 3);
            tbIdentificationNumber.Name = "tbIdentificationNumber";
            tbIdentificationNumber.Size = new Size(185, 23);
            tbIdentificationNumber.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(200, 19);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 12;
            label8.Text = "Number *";
            // 
            // cbIdentificationType
            // 
            cbIdentificationType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbIdentificationType.FormattingEnabled = true;
            cbIdentificationType.Location = new Point(7, 37);
            cbIdentificationType.Name = "cbIdentificationType";
            cbIdentificationType.Size = new Size(185, 23);
            cbIdentificationType.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 19);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 2;
            label7.Text = "Type *";
            // 
            // FormCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(496, 395);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCreate);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormCustomer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer";
            Load += FormCustomer_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.RichTextBox rtbAddress;
        private System.Windows.Forms.TextBox tbMiddleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ComboBox cbIdentificationType;
        private Label label7;
        private TextBox tbIdentificationNumber;
        private Label label8;
    }
}