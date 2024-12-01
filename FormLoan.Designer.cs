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
            btnCreate = new Button();
            tbItemID = new TextBox();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnItemSelect = new Button();
            btnItemView = new Button();
            tbCustomerID = new TextBox();
            label2 = new Label();
            tbLoanAmount = new TextBox();
            label3 = new Label();
            tbInterest = new TextBox();
            label4 = new Label();
            dtpLoanDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            dtpDueDate = new DateTimePicker();
            label7 = new Label();
            dtpRepaymentDate = new DateTimePicker();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnCustomerView = new Button();
            tbProcessingFee = new TextBox();
            label8 = new Label();
            btnComputeLoan = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(375, 290);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(115, 43);
            btnCreate.TabIndex = 36;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // tbItemID
            // 
            tbItemID.Enabled = false;
            tbItemID.Location = new Point(14, 29);
            tbItemID.Margin = new Padding(4, 3, 4, 3);
            tbItemID.Name = "tbItemID";
            tbItemID.Size = new Size(224, 23);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnItemSelect);
            flowLayoutPanel1.Controls.Add(btnItemView);
            flowLayoutPanel1.Location = new Point(14, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(224, 30);
            flowLayoutPanel1.TabIndex = 53;
            // 
            // btnItemSelect
            // 
            btnItemSelect.AutoSize = true;
            btnItemSelect.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnItemSelect.Location = new Point(4, 3);
            btnItemSelect.Margin = new Padding(4, 3, 4, 3);
            btnItemSelect.Name = "btnItemSelect";
            btnItemSelect.Size = new Size(48, 25);
            btnItemSelect.TabIndex = 29;
            btnItemSelect.Text = "Select";
            btnItemSelect.UseVisualStyleBackColor = true;
            btnItemSelect.Click += btnItemSelect_Click;
            // 
            // btnItemView
            // 
            btnItemView.AutoSize = true;
            btnItemView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnItemView.Location = new Point(60, 3);
            btnItemView.Margin = new Padding(4, 3, 4, 3);
            btnItemView.Name = "btnItemView";
            btnItemView.Size = new Size(42, 25);
            btnItemView.TabIndex = 30;
            btnItemView.Text = "View";
            btnItemView.UseVisualStyleBackColor = true;
            btnItemView.Click += btnItemView_Click;
            // 
            // tbCustomerID
            // 
            tbCustomerID.Enabled = false;
            tbCustomerID.Location = new Point(14, 110);
            tbCustomerID.Margin = new Padding(4, 3, 4, 3);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(224, 23);
            tbCustomerID.TabIndex = 55;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 54;
            label2.Text = "Customer ID *";
            // 
            // tbLoanAmount
            // 
            tbLoanAmount.Enabled = false;
            tbLoanAmount.Location = new Point(14, 279);
            tbLoanAmount.Margin = new Padding(4, 3, 4, 3);
            tbLoanAmount.Name = "tbLoanAmount";
            tbLoanAmount.Size = new Size(224, 23);
            tbLoanAmount.TabIndex = 58;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 260);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 15);
            label3.TabIndex = 57;
            label3.Text = "Loan Amount *";
            // 
            // tbInterest
            // 
            tbInterest.Location = new Point(14, 190);
            tbInterest.Margin = new Padding(4, 3, 4, 3);
            tbInterest.Name = "tbInterest";
            tbInterest.Size = new Size(224, 23);
            tbInterest.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 172);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 59;
            label4.Text = "Interest *";
            // 
            // dtpLoanDate
            // 
            dtpLoanDate.Location = new Point(245, 29);
            dtpLoanDate.Name = "dtpLoanDate";
            dtpLoanDate.Size = new Size(200, 23);
            dtpLoanDate.TabIndex = 61;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(245, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 62;
            label5.Text = "Loan Date *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(245, 55);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 64;
            label6.Text = "Due Date *";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(245, 74);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(200, 23);
            dtpDueDate.TabIndex = 63;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(245, 100);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 66;
            label7.Text = "Repayment Date *";
            // 
            // dtpRepaymentDate
            // 
            dtpRepaymentDate.Location = new Point(245, 119);
            dtpRepaymentDate.Name = "dtpRepaymentDate";
            dtpRepaymentDate.Size = new Size(200, 23);
            dtpRepaymentDate.TabIndex = 65;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btnCustomerView);
            flowLayoutPanel2.Location = new Point(14, 139);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(224, 30);
            flowLayoutPanel2.TabIndex = 54;
            // 
            // btnCustomerView
            // 
            btnCustomerView.AutoSize = true;
            btnCustomerView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomerView.Location = new Point(4, 3);
            btnCustomerView.Margin = new Padding(4, 3, 4, 3);
            btnCustomerView.Name = "btnCustomerView";
            btnCustomerView.Size = new Size(42, 25);
            btnCustomerView.TabIndex = 30;
            btnCustomerView.Text = "View";
            btnCustomerView.UseVisualStyleBackColor = true;
            btnCustomerView.Click += btnCustomerView_Click;
            // 
            // tbProcessingFee
            // 
            tbProcessingFee.Location = new Point(14, 234);
            tbProcessingFee.Margin = new Padding(4, 3, 4, 3);
            tbProcessingFee.Name = "tbProcessingFee";
            tbProcessingFee.Size = new Size(224, 23);
            tbProcessingFee.TabIndex = 68;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 216);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(93, 15);
            label8.TabIndex = 67;
            label8.Text = "Processing Fee *";
            // 
            // btnComputeLoan
            // 
            btnComputeLoan.AutoSize = true;
            btnComputeLoan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnComputeLoan.Location = new Point(14, 308);
            btnComputeLoan.Margin = new Padding(4, 3, 4, 3);
            btnComputeLoan.Name = "btnComputeLoan";
            btnComputeLoan.Size = new Size(67, 25);
            btnComputeLoan.TabIndex = 69;
            btnComputeLoan.Text = "Compute";
            btnComputeLoan.UseVisualStyleBackColor = true;
            btnComputeLoan.Click += btnComputeLoan_Click;
            // 
            // FormLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(503, 346);
            Controls.Add(btnComputeLoan);
            Controls.Add(tbProcessingFee);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dtpRepaymentDate);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(label6);
            Controls.Add(dtpDueDate);
            Controls.Add(label5);
            Controls.Add(dtpLoanDate);
            Controls.Add(tbInterest);
            Controls.Add(label4);
            Controls.Add(tbLoanAmount);
            Controls.Add(label3);
            Controls.Add(tbCustomerID);
            Controls.Add(label2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCreate);
            Controls.Add(tbItemID);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLoan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loan";
            Load += FormLoan_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbItemID;
        private System.Windows.Forms.Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnItemSelect;
        private Button btnItemView;
        private TextBox tbCustomerID;
        private Label label2;
        private TextBox tbLoanAmount;
        private Label label3;
        private TextBox tbInterest;
        private Label label4;
        private DateTimePicker dtpLoanDate;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpDueDate;
        private Label label7;
        private DateTimePicker dtpRepaymentDate;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnCustomerView;
        private TextBox tbProcessingFee;
        private Label label8;
        private Button btnComputeLoan;
    }
}