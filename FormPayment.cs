using PawnShop.Context;
using PawnShop.Enums;
using PawnShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShop
{
    public partial class FormPayment : Form
    {
        public FormPayment()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int loanId = int.Parse(tbLoanID.Text);
                decimal paymentAmount = decimal.Parse(tbPaymentAmount.Text);
                DateTime paymentDate = DateTime.Now;

                var pawnShopContext = new PawnShopContext();
                var paymentService = new PaymentService(new PawnShopContext());
                paymentService.CreatePayment(loanId, paymentAmount, paymentDate);

                MessageBox.Show("Payment created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectLoan_Click(object sender, EventArgs e)
        {
            var pawnShopContext = new PawnShopContext();
            var loanService = new LoanService(pawnShopContext);
            var items = loanService.GetAllLoans().ToList();

            List<object> objectList = items.Cast<object>().ToList();
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
    }
}
