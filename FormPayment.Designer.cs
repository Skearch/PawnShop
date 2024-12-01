namespace PawnShop
{
    partial class FormPayment
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
            tbPaymentAmount = new TextBox();
            label2 = new Label();
            tbLoanID = new TextBox();
            label1 = new Label();
            btnSelectLoan = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnViewLoan = new Button();
            label3 = new Label();
            dtpPaymentDate = new DateTimePicker();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(257, 232);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(115, 43);
            btnCreate.TabIndex = 52;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // tbPaymentAmount
            // 
            tbPaymentAmount.Location = new Point(14, 109);
            tbPaymentAmount.Margin = new Padding(4, 3, 4, 3);
            tbPaymentAmount.Name = "tbPaymentAmount";
            tbPaymentAmount.Size = new Size(185, 23);
            tbPaymentAmount.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 91);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 49;
            label2.Text = "Payment Amount *";
            // 
            // tbLoanID
            // 
            tbLoanID.Enabled = false;
            tbLoanID.Location = new Point(14, 29);
            tbLoanID.Margin = new Padding(4, 3, 4, 3);
            tbLoanID.Name = "tbLoanID";
            tbLoanID.Size = new Size(185, 23);
            tbLoanID.TabIndex = 48;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 47;
            label1.Text = "Loan ID *";
            // 
            // btnSelectLoan
            // 
            btnSelectLoan.AutoSize = true;
            btnSelectLoan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSelectLoan.Location = new Point(4, 2);
            btnSelectLoan.Margin = new Padding(4, 3, 4, 3);
            btnSelectLoan.Name = "btnSelectLoan";
            btnSelectLoan.Size = new Size(48, 25);
            btnSelectLoan.TabIndex = 53;
            btnSelectLoan.Text = "Select";
            btnSelectLoan.UseVisualStyleBackColor = true;
            btnSelectLoan.Click += btnSelectLoan_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSelectLoan);
            flowLayoutPanel1.Controls.Add(btnViewLoan);
            flowLayoutPanel1.FlowDirection = FlowDirection.BottomUp;
            flowLayoutPanel1.Location = new Point(14, 58);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(185, 30);
            flowLayoutPanel1.TabIndex = 54;
            // 
            // btnViewLoan
            // 
            btnViewLoan.AutoSize = true;
            btnViewLoan.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewLoan.Location = new Point(60, 2);
            btnViewLoan.Margin = new Padding(4, 3, 4, 3);
            btnViewLoan.Name = "btnViewLoan";
            btnViewLoan.Size = new Size(42, 25);
            btnViewLoan.TabIndex = 54;
            btnViewLoan.Text = "View";
            btnViewLoan.UseVisualStyleBackColor = true;
            btnViewLoan.Click += btnViewLoan_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 135);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 55;
            label3.Text = "Payment Date *";
            // 
            // dtpPaymentDate
            // 
            dtpPaymentDate.Location = new Point(14, 153);
            dtpPaymentDate.Name = "dtpPaymentDate";
            dtpPaymentDate.Size = new Size(185, 23);
            dtpPaymentDate.TabIndex = 56;
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(385, 287);
            Controls.Add(dtpPaymentDate);
            Controls.Add(label3);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnCreate);
            Controls.Add(tbPaymentAmount);
            Controls.Add(label2);
            Controls.Add(tbLoanID);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            Load += FormPayment_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbPaymentAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLoanID;
        private System.Windows.Forms.Label label1;
        private Button btnSelectLoan;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnViewLoan;
        private Label label3;
        private DateTimePicker dtpPaymentDate;
    }
}