using PawnShop.Context;
using PawnShop.Entities;
using PawnShop.Enums;
using PawnShop.Services;
using System.Diagnostics;

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
            var customers = customerService.GetAllCustomers();
            dgvCustomers.DataSource = customers.Select(s => new
            {
                s.CustomerID,
                FullName = string.IsNullOrEmpty(s.MiddleName) ? $"{s.FirstName} {s.LastName}" : $"{s.FirstName} {s.MiddleName.ToCharArray().First()}. {s.LastName}",
                s.Email,
                s.PhoneNumber
            }).ToList();

            var itemService = new ItemService(pawnShopContext);
            var items = itemService.GetAllItems();
            dgvItems.DataSource = items.Select(s => new
            {
                s.ItemID,
                s.ItemName,
                s.ItemType,
                s.ItemValue,
                s.PawnDate
            }).ToList();

            var loanService = new LoanService(pawnShopContext);
            var loans = loanService.GetAllLoans();
            dgvLoans.DataSource = loans.Select(s => new
            {
                s.LoanID,
                s.LoanAmount,
                Customer = customerService.GetCustomerByID(s.CustomerID) is Customer customer ?
                    (string.IsNullOrEmpty(customer.MiddleName) ? $"{customer.FirstName} {customer.LastName}" : $"{customer.FirstName} {customer.MiddleName.ToCharArray().First()}. {customer.LastName}") : string.Empty,
                s.LoanDate,
                s.RepaymentDate
            }).ToList();

            var paymentService = new PaymentService(pawnShopContext);
            var payments = paymentService.GetAllPayments();
            dgvPayments.DataSource = payments.Select(s => new
            {
                s.PaymentID,
                s.PaymentAmount,
                s.PaymentDate,
            }).ToList();
        }

        private void btnCustomerCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FormCustomer formCustomer = new FormCustomer(null, FormMode.Create);
                formCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void btnLoanReload_Click(object sender, EventArgs e) 
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

        private void btnItemReload_Click(object sender, EventArgs e) 
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
            try
            {
                FormLoan formLoan = new FormLoan(null, FormMode.Create);
                formLoan.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaymentReload_Click(object sender, EventArgs e) 
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
            try
            {
                FormPayment formPayment = new FormPayment(null, FormMode.Create);
                formPayment.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItemCreate_Click(object sender, EventArgs e)
        {
            try
            {
                FormItem formItem = new FormItem(null, FormMode.Create);
                formItem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCustomerView_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedCustomerId();
                var customerService = new CustomerService(new PawnShopContext());
                var customer = customerService.GetCustomerByID(selectedID);
                var formCustomer = new FormCustomer(customer, FormMode.View);
                formCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItemView_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedItemId();
                var itemService = new ItemService(new PawnShopContext());
                var item = itemService.GetItemById(selectedID);
                var formItem = new FormItem(item, FormMode.View);
                formItem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoanView_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedLoanId();
                var loanService = new LoanService(new PawnShopContext());
                var loan = loanService.GetLoanById(selectedID);
                var formLoan = new FormLoan(loan, FormMode.View);
                formLoan.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaymentView_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedPaymentId();
                var paymentService = new PaymentService(new PawnShopContext());
                var payment = paymentService.GetPaymentsById(selectedID);
                var formPayment = new FormPayment(payment, FormMode.View);
                formPayment.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormView_FormClosing(object sender, FormClosingEventArgs e) => Environment.Exit(0);

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedCustomerId();
                var customerService = new CustomerService(new PawnShopContext());
                var customer = customerService.GetCustomerByID(selectedID);
                var formCustomer = new FormCustomer(customer, FormMode.Edit);
                formCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnItemUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedItemId();
                var itemService = new ItemService(new PawnShopContext());
                var item = itemService.GetItemById(selectedID);
                var formItem = new FormItem(item, FormMode.Edit);
                formItem.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoanUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedLoanId();
                var loanService = new LoanService(new PawnShopContext());
                var loan = loanService.GetLoanById(selectedID);
                var formLoan = new FormLoan(loan, FormMode.Edit);
                formLoan.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPaymentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedID = GetSelectedPaymentId();
                var paymentService = new PaymentService(new PawnShopContext());
                var payment = paymentService.GetPaymentsById(selectedID);
                var formPayment = new FormPayment(payment, FormMode.Edit);
                formPayment.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}