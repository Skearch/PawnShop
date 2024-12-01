using PawnShop.Context;
using PawnShop.Entities;
using PawnShop.Enums;
using PawnShop.Services;

namespace PawnShop
{
    public partial class FormLoan : Form
    {
        Loan loan;
        FormMode formMode;

        public FormLoan(Loan loan, FormMode formMode)
        {
            InitializeComponent();
            this.loan = loan;
            this.formMode = formMode;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var pawnShopContext = new PawnShopContext();
                var loanService = new LoanService(pawnShopContext);

                switch (formMode)
                {
                    case FormMode.Edit:
                        var editLoan = new Loan()
                        {
                            LoanID = loan.LoanID,
                            ItemID = int.Parse(tbItemID.Text),
                            CustomerID = int.Parse(tbCustomerID.Text),
                            LoanAmount = decimal.Parse(tbLoanAmount.Text),
                            Interest = decimal.Parse(tbInterest.Text),
                            LoanDate = dtpDueDate.Value,
                            DueDate = dtpDueDate.Value,
                            RepaymentDate = dtpRepaymentDate.Value,
                            ProcessingFee = decimal.Parse(tbProcessingFee.Text)
                        };

                        loanService.UpdateRecord(editLoan);
                        this.Close();
                        break;
                    case FormMode.View:
                        this.Close();
                        break;
                    case FormMode.Create:
                        var newLoan = new Loan()
                        {
                            ItemID = int.Parse(tbItemID.Text),
                            CustomerID = int.Parse(tbCustomerID.Text),
                            LoanAmount = decimal.Parse(tbLoanAmount.Text),
                            Interest = decimal.Parse(tbInterest.Text),
                            LoanDate = dtpDueDate.Value,
                            DueDate = dtpDueDate.Value,
                            RepaymentDate = dtpRepaymentDate.Value,
                            ProcessingFee = decimal.Parse(tbProcessingFee.Text)
                        };

                        loanService.CreateLoan(newLoan);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLoan_Load(object sender, EventArgs e)
        {
            if (formMode.Equals(FormMode.Edit) || formMode.Equals(FormMode.View))
            {
                tbItemID.Text = loan.ItemID.ToString();
                tbCustomerID.Text = loan.CustomerID.ToString();
                tbLoanAmount.Text = loan.LoanAmount.ToString();
                tbInterest.Text = loan.Interest.ToString();
                dtpLoanDate.Value = loan.LoanDate;
                dtpDueDate.Value = loan.DueDate;
                dtpRepaymentDate.Value = loan.RepaymentDate.Value;
                tbProcessingFee.Text = loan.ProcessingFee.ToString();
            }

            switch (formMode)
            {
                case FormMode.Edit:
                    btnCreate.Text = "Save";
                    btnCustomerView.Visible = false;
                    btnItemView.Visible = false;
                    tbLoanAmount.Enabled = true;
                    break;
                case FormMode.View:
                    foreach (Control control in this.Controls)
                    {
                        if (control is TextBox || control is DateTimePicker || control is CheckBox)
                            control.Enabled = false;
                    }

                    btnCreate.Text = "Close";
                    btnItemSelect.Visible = false;
                    btnComputeLoan.Visible = false;
                    break;
                case FormMode.Create:
                    btnCreate.Text = "Create";
                    btnItemView.Visible = false;
                    dtpLoanDate.Enabled = false;
                    dtpLoanDate.Value = DateTime.Now;
                    break;
            }
        }

        private void btnItemSelect_Click(object sender, EventArgs e)
        {
            try
            {
                var pawnShopContext = new PawnShopContext();
                var itemService = new ItemService(pawnShopContext);
                var items = itemService.GetAllItems().ToList();

                List<object> objectList = items.Cast<object>().ToList();
                FormSelector formSelector = new FormSelector(objectList);

                formSelector.Show();
                formSelector.FormClosed += (s, args) =>
                {
                    if (formSelector.itemId == null)
                    {
                        tbItemID.Text = "";
                        return;
                    }

                    int selectedID = formSelector.itemId.Value;
                    tbItemID.Text = selectedID.ToString();

                    var item = itemService.GetItemById(selectedID);

                    int customerID = itemService.GetCustomerIDByItemID(item.ItemID);
                    tbCustomerID.Text = customerID.ToString();

                    decimal itemAmount = item.ItemValue;
                    decimal interestRate = item.ItemValue;

                };
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
                var pawnShopContext = new PawnShopContext();
                var itemService = new ItemService(pawnShopContext);
                var item = itemService.GetItemById(int.Parse(tbItemID.Text));
                var formItem = new FormItem(item, FormMode.View);
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
                var pawnShopContext = new PawnShopContext();
                var customerService = new CustomerService(pawnShopContext);
                var customer = customerService.GetCustomerByID(int.Parse(tbCustomerID.Text));
                var formCustomer = new FormCustomer(customer, FormMode.View);
                formCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnComputeLoan_Click(object sender, EventArgs e)
        {
            try
            {
                var itemService = new ItemService(new PawnShopContext());
                var selectedItem = itemService.GetItemById(int.Parse(tbItemID.Text.ToString()));
                decimal? interest = string.IsNullOrEmpty(tbInterest.Text) ? (decimal?)null : decimal.Parse(tbInterest.Text);
                decimal? proccessFee = string.IsNullOrEmpty(tbProcessingFee.Text) ? (decimal?)null : decimal.Parse(tbProcessingFee.Text);
                var item = itemService.GetItemById(selectedItem.ItemID);
                decimal itemValue = item.ItemValue;

                decimal loanAmount = (decimal)(itemValue + interest - proccessFee);
                tbLoanAmount.Text = loanAmount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}