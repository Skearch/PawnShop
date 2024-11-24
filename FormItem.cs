using PawnShop.Context;
using PawnShop.Services;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace PawnShop
{
    public partial class FormItem : Form
    {
        public FormItem()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                int customerId = int.Parse(tbCustomerID.Text);
                string itemName = tbItemName.Text;
                string description = rtbDescription.Text;
                decimal estimatedValue = decimal.Parse(tbEstimatedValue.Text);
                DateTime pawnDate = DateTime.Now;

                var pawnShopContext = new PawnShopContext();
                var itemService = new ItemService(pawnShopContext);
                itemService.CreateItem(customerId, itemName, description, estimatedValue, pawnDate);

                MessageBox.Show("Item created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            var pawnShopContext = new PawnShopContext();
            var customerService = new CustomerService(pawnShopContext);
            var test = customerService.GetAllCustomers().ToList();

            List<object> objectList = test.Cast<object>().ToList();
            FormSelector formSelector = new FormSelector(objectList);

            formSelector.Show();
            formSelector.FormClosed += (s, args) =>
            {
                if (formSelector.itemId == null)
                {
                    tbCustomerID.Text = "";
                    return;
                }

                int selectedID = formSelector.itemId.Value;
                tbCustomerID.Text = selectedID.ToString();
            };
        }
    }
}
