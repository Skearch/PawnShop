namespace PawnShop
{
    public partial class FormSelector : Form
    {
        public int? itemId;
        List<object> items = new List<object>();

        public FormSelector(List<object> items)
        {
            InitializeComponent();
            this.items = items;
        }

        private void FormSelector_Load(object sender, EventArgs e)
        {
            dgvItems.DataSource = items;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvItems.SelectedRows.Count < 0)
                    throw new Exception("Select an item.");

                DataGridViewRow selectedRow = dgvItems.SelectedRows[0];
                itemId = Convert.ToInt32(selectedRow.Cells[0].Value);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
