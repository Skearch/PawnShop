using PawnShop.Context;
using PawnShop.Enums;
using PawnShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShop
{
    public partial class FormLoan : Form
    {
        public FormLoan()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int itemId = int.Parse(tbItemID.Text);
                decimal loanAmount = decimal.Parse(tbLoanAmount.Text);
                decimal interestRate = decimal.Parse(tbInterestRate.Text);
                DateTime loanDate = DateTime.Now;
                DateTime dueDate = dtpDueDate.Value;
                LoanStatus status = (LoanStatus)cbStatus.SelectedItem;

                var pawnShopContext = new PawnShopContext();
                var loanService = new LoanService(new PawnShopContext());
                loanService.CreateLoan(itemId, loanAmount, interestRate, loanDate, dueDate, status);

                MessageBox.Show("Loan created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLoan_Load(object sender, EventArgs e)
        {
            cbStatus.DataSource = Enum.GetValues(typeof(LoanStatus)).Cast<LoanStatus>().ToList();
            cbStatus.SelectedIndex = 0;
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
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
            };
        }
    }
}
