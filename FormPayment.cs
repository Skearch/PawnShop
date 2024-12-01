using PawnShop.Context;
using PawnShop.Entities;
using PawnShop.Enums;
using PawnShop.Services;

namespace PawnShop
{
    public partial class FormPayment : Form
    {
        Payment payment;
        FormMode formMode;

        public FormPayment(Payment payment, FormMode formMode)
        {
            InitializeComponent();
            this.payment = payment;
            this.formMode = formMode;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var pawnShopContext = new PawnShopContext();
                var paymentService = new PaymentService(pawnShopContext);

                switch (formMode)
                {
                    case FormMode.Edit:
                        var editPayment = new Payment()
                        {
                            PaymentID = payment.PaymentID,
                            LoanID = int.Parse(tbLoanID.Text),
                            PaymentAmount = decimal.Parse(tbPaymentAmount.Text),
                            PaymentDate = dtpPaymentDate.Value
                        };

                        paymentService.UpdateRecord(editPayment);
                        this.Close();
                        break;
                    case FormMode.View:
                        this.Close();
                        break;
                    case FormMode.Create:
                        var newPayment = new Payment()
                        {
                            LoanID = int.Parse(tbLoanID.Text),
                            PaymentAmount = decimal.Parse(tbPaymentAmount.Text),
                            PaymentDate = dtpPaymentDate.Value
                        };

                        paymentService.CreatePayment(newPayment);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            if (formMode.Equals(FormMode.Edit) || formMode.Equals(FormMode.View))
            {
                tbLoanID.Text = payment.LoanID.ToString();
                tbPaymentAmount.Text = payment.PaymentAmount.ToString();
                dtpPaymentDate.Value = payment.PaymentDate;
            }

            switch (formMode)
            {
                case FormMode.Edit:
                    btnCreate.Text = "Save";
                    btnViewLoan.Visible = false;
                    break;
                case FormMode.View:
                    foreach (Control control in this.Controls)
                    {
                        if (control is TextBox || control is DateTimePicker)
                            control.Enabled = false;
                    }

                    btnCreate.Text = "Close";
                    btnSelectLoan.Visible = false;
                    break;
                case FormMode.Create:
                    dtpPaymentDate.Value = DateTime.Now;
                    dtpPaymentDate.Enabled = false;
                    btnCreate.Text = "Create";
                    btnViewLoan.Visible = false;
                    break;
            }
        }

        private void btnSelectLoan_Click(object sender, EventArgs e)
        {
            try
            {
                var pawnShopContext = new PawnShopContext();
                var loanService = new LoanService(pawnShopContext);
                var loans = loanService.GetAllLoans().ToList();

                List<object> objectList = loans.Cast<object>().ToList();
                FormSelector formSelector = new FormSelector(objectList);

                formSelector.Show();
                formSelector.FormClosed += (s, args) =>
                {
                    if (formSelector.itemId == null)
                    {
                        tbLoanID.Text = "";
                        return;
                    }

                    int selectedID = formSelector.itemId.Value;
                    tbLoanID.Text = selectedID.ToString();
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewLoan_Click(object sender, EventArgs e)
        {
            try
            {
                var pawnShopContext = new PawnShopContext();
                var loanService = new LoanService(pawnShopContext);
                var loan = loanService.GetLoanById(int.Parse(tbLoanID.Text));
                var formLoan = new FormLoan(loan, FormMode.View);
                formLoan.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}