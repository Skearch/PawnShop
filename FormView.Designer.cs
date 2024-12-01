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
            tbMain = new TabControl();
            tpItem = new TabPage();
            flowLayoutPanel3 = new FlowLayoutPanel();
            dgvItems = new DataGridView();
            btnItemDelete = new Button();
            btnItemCreate = new Button();
            btnItemUpdate = new Button();
            btnItemView = new Button();
            btnItemReload = new Button();
            tpCustomer = new TabPage();
            flowLayoutPanel4 = new FlowLayoutPanel();
            dgvCustomers = new DataGridView();
            btnCustomerDelete = new Button();
            btnCustomerCreate = new Button();
            btnCustomerUpdate = new Button();
            btnCustomerView = new Button();
            btnCustomerReload = new Button();
            tpLoan = new TabPage();
            flowLayoutPanel2 = new FlowLayoutPanel();
            dgvLoans = new DataGridView();
            btnLoanDelete = new Button();
            btnLoanCreate = new Button();
            btnLoanUpdate = new Button();
            btnLoanView = new Button();
            btnLoanReload = new Button();
            tpPayment = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            dgvPayments = new DataGridView();
            btnPaymentDelete = new Button();
            btnPaymentCreate = new Button();
            btnPaymentUpdate = new Button();
            btnPaymentView = new Button();
            btnPaymentReload = new Button();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            tbMain.SuspendLayout();
            tpItem.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            tpCustomer.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tpLoan.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).BeginInit();
            tpPayment.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbMain
            // 
            tbMain.Controls.Add(tpItem);
            tbMain.Controls.Add(tpCustomer);
            tbMain.Controls.Add(tpLoan);
            tbMain.Controls.Add(tpPayment);
            tbMain.Dock = DockStyle.Fill;
            tbMain.Font = new Font("Lucida Console", 12F);
            tbMain.Location = new Point(0, 153);
            tbMain.Margin = new Padding(4, 3, 4, 3);
            tbMain.Multiline = true;
            tbMain.Name = "tbMain";
            tbMain.SelectedIndex = 0;
            tbMain.Size = new Size(923, 455);
            tbMain.TabIndex = 0;
            // 
            // tpItem
            // 
            tpItem.BackColor = Color.DarkGoldenrod;
            tpItem.Controls.Add(flowLayoutPanel3);
            tpItem.Location = new Point(4, 26);
            tpItem.Margin = new Padding(4, 3, 4, 3);
            tpItem.Name = "tpItem";
            tpItem.Size = new Size(915, 425);
            tpItem.TabIndex = 1;
            tpItem.Text = "Items";
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(dgvItems);
            flowLayoutPanel3.Controls.Add(btnItemDelete);
            flowLayoutPanel3.Controls.Add(btnItemCreate);
            flowLayoutPanel3.Controls.Add(btnItemUpdate);
            flowLayoutPanel3.Controls.Add(btnItemView);
            flowLayoutPanel3.Controls.Add(btnItemReload);
            flowLayoutPanel3.Dock = DockStyle.Fill;
            flowLayoutPanel3.Location = new Point(0, 0);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(915, 425);
            flowLayoutPanel3.TabIndex = 29;
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToAddRows = false;
            dgvItems.AllowUserToDeleteRows = false;
            dgvItems.AllowUserToResizeColumns = false;
            dgvItems.AllowUserToResizeRows = false;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvItems.BackgroundColor = Color.Goldenrod;
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
            // btnItemDelete
            // 
            btnItemDelete.AutoSize = true;
            btnItemDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnItemDelete.BackColor = Color.Crimson;
            btnItemDelete.FlatStyle = FlatStyle.Flat;
            btnItemDelete.Font = new Font("Lucida Console", 12F);
            btnItemDelete.ForeColor = Color.White;
            btnItemDelete.Location = new Point(4, 383);
            btnItemDelete.Margin = new Padding(4, 3, 4, 3);
            btnItemDelete.Name = "btnItemDelete";
            btnItemDelete.Size = new Size(79, 28);
            btnItemDelete.TabIndex = 26;
            btnItemDelete.Text = "Delete";
            btnItemDelete.UseVisualStyleBackColor = false;
            btnItemDelete.Click += btnItemDelete_Click;
            // 
            // btnItemCreate
            // 
            btnItemCreate.AutoSize = true;
            btnItemCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnItemCreate.BackColor = Color.Goldenrod;
            btnItemCreate.FlatStyle = FlatStyle.Flat;
            btnItemCreate.Font = new Font("Lucida Console", 12F);
            btnItemCreate.ForeColor = Color.White;
            btnItemCreate.Location = new Point(91, 383);
            btnItemCreate.Margin = new Padding(4, 3, 4, 3);
            btnItemCreate.Name = "btnItemCreate";
            btnItemCreate.Size = new Size(79, 28);
            btnItemCreate.TabIndex = 23;
            btnItemCreate.Text = "Create";
            btnItemCreate.UseVisualStyleBackColor = false;
            btnItemCreate.Click += btnItemCreate_Click;
            // 
            // btnItemUpdate
            // 
            btnItemUpdate.AutoSize = true;
            btnItemUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnItemUpdate.BackColor = Color.Goldenrod;
            btnItemUpdate.FlatStyle = FlatStyle.Flat;
            btnItemUpdate.Font = new Font("Lucida Console", 12F);
            btnItemUpdate.ForeColor = Color.White;
            btnItemUpdate.Location = new Point(178, 383);
            btnItemUpdate.Margin = new Padding(4, 3, 4, 3);
            btnItemUpdate.Name = "btnItemUpdate";
            btnItemUpdate.Size = new Size(79, 28);
            btnItemUpdate.TabIndex = 28;
            btnItemUpdate.Text = "Update";
            btnItemUpdate.UseVisualStyleBackColor = false;
            btnItemUpdate.Click += btnItemUpdate_Click;
            // 
            // btnItemView
            // 
            btnItemView.AutoSize = true;
            btnItemView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnItemView.BackColor = Color.Goldenrod;
            btnItemView.FlatStyle = FlatStyle.Flat;
            btnItemView.Font = new Font("Lucida Console", 12F);
            btnItemView.ForeColor = Color.White;
            btnItemView.Location = new Point(265, 383);
            btnItemView.Margin = new Padding(4, 3, 4, 3);
            btnItemView.Name = "btnItemView";
            btnItemView.Size = new Size(59, 28);
            btnItemView.TabIndex = 27;
            btnItemView.Text = "View";
            btnItemView.UseVisualStyleBackColor = false;
            btnItemView.Click += btnItemView_Click;
            // 
            // btnItemReload
            // 
            btnItemReload.AutoSize = true;
            btnItemReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnItemReload.BackColor = Color.Goldenrod;
            btnItemReload.FlatStyle = FlatStyle.Flat;
            btnItemReload.Font = new Font("Lucida Console", 12F);
            btnItemReload.ForeColor = Color.White;
            btnItemReload.Location = new Point(332, 383);
            btnItemReload.Margin = new Padding(4, 3, 4, 3);
            btnItemReload.Name = "btnItemReload";
            btnItemReload.Size = new Size(79, 28);
            btnItemReload.TabIndex = 25;
            btnItemReload.Text = "Reload";
            btnItemReload.UseVisualStyleBackColor = false;
            btnItemReload.Click += btnItemReload_Click;
            // 
            // tpCustomer
            // 
            tpCustomer.BackColor = Color.DarkGoldenrod;
            tpCustomer.Controls.Add(flowLayoutPanel4);
            tpCustomer.Location = new Point(4, 26);
            tpCustomer.Margin = new Padding(4, 3, 4, 3);
            tpCustomer.Name = "tpCustomer";
            tpCustomer.Size = new Size(915, 425);
            tpCustomer.TabIndex = 0;
            tpCustomer.Text = "Customers";
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.Controls.Add(dgvCustomers);
            flowLayoutPanel4.Controls.Add(btnCustomerDelete);
            flowLayoutPanel4.Controls.Add(btnCustomerCreate);
            flowLayoutPanel4.Controls.Add(btnCustomerUpdate);
            flowLayoutPanel4.Controls.Add(btnCustomerView);
            flowLayoutPanel4.Controls.Add(btnCustomerReload);
            flowLayoutPanel4.Dock = DockStyle.Fill;
            flowLayoutPanel4.Location = new Point(0, 0);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(915, 425);
            flowLayoutPanel4.TabIndex = 25;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AllowUserToDeleteRows = false;
            dgvCustomers.AllowUserToResizeColumns = false;
            dgvCustomers.AllowUserToResizeRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCustomers.BackgroundColor = Color.Goldenrod;
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
            // btnCustomerDelete
            // 
            btnCustomerDelete.AutoSize = true;
            btnCustomerDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomerDelete.BackColor = Color.Crimson;
            btnCustomerDelete.FlatStyle = FlatStyle.Flat;
            btnCustomerDelete.Font = new Font("Lucida Console", 12F);
            btnCustomerDelete.ForeColor = Color.White;
            btnCustomerDelete.Location = new Point(4, 383);
            btnCustomerDelete.Margin = new Padding(4, 3, 4, 3);
            btnCustomerDelete.Name = "btnCustomerDelete";
            btnCustomerDelete.Size = new Size(79, 28);
            btnCustomerDelete.TabIndex = 4;
            btnCustomerDelete.Text = "Delete";
            btnCustomerDelete.UseVisualStyleBackColor = false;
            btnCustomerDelete.Click += btnCustomerDelete_Click;
            // 
            // btnCustomerCreate
            // 
            btnCustomerCreate.AutoSize = true;
            btnCustomerCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomerCreate.BackColor = Color.Goldenrod;
            btnCustomerCreate.FlatStyle = FlatStyle.Flat;
            btnCustomerCreate.Font = new Font("Lucida Console", 12F);
            btnCustomerCreate.ForeColor = Color.White;
            btnCustomerCreate.Location = new Point(91, 383);
            btnCustomerCreate.Margin = new Padding(4, 3, 4, 3);
            btnCustomerCreate.Name = "btnCustomerCreate";
            btnCustomerCreate.Size = new Size(79, 28);
            btnCustomerCreate.TabIndex = 1;
            btnCustomerCreate.Text = "Create";
            btnCustomerCreate.UseVisualStyleBackColor = false;
            btnCustomerCreate.Click += btnCustomerCreate_Click;
            // 
            // btnCustomerUpdate
            // 
            btnCustomerUpdate.AutoSize = true;
            btnCustomerUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomerUpdate.BackColor = Color.Goldenrod;
            btnCustomerUpdate.FlatStyle = FlatStyle.Flat;
            btnCustomerUpdate.Font = new Font("Lucida Console", 12F);
            btnCustomerUpdate.ForeColor = Color.White;
            btnCustomerUpdate.Location = new Point(178, 383);
            btnCustomerUpdate.Margin = new Padding(4, 3, 4, 3);
            btnCustomerUpdate.Name = "btnCustomerUpdate";
            btnCustomerUpdate.Size = new Size(79, 28);
            btnCustomerUpdate.TabIndex = 24;
            btnCustomerUpdate.Text = "Update";
            btnCustomerUpdate.UseVisualStyleBackColor = false;
            btnCustomerUpdate.Click += btnCustomerUpdate_Click;
            // 
            // btnCustomerView
            // 
            btnCustomerView.AutoSize = true;
            btnCustomerView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomerView.BackColor = Color.Goldenrod;
            btnCustomerView.FlatStyle = FlatStyle.Flat;
            btnCustomerView.Font = new Font("Lucida Console", 12F);
            btnCustomerView.ForeColor = Color.White;
            btnCustomerView.Location = new Point(265, 383);
            btnCustomerView.Margin = new Padding(4, 3, 4, 3);
            btnCustomerView.Name = "btnCustomerView";
            btnCustomerView.Size = new Size(59, 28);
            btnCustomerView.TabIndex = 23;
            btnCustomerView.Text = "View";
            btnCustomerView.UseVisualStyleBackColor = false;
            btnCustomerView.Click += btnCustomerView_Click;
            // 
            // btnCustomerReload
            // 
            btnCustomerReload.AutoSize = true;
            btnCustomerReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCustomerReload.BackColor = Color.Goldenrod;
            btnCustomerReload.FlatStyle = FlatStyle.Flat;
            btnCustomerReload.Font = new Font("Lucida Console", 12F);
            btnCustomerReload.ForeColor = Color.White;
            btnCustomerReload.Location = new Point(332, 383);
            btnCustomerReload.Margin = new Padding(4, 3, 4, 3);
            btnCustomerReload.Name = "btnCustomerReload";
            btnCustomerReload.Size = new Size(79, 28);
            btnCustomerReload.TabIndex = 5;
            btnCustomerReload.Text = "Reload";
            btnCustomerReload.UseVisualStyleBackColor = false;
            btnCustomerReload.Click += btnCustomerReload_Click;
            // 
            // tpLoan
            // 
            tpLoan.BackColor = Color.DarkGoldenrod;
            tpLoan.Controls.Add(flowLayoutPanel2);
            tpLoan.Location = new Point(4, 26);
            tpLoan.Margin = new Padding(4, 3, 4, 3);
            tpLoan.Name = "tpLoan";
            tpLoan.Size = new Size(915, 425);
            tpLoan.TabIndex = 2;
            tpLoan.Text = "Loans";
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(dgvLoans);
            flowLayoutPanel2.Controls.Add(btnLoanDelete);
            flowLayoutPanel2.Controls.Add(btnLoanCreate);
            flowLayoutPanel2.Controls.Add(btnLoanUpdate);
            flowLayoutPanel2.Controls.Add(btnLoanView);
            flowLayoutPanel2.Controls.Add(btnLoanReload);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(915, 425);
            flowLayoutPanel2.TabIndex = 31;
            // 
            // dgvLoans
            // 
            dgvLoans.AllowUserToAddRows = false;
            dgvLoans.AllowUserToDeleteRows = false;
            dgvLoans.AllowUserToResizeColumns = false;
            dgvLoans.AllowUserToResizeRows = false;
            dgvLoans.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoans.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLoans.BackgroundColor = Color.Goldenrod;
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
            // btnLoanDelete
            // 
            btnLoanDelete.AutoSize = true;
            btnLoanDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoanDelete.BackColor = Color.Crimson;
            btnLoanDelete.FlatStyle = FlatStyle.Flat;
            btnLoanDelete.Font = new Font("Lucida Console", 12F);
            btnLoanDelete.ForeColor = Color.White;
            btnLoanDelete.Location = new Point(4, 383);
            btnLoanDelete.Margin = new Padding(4, 3, 4, 3);
            btnLoanDelete.Name = "btnLoanDelete";
            btnLoanDelete.Size = new Size(79, 28);
            btnLoanDelete.TabIndex = 32;
            btnLoanDelete.Text = "Delete";
            btnLoanDelete.UseVisualStyleBackColor = false;
            btnLoanDelete.Click += btnLoanDelete_Click;
            // 
            // btnLoanCreate
            // 
            btnLoanCreate.AutoSize = true;
            btnLoanCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoanCreate.BackColor = Color.Goldenrod;
            btnLoanCreate.FlatStyle = FlatStyle.Flat;
            btnLoanCreate.Font = new Font("Lucida Console", 12F);
            btnLoanCreate.ForeColor = Color.White;
            btnLoanCreate.Location = new Point(91, 383);
            btnLoanCreate.Margin = new Padding(4, 3, 4, 3);
            btnLoanCreate.Name = "btnLoanCreate";
            btnLoanCreate.Size = new Size(79, 28);
            btnLoanCreate.TabIndex = 31;
            btnLoanCreate.Text = "Create";
            btnLoanCreate.UseVisualStyleBackColor = false;
            btnLoanCreate.Click += btnLoanCreate_Click;
            // 
            // btnLoanUpdate
            // 
            btnLoanUpdate.AutoSize = true;
            btnLoanUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoanUpdate.BackColor = Color.Goldenrod;
            btnLoanUpdate.FlatStyle = FlatStyle.Flat;
            btnLoanUpdate.Font = new Font("Lucida Console", 12F);
            btnLoanUpdate.ForeColor = Color.White;
            btnLoanUpdate.Location = new Point(178, 383);
            btnLoanUpdate.Margin = new Padding(4, 3, 4, 3);
            btnLoanUpdate.Name = "btnLoanUpdate";
            btnLoanUpdate.Size = new Size(79, 28);
            btnLoanUpdate.TabIndex = 30;
            btnLoanUpdate.Text = "Update";
            btnLoanUpdate.UseVisualStyleBackColor = false;
            btnLoanUpdate.Click += btnLoanUpdate_Click;
            // 
            // btnLoanView
            // 
            btnLoanView.AutoSize = true;
            btnLoanView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoanView.BackColor = Color.Goldenrod;
            btnLoanView.FlatStyle = FlatStyle.Flat;
            btnLoanView.Font = new Font("Lucida Console", 12F);
            btnLoanView.ForeColor = Color.White;
            btnLoanView.Location = new Point(265, 383);
            btnLoanView.Margin = new Padding(4, 3, 4, 3);
            btnLoanView.Name = "btnLoanView";
            btnLoanView.Size = new Size(59, 28);
            btnLoanView.TabIndex = 29;
            btnLoanView.Text = "View";
            btnLoanView.UseVisualStyleBackColor = false;
            btnLoanView.Click += btnLoanView_Click;
            // 
            // btnLoanReload
            // 
            btnLoanReload.AutoSize = true;
            btnLoanReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLoanReload.BackColor = Color.Goldenrod;
            btnLoanReload.FlatStyle = FlatStyle.Flat;
            btnLoanReload.Font = new Font("Lucida Console", 12F);
            btnLoanReload.ForeColor = Color.White;
            btnLoanReload.Location = new Point(332, 383);
            btnLoanReload.Margin = new Padding(4, 3, 4, 3);
            btnLoanReload.Name = "btnLoanReload";
            btnLoanReload.Size = new Size(79, 28);
            btnLoanReload.TabIndex = 27;
            btnLoanReload.Text = "Reload";
            btnLoanReload.UseVisualStyleBackColor = false;
            btnLoanReload.Click += btnLoanReload_Click;
            // 
            // tpPayment
            // 
            tpPayment.BackColor = Color.DarkGoldenrod;
            tpPayment.Controls.Add(flowLayoutPanel1);
            tpPayment.Location = new Point(4, 26);
            tpPayment.Margin = new Padding(4, 3, 4, 3);
            tpPayment.Name = "tpPayment";
            tpPayment.Size = new Size(915, 425);
            tpPayment.TabIndex = 3;
            tpPayment.Text = "Payments";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(dgvPayments);
            flowLayoutPanel1.Controls.Add(btnPaymentDelete);
            flowLayoutPanel1.Controls.Add(btnPaymentCreate);
            flowLayoutPanel1.Controls.Add(btnPaymentUpdate);
            flowLayoutPanel1.Controls.Add(btnPaymentView);
            flowLayoutPanel1.Controls.Add(btnPaymentReload);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(915, 425);
            flowLayoutPanel1.TabIndex = 35;
            // 
            // dgvPayments
            // 
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeColumns = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPayments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPayments.BackgroundColor = Color.Goldenrod;
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
            // btnPaymentDelete
            // 
            btnPaymentDelete.AutoSize = true;
            btnPaymentDelete.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaymentDelete.BackColor = Color.Crimson;
            btnPaymentDelete.FlatStyle = FlatStyle.Flat;
            btnPaymentDelete.Font = new Font("Lucida Console", 12F);
            btnPaymentDelete.ForeColor = Color.White;
            btnPaymentDelete.Location = new Point(4, 383);
            btnPaymentDelete.Margin = new Padding(4, 3, 4, 3);
            btnPaymentDelete.Name = "btnPaymentDelete";
            btnPaymentDelete.Size = new Size(79, 28);
            btnPaymentDelete.TabIndex = 32;
            btnPaymentDelete.Text = "Delete";
            btnPaymentDelete.UseVisualStyleBackColor = false;
            btnPaymentDelete.Click += btnPaymentDelete_Click;
            // 
            // btnPaymentCreate
            // 
            btnPaymentCreate.AutoSize = true;
            btnPaymentCreate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaymentCreate.BackColor = Color.Goldenrod;
            btnPaymentCreate.FlatStyle = FlatStyle.Flat;
            btnPaymentCreate.Font = new Font("Lucida Console", 12F);
            btnPaymentCreate.ForeColor = Color.White;
            btnPaymentCreate.Location = new Point(91, 383);
            btnPaymentCreate.Margin = new Padding(4, 3, 4, 3);
            btnPaymentCreate.Name = "btnPaymentCreate";
            btnPaymentCreate.Size = new Size(79, 28);
            btnPaymentCreate.TabIndex = 30;
            btnPaymentCreate.Text = "Create";
            btnPaymentCreate.UseVisualStyleBackColor = false;
            btnPaymentCreate.Click += btnPaymentCreate_Click;
            // 
            // btnPaymentUpdate
            // 
            btnPaymentUpdate.AutoSize = true;
            btnPaymentUpdate.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaymentUpdate.BackColor = Color.Goldenrod;
            btnPaymentUpdate.FlatStyle = FlatStyle.Flat;
            btnPaymentUpdate.Font = new Font("Lucida Console", 12F);
            btnPaymentUpdate.ForeColor = Color.White;
            btnPaymentUpdate.Location = new Point(178, 383);
            btnPaymentUpdate.Margin = new Padding(4, 3, 4, 3);
            btnPaymentUpdate.Name = "btnPaymentUpdate";
            btnPaymentUpdate.Size = new Size(79, 28);
            btnPaymentUpdate.TabIndex = 34;
            btnPaymentUpdate.Text = "Update";
            btnPaymentUpdate.UseVisualStyleBackColor = false;
            btnPaymentUpdate.Click += btnPaymentUpdate_Click;
            // 
            // btnPaymentView
            // 
            btnPaymentView.AutoSize = true;
            btnPaymentView.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaymentView.BackColor = Color.Goldenrod;
            btnPaymentView.FlatStyle = FlatStyle.Flat;
            btnPaymentView.Font = new Font("Lucida Console", 12F);
            btnPaymentView.ForeColor = Color.White;
            btnPaymentView.Location = new Point(265, 383);
            btnPaymentView.Margin = new Padding(4, 3, 4, 3);
            btnPaymentView.Name = "btnPaymentView";
            btnPaymentView.Size = new Size(59, 28);
            btnPaymentView.TabIndex = 33;
            btnPaymentView.Text = "View";
            btnPaymentView.UseVisualStyleBackColor = false;
            btnPaymentView.Click += btnPaymentView_Click;
            // 
            // btnPaymentReload
            // 
            btnPaymentReload.AutoSize = true;
            btnPaymentReload.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPaymentReload.BackColor = Color.Goldenrod;
            btnPaymentReload.FlatStyle = FlatStyle.Flat;
            btnPaymentReload.Font = new Font("Lucida Console", 12F);
            btnPaymentReload.ForeColor = Color.White;
            btnPaymentReload.Location = new Point(332, 383);
            btnPaymentReload.Margin = new Padding(4, 3, 4, 3);
            btnPaymentReload.Name = "btnPaymentReload";
            btnPaymentReload.Size = new Size(79, 28);
            btnPaymentReload.TabIndex = 31;
            btnPaymentReload.Text = "Reload";
            btnPaymentReload.UseVisualStyleBackColor = false;
            btnPaymentReload.Click += btnPaymentReload_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Goldenrod;
            panel1.Controls.Add(label2);
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
            label2.Font = new Font("Lucida Console", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(548, 65);
            label2.TabIndex = 9;
            label2.Text = "CURRENT STACK";
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
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(923, 608);
            Controls.Add(tbMain);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View";
            FormClosing += FormView_FormClosing;
            Load += FormView_Load;
            tbMain.ResumeLayout(false);
            tpItem.ResumeLayout(false);
            flowLayoutPanel3.ResumeLayout(false);
            flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            tpCustomer.ResumeLayout(false);
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tpLoan.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoans).EndInit();
            tpPayment.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tbMain;
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
        private Button btnItemDelete;
        private TabPage tpPayment;
        private Button btnPaymentDelete;
        private Button btnPaymentReload;
        private Button btnPaymentCreate;
        private DataGridView dgvPayments;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button btnCustomerView;
        private Button btnItemView;
        private Button btnLoanView;
        private Button btnPaymentView;
        private Button btnCustomerUpdate;
        private Button btnItemUpdate;
        private Button btnLoanUpdate;
        private Button btnPaymentUpdate;
        private FlowLayoutPanel flowLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private Button btnLoanDelete;
        private Button btnLoanCreate;
    }
}