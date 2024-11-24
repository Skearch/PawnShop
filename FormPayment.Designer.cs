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
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(172, 159);
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
            tbPaymentAmount.Location = new Point(14, 106);
            tbPaymentAmount.Margin = new Padding(4, 3, 4, 3);
            tbPaymentAmount.Name = "tbPaymentAmount";
            tbPaymentAmount.Size = new Size(185, 23);
            tbPaymentAmount.TabIndex = 50;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 49;
            label2.Text = "Payment Amount *";
            // 
            // tbLoanID
            // 
            tbLoanID.Location = new Point(14, 29);
            tbLoanID.Margin = new Padding(4, 3, 4, 3);
            tbLoanID.Name = "tbLoanID";
            tbLoanID.ReadOnly = true;
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
            btnSelectLoan.Location = new Point(14, 58);
            btnSelectLoan.Margin = new Padding(4, 3, 4, 3);
            btnSelectLoan.Name = "btnSelectLoan";
            btnSelectLoan.Size = new Size(185, 26);
            btnSelectLoan.TabIndex = 53;
            btnSelectLoan.Text = "Select Loan";
            btnSelectLoan.UseVisualStyleBackColor = true;
            btnSelectLoan.Click += btnSelectLoan_Click;
            // 
            // FormPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(296, 215);
            Controls.Add(btnSelectLoan);
            Controls.Add(btnCreate);
            Controls.Add(tbPaymentAmount);
            Controls.Add(label2);
            Controls.Add(tbLoanID);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormPayment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
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
    }
}