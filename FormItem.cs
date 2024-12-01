using Microsoft.Data.SqlClient;
using PawnShop.Context;
using PawnShop.Entities;
using PawnShop.Enums;
using PawnShop.Services;
using System.Diagnostics;
using System.Net.Http.Json;

namespace PawnShop
{
    public partial class FormItem : Form
    {
        Item item;
        FormMode formMode;

        public FormItem(Item item, FormMode formMode)
        {
            InitializeComponent();
            this.item = item;
            this.formMode = formMode;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                var itemService = new ItemService(new PawnShopContext());
                var jewelryService = new JewelryService(new PawnShopContext());
                var otherService = new OtherService(new PawnShopContext());
                var itemType = (ItemType)cbItemType.SelectedItem;

                switch (formMode)
                {
                    case FormMode.Edit:
                        var updateJewelry = new Jewelry()
                        {
                            JewelryID = item.JewelryID,
                            MaterialType = (JewelryMaterialType)cbMaterialType.SelectedItem,
                            WeightType = (JewelryWeightType)cbWeightType.SelectedItem,
                            QualityFactor = string.IsNullOrEmpty(tbQualityFactor.Text) ? (double?)null : double.Parse(tbQualityFactor.Text),
                            Purity = string.IsNullOrEmpty(tbPurity.Text) ? (double?)null : double.Parse(tbPurity.Text),
                            MarketPrice = string.IsNullOrEmpty(tbMarketPrice.Text) ? (double?)null : double.Parse(tbMarketPrice.Text),
                            Weight = string.IsNullOrEmpty(tbWeight.Text) ? (double?)null : double.Parse(tbWeight.Text),
                        };
                        jewelryService.UpdateJewelry(updateJewelry);

                        var updateOther = new Other()
                        {
                            OtherID = item.OtherID,
                            Description = string.IsNullOrEmpty(rtbDescription.Text) ? null : rtbDescription.Text,
                        };
                        otherService.UpdateOther(updateOther);

                        var updateItem = new Item()
                        {
                            ItemID = item.ItemID,
                            CustomerID = int.Parse(tbCustomerID.Text),
                            ItemName = tbItemName.Text,
                            ItemValue = decimal.Parse(tbItemValue.Text),
                            PawnDate = dtpPawnDate.Value,
                            ItemType = itemType,
                            JewelryID = updateJewelry.JewelryID,
                            OtherID = updateOther.OtherID
                        };
                        itemService.UpdateRecord(updateItem);

                        this.Close();
                        break;
                    case FormMode.View:
                        this.Close();
                        break;
                    case FormMode.Create:
                        var newJewelry = new Jewelry()
                        {
                            MaterialType = (JewelryMaterialType)cbMaterialType.SelectedItem,
                            WeightType = (JewelryWeightType)cbWeightType.SelectedItem,
                            QualityFactor = string.IsNullOrEmpty(tbQualityFactor.Text) ? (double?)null : double.Parse(tbQualityFactor.Text),
                            Purity = string.IsNullOrEmpty(tbPurity.Text) ? (double?)null : double.Parse(tbPurity.Text),
                            MarketPrice = string.IsNullOrEmpty(tbMarketPrice.Text) ? (double?)null : double.Parse(tbMarketPrice.Text),
                            Weight = string.IsNullOrEmpty(tbWeight.Text) ? (double?)null : double.Parse(tbWeight.Text),
                        };
                        jewelryService.CreateJewelry(newJewelry);

                        var createOther = new Other()
                        {
                            Description = string.IsNullOrEmpty(rtbDescription.Text) ? null : rtbDescription.Text,
                        };
                        otherService.CreateOther(createOther);

                        var newItem = new Item()
                        {
                            CustomerID = int.Parse(tbCustomerID.Text),
                            ItemName = tbItemName.Text,
                            ItemValue = decimal.Parse(tbItemValue.Text),
                            PawnDate = dtpPawnDate.Value,
                            ItemType = itemType,
                            JewelryID = newJewelry.JewelryID,
                            OtherID = createOther.OtherID
                        };
                        itemService.CreateItem(newItem);

                        this.Close();
                        break;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSelectCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var pawnShopContext = new PawnShopContext();
                var customerService = new CustomerService(pawnShopContext);
                var customers = customerService.GetAllCustomers().ToList();

                List<object> objectList = customers.Cast<object>().ToList();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormItem_Load(object sender, EventArgs e)
        {
            cbItemType.DataSource = Enum.GetValues(typeof(ItemType)).Cast<ItemType>().ToList();
            cbMaterialType.DataSource = Enum.GetValues(typeof(JewelryMaterialType)).Cast<JewelryMaterialType>().ToList();
            cbWeightType.DataSource = Enum.GetValues(typeof(JewelryWeightType)).Cast<JewelryWeightType>().ToList();

            if (formMode.Equals(FormMode.Edit) || formMode.Equals(FormMode.View))
            {
                tbCustomerID.Text = item.CustomerID.ToString();
                tbItemName.Text = item.ItemName;
                tbItemValue.Text = item.ItemValue.ToString();
                dtpPawnDate.Value = item.PawnDate;
                cbItemType.SelectedItem = item.ItemType;

                var jewelryService = new JewelryService(new PawnShopContext());
                var jewelry = jewelryService.GetJewelryByID(item.JewelryID);
                cbMaterialType.SelectedItem = jewelry.MaterialType;
                cbWeightType.SelectedItem = jewelry.WeightType;
                tbWeight.Text = jewelry.Weight.ToString();
                tbQualityFactor.Text = jewelry.QualityFactor.ToString();
                tbPurity.Text = jewelry.Purity.ToString();
                tbMarketPrice.Text = jewelry.MarketPrice.ToString();

                var otherService = new OtherService(new PawnShopContext());
                var other = otherService.GetOtherByID(item.OtherID);
                rtbDescription.Text = other.Description;
            }

            switch (formMode)
            {
                case FormMode.Edit:
                    btnViewCustomer.Visible = false;
                    btnCreate.Text = "Save";
                    break;
                case FormMode.View:
                    foreach (Control control in this.Controls)
                    {
                        if (control is TextBox ||
                            control is RichTextBox ||
                            control is DateTimePicker ||
                            control is CheckBox ||
                            control is ComboBox)
                            control.Enabled = false;
                    }

                    btnCreate.Text = "Close";
                    btnSelectCustomer.Visible = false;
                    btnJewelryCompute.Visible = false;
                    break;
                case FormMode.Create:
                    dtpPawnDate.Enabled = false;
                    btnViewCustomer.Visible = false;
                    btnCreate.Text = "Create";
                    break;
            }
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                var pawnShopContext = new PawnShopContext();
                var customerService = new CustomerService(pawnShopContext);
                var customer = customerService.GetCustomerByID(int.Parse(tbCustomerID.Text));
                FormCustomer formCustomer = new FormCustomer(customer, FormMode.View);
                formCustomer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbItemType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemType = (ItemType)cbItemType.SelectedItem;

            switch (itemType)
            {
                case ItemType.Jewelry:
                    gbJewelry.Visible = true;
                    gbOtherItem.Visible = false;
                    break;
                case ItemType.Other:
                    gbJewelry.Visible = false;
                    gbOtherItem.Visible = true;
                    break;
            }
        }

        private void cbMaterialType_SelectedIndexChanged(object sender, EventArgs e)
        {
            gbPurity.Visible = false;
            gbQualityFactor.Visible = false;

            var materialType = (JewelryMaterialType)cbMaterialType.SelectedItem;

            switch (materialType)
            {
                case JewelryMaterialType.Gold:
                case JewelryMaterialType.Silver:
                case JewelryMaterialType.Platinum:
                    gbPurity.Visible = true;
                    break;
            }

            switch (materialType)
            {
                case JewelryMaterialType.Diamond:
                    gbQualityFactor.Visible = true;
                    break;
            }

            switch (materialType)
            {
                case JewelryMaterialType.Gold:
                case JewelryMaterialType.Silver:
                case JewelryMaterialType.Platinum:
                    cbWeightType.SelectedItem = JewelryWeightType.Grams;
                    gbWeight.Text = "Grams";
                    lblMarketPrice.Text = "Market Price per Gram";
                    break;
            }

            switch (materialType)
            {
                case JewelryMaterialType.Diamond:
                    gbWeight.Text = "Carats";
                    lblMarketPrice.Text = "Market Price per Carat";
                    cbWeightType.SelectedItem = JewelryWeightType.Carat;
                    break;
            }
        }

        private void CalculateValue()
        {
            try
            {
                double value = 0.0;
                var material = (JewelryMaterialType)cbMaterialType.SelectedItem;
                double? weight = string.IsNullOrEmpty(tbWeight.Text) ? (double?)null : double.Parse(tbWeight.Text);
                double? marketPrice = string.IsNullOrEmpty(tbMarketPrice.Text) ? (double?)null : double.Parse(tbMarketPrice.Text);
                double? purity = string.IsNullOrEmpty(tbPurity.Text) ? (double?)null : double.Parse(tbPurity.Text);
                double? qualityFactor = string.IsNullOrEmpty(tbQualityFactor.Text) ? (double?)null : double.Parse(tbQualityFactor.Text);

                switch (material)
                {
                    case JewelryMaterialType.Gold:
                    case JewelryMaterialType.Silver:
                    case JewelryMaterialType.Platinum:
                        value = (double)(weight * marketPrice * purity);
                        break;
                    case JewelryMaterialType.Diamond:
                        value = (double)(weight * marketPrice * qualityFactor);
                        break;
                }

                tbItemValue.Text = value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnJewelryCompute_Click(object sender, EventArgs e) => CalculateValue();
    }
}