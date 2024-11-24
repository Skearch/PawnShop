using System.Drawing;
using System.Windows.Forms;

namespace PawnShop
{
    partial class FormView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormView));
            tabControl1 = new TabControl();
            tpCustomer = new TabPage();
            btnCustomerReload = new Button();
            btnCustomerDelete = new Button();
            btnCustomerCreate = new Button();
            dgvCustomers = new DataGridView();
            tpItem = new TabPage();
            btnItemDelete = new Button();
            btnItemReload = new Button();
            btnItemCreate = new Button();
            dgvItems = new DataGridView();
            tpLoan = new TabPage();
            btnLoanDelete = new Button();
            btnLoanReload = new Button();
            btnLoanCreate = new Button();
            dgvLoans = new DataGridView();
            tpPayment = new TabPage();
            btnPaymentDelete = new Button();
            btnPaymentReload = new Button();
            btnPaymentCreate = new Button();
            dgvPayments = new DataGridView();
            panel1 = new Panel();
            label2 = new Label();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            tabControl1.SuspendLayout();
            tpCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            tpLoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            tpPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tpCustomer);
            tabControl1.Controls.Add(tpItem);
            tabControl1.Controls.Add(tpLoan);
            tabControl1.Controls.Add(tpPayment);
            tabControl1.Location = new Point(14, 160);
            tabControl1.Margin = new Padding(4, 3, 4, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(905, 444);
            tabControl1.TabIndex = 0;
            // 
            // tpCustomer
            // 
            tpCustomer.BackColor = Color.FromArgb(255, 255, 128);
            tpCustomer.Controls.Add(btnCustomerReload);
            tpCustomer.Controls.Add(btnCustomerDelete);
            tpCustomer.Controls.Add(btnCustomerCreate);
            tpCustomer.Controls.Add(dgvCustomers);
            tpCustomer.Location = new Point(4, 24);
            tpCustomer.Margin = new Padding(4, 3, 4, 3);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Padding = new Padding(4, 3, 4, 3);
            tpCustomer.Size = new Size(897, 416);
            tpCustomer.TabIndex = 0;
            tpCustomer.Text = "Customers";
            // 
            // btnCustomerReload
            // 
            btnCustomerReload.Font = new Font("Lucida Console", 8.25F);
            btnCustomerReload.Location = new Point(208, 384);
            btnCustomerReload.Margin = new Padding(4, 3, 4, 3);
            btnCustomerReload.Name = "btnCustomerReload";
            btnCustomerReload.Size = new Size(86, 27);
            btnCustomerReload.TabIndex = 5;
            btnCustomerReload.Text = "Reload";
            btnCustomerReload.UseVisualStyleBackColor = true;
            btnCustomerReload.Click += btnCustomerReload_Click;
            // 
            // btnCustomerDelete
            // 
            btnCustomerDelete.Font = new Font("Lucida Console", 8.25F);
            btnCustomerDelete.Location = new Point(132, 384);
            btnCustomerDelete.Margin = new Padding(4, 3, 4, 3);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(69, 27);
            btnCustomerDelete.TabIndex = 4;
            btnCustomerDelete.Text = "Delete";
            btnCustomerDelete.UseVisualStyleBackColor = true;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // btnCustomerCreate
            // 
            btnCustomerCreate.Font = new Font("Lucida Console", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCustomerCreate.Location = new Point(4, 384);
            btnCustomerCreate.Margin = new Padding(4, 3, 4, 3);
            btnCustomerCreate.Name = "btnCustomerCreate";
            btnCustomerCreate.Size = new Size(121, 27);
            btnCustomerCreate.TabIndex = 1;
            btnCustomerCreate.Text = "New Customer";
            btnCustomerCreate.UseVisualStyleBackColor = true;
            btnCustomerCreate.Click += btnCustomerCreate_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCustomers.BackgroundColor = Color.FromArgb(255, 255, 128);
            dgvCustomers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.GridColor = Color.FromArgb(230, 239, 245);
            dgvCustomers.Location = new Point(4, 3);
            dgvCustomers.Margin = new Padding(4, 3, 4, 3);
            dgvCustomers.MultiSelect = false;
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.ShowCellErrors = false;
            dgvCustomers.ShowCellToolTips = false;
            dgvCustomers.ShowEditingIcon = false;
            dgvCustomers.ShowRowErrors = false;
            dgvCustomers.Size = new Size(889, 374);
            dgvCustomers.TabIndex = 22;
            // 
            // tpItem
            // 
            tpItem.BackColor = Color.FromArgb(255, 255, 128);
            tpItem.Controls.Add(btnItemDelete);
            tpItem.Controls.Add(btnItemReload);
            tpItem.Controls.Add(btnItemCreate);
            tpItem.Controls.Add(dgvItems);
            tpItem.Location = new Point(4, 24);
            tpItem.Margin = new Padding(4, 3, 4, 3);
            tpItem.Name = "tpItem";
            tpItem.Size = new Size(897, 416);
            tpItem.TabIndex = 1;
            tpItem.Text = "Items";
            // 
            // btnItemDelete
            // 
            btnItemDelete.Font = new Font("Lucida Console", 8.25F);
            btnItemDelete.Location = new Point(227, 384);
            btnItemDelete.Margin = new Padding(4, 3, 4, 3);
            btnItemDelete.Name = "btnItemDelete";
            btnItemDelete.Size = new Size(88, 27);
            btnItemDelete.TabIndex = 26;
            btnItemDelete.Text = "Delete";
            btnItemDelete.UseVisualStyleBackColor = true;
            btnItemDelete.Click += btnItemDelete_Click;
            // 
            // btnItemReload
            // 
            btnItemReload.Font = new Font("Lucida Console", 8.25F);
            btnItemReload.Location = new Point(138, 384);
            btnItemReload.Margin = new Padding(4, 3, 4, 3);
            btnItemReload.Name = "btnItemReload";
            btnItemReload.Size = new Size(82, 27);
            btnItemReload.TabIndex = 25;
            btnItemReload.Text = "Reload";
            btnItemReload.UseVisualStyleBackColor = true;
            btnItemReload.Click += btnItemReload_Click;
            // 
            // btnItemCreate
            // 
            btnItemCreate.Font = new Font("Lucida Console", 8.25F);
            btnItemCreate.Location = new Point(4, 384);
            btnItemCreate.Margin = new Padding(4, 3, 4, 3);
            btnItemCreate.Name = "btnItemCreate";
            btnItemCreate.Size = new Size(126, 27);
            btnItemCreate.TabIndex = 23;
            btnItemCreate.Text = "Customer Sell";
            btnItemCreate.UseVisualStyleBackColor = true;
            btnItemCreate.Click += btnItemCreate_Click;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItems.BackgroundColor = Color.FromArgb(255, 255, 128);
            dgvItems.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.GridColor = Color.FromArgb(230, 239, 245);
            dgvItems.Location = new Point(4, 3);
            dgvItems.Margin = new Padding(4, 3, 4, 3);
            dgvItems.MultiSelect = false;
            dgvItems.Name = "dgvItems";
            dgvItems.ReadOnly = true;
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.ShowCellErrors = false;
            dgvItems.ShowCellToolTips = false;
            dgvItems.ShowEditingIcon = false;
            dgvItems.ShowRowErrors = false;
            dgvItems.Size = new Size(889, 374);
            dgvItems.TabIndex = 24;
            // 
            // tpLoan
            // 
            tpLoan.BackColor = Color.FromArgb(255, 255, 128);
            tpLoan.Controls.Add(btnLoanDelete);
            tpLoan.Controls.Add(btnLoanReload);
            tpLoan.Controls.Add(btnLoanCreate);
            tpLoan.Controls.Add(dgvLoans);
            tpLoan.Location = new Point(4, 24);
            tpLoan.Margin = new Padding(4, 3, 4, 3);
            tpLoan.Name = "tpLoan";
            tpLoan.Size = new Size(897, 416);
            tpLoan.TabIndex = 2;
            tpLoan.Text = "Loans";
            // 
            // btnLoanDelete
            // 
            btnLoanDelete.Font = new Font("Lucida Console", 8.25F);
            btnLoanDelete.Location = new Point(189, 384);
            btnLoanDelete.Margin = new Padding(4, 3, 4, 3);
            btnLoanDelete.Name = "btnLoanDelete";
            btnLoanDelete.Size = new Size(69, 27);
            btnLoanDelete.TabIndex = 28;
            btnLoanDelete.Text = "Delete";
            btnLoanDelete.UseVisualStyleBackColor = true;
            btnLoanDelete.Click += btnLoanDelete_Click;
            // 
            // btnLoanReload
            // 
            btnLoanReload.Font = new Font("Lucida Console", 8.25F);
            btnLoanReload.Location = new Point(100, 384);
            btnLoanReload.Margin = new Padding(4, 3, 4, 3);
            btnLoanReload.Name = "btnLoanReload";
            btnLoanReload.Size = new Size(82, 27);
            btnLoanReload.TabIndex = 27;
            btnLoanReload.Text = "Reload";
            btnLoanReload.UseVisualStyleBackColor = true;
            btnLoanReload.Click += btnLoanReload_Click;
            // 
            // btnLoanCreate
            // 
            btnLoanCreate.Font = new Font("Lucida Console", 8.25F);
            btnLoanCreate.Location = new Point(4, 384);
            btnLoanCreate.Margin = new Padding(4, 3, 4, 3);
            btnLoanCreate.Name = "btnLoanCreate";
            btnLoanCreate.Size = new Size(90, 27);
            btnLoanCreate.TabIndex = 26;
            btnLoanCreate.Text = "New Loan";
            btnLoanCreate.UseVisualStyleBackColor = true;
            btnLoanCreate.Click += btnLoanCreate_Click;
            // 
            // dgvLoans
            // 
            dgvLoans.AllowUserToAddRows = false;
            dgvLoans.AllowUserToDeleteRows = false;
            dgvLoans.AllowUserToResizeColumns = false;
            dgvLoans.AllowUserToResizeRows = false;
            dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoans.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoans.BackgroundColor = Color.FromArgb(255, 255, 128);
            dgvLoans.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvLoans.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoans.GridColor = Color.FromArgb(230, 239, 245);
            dgvLoans.Location = new Point(4, 3);
            dgvLoans.Margin = new Padding(4, 3, 4, 3);
            dgvLoans.MultiSelect = false;
            dgvLoans.Name = "dgvLoans";
            dgvLoans.ReadOnly = true;
            dgvLoans.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoans.ShowCellErrors = false;
            dgvLoans.ShowCellToolTips = false;
            dgvLoans.ShowEditingIcon = false;
            dgvLoans.ShowRowErrors = false;
            dgvLoans.Size = new Size(889, 374);
            dgvLoans.TabIndex = 23;
            // 
            // tpPayment
            // 
            tpPayment.BackColor = Color.FromArgb(255, 255, 128);
            tpPayment.Controls.Add(btnPaymentDelete);
            tpPayment.Controls.Add(btnPaymentReload);
            tpPayment.Controls.Add(btnPaymentCreate);
            tpPayment.Controls.Add(dgvPayments);
            tpPayment.Location = new Point(4, 24);
            tpPayment.Margin = new Padding(4, 3, 4, 3);
            tpPayment.Name = "tpPayment";
            tpPayment.Size = new Size(897, 416);
            tpPayment.TabIndex = 3;
            tpPayment.Text = "Payments";
            // 
            // btnPaymentDelete
            // 
            btnPaymentDelete.Font = new Font("Lucida Console", 8.25F);
            btnPaymentDelete.Location = new Point(216, 384);
            btnPaymentDelete.Margin = new Padding(4, 3, 4, 3);
            btnPaymentDelete.Name = "btnPaymentDelete";
            btnPaymentDelete.Size = new Size(78, 27);
            btnPaymentDelete.TabIndex = 32;
            btnPaymentDelete.Text = "Delete";
            btnPaymentDelete.UseVisualStyleBackColor = true;
            btnPaymentDelete.Click += btnPaymentDelete_Click;
            // 
            // btnPaymentReload
            // 
            btnPaymentReload.Font = new Font("Lucida Console", 8.25F);
            btnPaymentReload.Location = new Point(133, 384);
            btnPaymentReload.Margin = new Padding(4, 3, 4, 3);
            btnPaymentReload.Name = "btnPaymentReload";
            btnPaymentReload.Size = new Size(76, 27);
            btnPaymentReload.TabIndex = 31;
            btnPaymentReload.Text = "Reload";
            btnPaymentReload.UseVisualStyleBackColor = true;
            btnPaymentReload.Click += btnPaymentReload_Click;
            // 
            // btnPaymentCreate
            // 
            btnPaymentCreate.Font = new Font("Lucida Console", 8.25F);
            btnPaymentCreate.Location = new Point(4, 384);
            btnPaymentCreate.Margin = new Padding(4, 3, 4, 3);
            btnPaymentCreate.Name = "btnPaymentCreate";
            btnPaymentCreate.Size = new Size(122, 27);
            btnPaymentCreate.TabIndex = 30;
            btnPaymentCreate.Text = "Make Payment";
            btnPaymentCreate.UseVisualStyleBackColor = true;
            btnPaymentCreate.Click += btnPaymentCreate_Click;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeColumns = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPayments.BackgroundColor = Color.FromArgb(255, 255, 128);
            dgvPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvPayments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPayments.GridColor = Color.FromArgb(230, 239, 245);
            dgvPayments.Location = new Point(4, 3);
            dgvPayments.Margin = new Padding(4, 3, 4, 3);
            dgvPayments.MultiSelect = false;
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.ShowCellErrors = false;
            dgvPayments.ShowCellToolTips = false;
            dgvPayments.ShowEditingIcon = false;
            dgvPayments.ShowRowErrors = false;
            dgvPayments.Size = new Size(889, 374);
            dgvPayments.TabIndex = 29;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 153);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 9);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(205, 24);
            label2.TabIndex = 9;
            label2.Text = "CURRENT STACK";
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Lucida Console", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1546, 115);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(192, 36);
            button3.TabIndex = 12;
            button3.Text = "back";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGoldenrod;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(14, 2);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 152);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // FormView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 128);
            ClientSize = new Size(923, 608);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View";
            Load += FormView_Load;
            tabControl1.ResumeLayout(false);
            tpCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tpItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            tpLoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            tpPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCustomer;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnCustomerCreate;
        private System.Windows.Forms.TabPage tpItem;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerReload;
        private TabPage tpLoan;
        private DataGridView dgvLoans;
        private Button btnItemCreate;
        private DataGridView dgvItems;
        private Button btnItemReload;
        private Button btnLoanReload;
        private Button btnLoanCreate;
        private Button btnLoanDelete;
        private Button btnItemDelete;
        private TabPage tpPayment;
        private Button btnPaymentDelete;
        private Button btnPaymentReload;
        private Button btnPaymentCreate;
        private DataGridView dgvPayments;
        private Panel panel1;
        private Label label2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}