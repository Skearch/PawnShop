using PawnShop.Context;

namespace PawnShop
{
    public partial class FormLogin : Form
    {
        private int AccessCode = 12345;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            try
            {
                int InputCode = int.Parse(tbAccessCode.Text);

                if (InputCode != AccessCode)
                {
                    MessageBox.Show("Invalid Access Code. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FormView formView = new FormView();
                formView.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            using (var databaseContext = new PawnShopContext())
                databaseContext.Database.EnsureCreated();
        }
    }
}