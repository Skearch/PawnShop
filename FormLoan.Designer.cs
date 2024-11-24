namespace PawnShop
{
    partial class FormLoan
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
            tbInterestRate = new TextBox();
            btnCreate = new Button();
            label5 = new Label();
            tbLoanAmount = new TextBox();
            label2 = new Label();
            tbItemID = new TextBox();
            label1 = new Label();
            dtpDueDate = new DateTimePicker();
            label7 = new Label();
            cbStatus = new ComboBox();
            label4 = new Label();
            btnSelectItem = new Button();
            SuspendLayout();
            // 
            // tbInterestRate
            // 
            tbInterestRate.Location = new Point(14, 151);
            tbInterestRate.Margin = new Padding(4, 3, 4, 3);
            tbInterestRate.Name = "tbInterestRate";
            tbInterestRate.Size = new Size(185, 23);
            tbInterestRate.TabIndex = 39;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(288, 192);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(115, 43);
            btnCreate.TabIndex = 36;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 132);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(80, 15);
            label5.TabIndex = 35;
            label5.Text = "Interest Rate *";
            // 
            // tbLoanAmount
            // 
            tbLoanAmount.Location = new Point(14, 106);
            tbLoanAmount.Margin = new Padding(4, 3, 4, 3);
            tbLoanAmount.Name = "tbLoanAmount";
            tbLoanAmount.Size = new Size(185, 23);
            tbLoanAmount.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 32;
            label2.Text = "Loan Amount *";
            // 
            // tbItemID
            // 
            tbItemID.Location = new Point(14, 29);
            tbItemID.Margin = new Padding(4, 3, 4, 3);
            tbItemID.Name = "tbItemID";
            tbItemID.ReadOnly = true;
            tbItemID.Size = new Size(185, 23);
            tbItemID.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 29;
            label1.Text = "Item ID *";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(217, 29);
            dtpDueDate.Margin = new Padding(4, 3, 4, 3);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(185, 23);
            dtpDueDate.TabIndex = 43;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(217, 10);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 42;
            label7.Text = "Due Date *";
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(217, 73);
            cbStatus.Margin = new Padding(4, 3, 4, 3);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(185, 23);
            cbStatus.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 55);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 46;
            label4.Text = "Status *";
            // 
            // btnSelectItem
            // 
            btnSelectItem.Location = new Point(14, 58);
            btnSelectItem.Margin = new Padding(4, 3, 4, 3);
            btnSelectItem.Name = "btnSelectItem";
            btnSelectItem.Size = new Size(185, 26);
            btnSelectItem.TabIndex = 47;
            btnSelectItem.Text = "Select Item";
            btnSelectItem.UseVisualStyleBackColor = true;
            btnSelectItem.Click += btnSelectItem_Click;
            // 
            // FormLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(422, 243);
            Controls.Add(btnSelectItem);
            Controls.Add(label4);
            Controls.Add(cbStatus);
            Controls.Add(dtpDueDate);
            Controls.Add(label7);
            Controls.Add(tbInterestRate);
            Controls.Add(btnCreate);
            Controls.Add(label5);
            Controls.Add(tbLoanAmount);
            Controls.Add(label2);
            Controls.Add(tbItemID);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan";
            Load += FormLoan_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbInterestRate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbLoanAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label4;
        private Button btnSelectItem;
    }
}