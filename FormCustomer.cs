using PawnShop.Context;
using PawnShop.Entities;
using PawnShop.Enums;
using PawnShop.Services;

namespace PawnShop
{
    public partial class FormCustomer : Form
    {
        Customer customer;
        FormMode formMode;

        public FormCustomer(Customer customer, FormMode formMode)
        {
            InitializeComponent();
            this.customer = customer;
            this.formMode = formMode;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var pawnShopContext = new PawnShopContext();
                var customerService = new CustomerService(pawnShopContext);

                switch (formMode)
                {
                    case FormMode.Edit:
                        var editCustomer = new Customer()
                        {
                            CustomerID = customer.CustomerID,
                            FirstName = tbFirstName.Text,
                            MiddleName = tbMiddleName.Text,
                            LastName = tbLastName.Text,
                            Address = rtbAddress.Text,
                            Email = tbEmail.Text,
                            PhoneNumber = tbPhoneNumber.Text,
                            IdentificationType = (IdentificationType)cbIdentificationType.SelectedItem,
                            IdentificationNumber = tbIdentificationNumber.Text
                        };

                        customerService.UpdateRecord(editCustomer);
                        this.Close();
                        break;
                    case FormMode.View:
                        this.Close();
                        break;
                    case FormMode.Create:
                        var newCustomer = new Customer()
                        {
                            FirstName = tbFirstName.Text,
                            MiddleName = tbMiddleName.Text,
                            LastName = tbLastName.Text,
                            Address = rtbAddress.Text,
                            Email = tbEmail.Text,
                            PhoneNumber = tbPhoneNumber.Text,
                            IdentificationType = (IdentificationType)cbIdentificationType.SelectedItem,
                            IdentificationNumber = tbIdentificationNumber.Text
                        };

                        customerService.CreateRecord(newCustomer);
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            cbIdentificationType.DataSource = Enum.GetValues(typeof(IdentificationType)).Cast<IdentificationType>().ToList();

            if (formMode.Equals(FormMode.Edit) || formMode.Equals(FormMode.View))
            {
                tbFirstName.Text = customer.FirstName;
                tbMiddleName.Text = customer.MiddleName;
                tbLastName.Text = customer.LastName;
                rtbAddress.Text = customer.Address;
                tbEmail.Text = customer.Email;
                tbPhoneNumber.Text = customer.PhoneNumber;
                cbIdentificationType.SelectedItem = customer.IdentificationType;
                tbIdentificationNumber.Text = customer.IdentificationNumber;
            }

            switch (formMode)
            {
                case FormMode.Edit:
                    btnCreate.Text = "Save";
                    break;
                case FormMode.View:
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;

                    btnCreate.Text = "Close";
                    break;
                case FormMode.Create:
                    btnCreate.Text = "Create";
                    break;
            }
        }
    }
}