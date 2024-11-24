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
            if (dgvItems.SelectedRows.Count < 0)
                throw new Exception("Select an item.");

            DataGridViewRow selectedRow = dgvItems.SelectedRows[0];
            itemId = Convert.ToInt32(selectedRow.Cells[0].Value);

            this.Close();
        }
    }
}
