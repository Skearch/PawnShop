using PawnShop.Context;
using PawnShop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PawnShop
{
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = tbFirstName.Text;
                string middleName = tbMiddleName.Text;
                string lastName = tbLastName.Text;
                string address = rtbAddress.Text;
                string email = tbEmail.Text;
                string phoneNumber = tbPhoneNumber.Text;

                var pawnShopContext = new PawnShopContext();
                var customerService = new CustomerService(pawnShopContext);
                customerService.CreateRecord(firstName, middleName, lastName, address, email, phoneNumber);
                MessageBox.Show("Customer created successfully!");

                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
