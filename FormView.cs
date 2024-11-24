using PawnShop.Context;
using PawnShop.Entities;
using PawnShop.Services;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace PawnShop
{
    public partial class FormView : Form
    {
        public FormView()
        {
            InitializeComponent();
        }

        private int GetSelectedCustomerId()
        {
            DataGridViewRow selectedRow = dgvCustomers.SelectedRows[0];
            int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
            return selectedID;
        }

        private int GetSelectedLoanId()
        {
            DataGridViewRow selectedRow = dgvLoans.SelectedRows[0];
            int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
            return selectedID;
        }

        private int GetSelectedItemId()
        {
            DataGridViewRow selectedRow = dgvItems.SelectedRows[0];
            int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
            return selectedID;
        }

        private int GetSelectedPaymentId()
        {
            DataGridViewRow selectedRow = dgvPayments.SelectedRows[0];
            int selectedID = Convert.ToInt32(selectedRow.Cells[0].Value);
            return selectedID;
        }

        private void Reload()
        {
            var pawnShopContext = new PawnShopContext();

            var customerService = new CustomerService(pawnShopContext);
            List<Customer> customers = customerService.GetAllCustomers();
            dgvCustomers.DataSource = customers;

            var itemService = new ItemService(pawnShopContext);
            List<Item> item = itemService.GetAllItems();
            dgvItems.DataSource = item;

            var loanService = new LoanService(pawnShopContext);
            List<Loan> loans = loanService.GetAllLoans();
            dgvLoans.DataSource = loans;

            var paymentService = new PaymentService(pawnShopContext);
            List<Payment> payments = paymentService.GetAllPayments();
            dgvPayments.DataSource = payments;
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            FormCustomer formCustomer = new FormCustomer();
            formCustomer.Show();
        }

        private void btnCustomerReload_Click(object sender, EventArgs e)
        {
            try
            {
                Reload();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
        }

        private void FormView_Load(object sender, EventArgs e) => Reload();

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedCustomerId();
                var pawnShopContext = new PawnShopContext();
                var customerService = new CustomerService(pawnShopContext);
                customerService.DeleteRecordById(selectedID);
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoanReload_Click(object sender, EventArgs e) => Reload();

        private void btnLoanDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedLoanId();
                var pawnShopContext = new PawnShopContext();
                var loanService = new LoanService(pawnShopContext);
                loanService.DeleteLoan(selectedID);
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItemReload_Click(object sender, EventArgs e) => Reload();

        private void btnItemDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedItemId();
                var pawnShopContext = new PawnShopContext();
                var itemService = new ItemService(pawnShopContext);
                itemService.DeleteItem(selectedID);
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoanCreate_Click(object sender, EventArgs e)
        {
            FormLoan formLoan = new FormLoan();
            formLoan.Show();
        }

        private void btnPaymentReload_Click(object sender, EventArgs e) => Reload();

        private void btnPaymentDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedPaymentId();
                var pawnShopContext = new PawnShopContext();
                var paymentService = new PaymentService(pawnShopContext);
                paymentService.DeletePayment(selectedID);
                Reload();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaymentCreate_Click(object sender, EventArgs e)
        {
            FormPayment formPayment = new FormPayment();
            formPayment.Show();
        }

        private void btnItemCreate_Click(object sender, EventArgs e)
        {
            FormItem formItem = new FormItem();
            formItem.Show();
        }
    }
}