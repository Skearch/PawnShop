namespace PawnShop
{
    partial class FormItem
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
            btnCreate = new Button();
            label4 = new Label();
            tbEstimatedValue = new TextBox();
            label2 = new Label();
            rtbDescription = new RichTextBox();
            tbItemName = new TextBox();
            label1 = new Label();
            tbCustomerID = new TextBox();
            label3 = new Label();
            btnSelectCustomer = new Button();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(399, 246);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(115, 43);
            btnCreate.TabIndex = 25;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(233, 10);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 20;
            label4.Text = "Description";
            // 
            // tbEstimatedValue
            // 
            tbEstimatedValue.Location = new Point(14, 74);
            tbEstimatedValue.Margin = new Padding(4, 3, 4, 3);
            tbEstimatedValue.Name = "tbEstimatedValue";
            tbEstimatedValue.Size = new Size(185, 23);
            tbEstimatedValue.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 16;
            label2.Text = "Estimated Value *";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(237, 29);
            rtbDescription.Margin = new Padding(4, 3, 4, 3);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(264, 157);
            rtbDescription.TabIndex = 15;
            rtbDescription.Text = "";
            // 
            // tbItemName
            // 
            tbItemName.Location = new Point(14, 29);
            tbItemName.Margin = new Padding(4, 3, 4, 3);
            tbItemName.Name = "tbItemName";
            tbItemName.Size = new Size(185, 23);
            tbItemName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 13;
            label1.Text = "Item Name *";
            // 
            // tbCustomerID
            // 
            tbCustomerID.Location = new Point(14, 118);
            tbCustomerID.Margin = new Padding(4, 3, 4, 3);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.ReadOnly = true;
            tbCustomerID.Size = new Size(185, 23);
            tbCustomerID.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 27;
            label3.Text = "Customer ID *";
            // 
            // btnSelectCustomer
            // 
            btnSelectCustomer.Location = new Point(14, 147);
            btnSelectCustomer.Margin = new Padding(4, 3, 4, 3);
            btnSelectCustomer.Name = "btnSelectCustomer";
            btnSelectCustomer.Size = new Size(185, 26);
            btnSelectCustomer.TabIndex = 29;
            btnSelectCustomer.Text = "Select Customer";
            btnSelectCustomer.UseVisualStyleBackColor = true;
            btnSelectCustomer.Click += btnSelectCustomer_Click;
            // 
            // FormItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(524, 299);
            Controls.Add(btnSelectCustomer);
            Controls.Add(tbCustomerID);
            Controls.Add(label3);
            Controls.Add(btnCreate);
            Controls.Add(label4);
            Controls.Add(tbEstimatedValue);
            Controls.Add(label2);
            Controls.Add(rtbDescription);
            Controls.Add(tbItemName);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEstimatedValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label label3;
        private Button btnSelectCustomer;
    }
}