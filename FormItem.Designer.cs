namespace PawnShop
{
    partial class FormItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreate = new Button();
            label4 = new Label();
            tbItemValue = new TextBox();
            label2 = new Label();
            rtbDescription = new RichTextBox();
            tbItemName = new TextBox();
            label1 = new Label();
            tbCustomerID = new TextBox();
            label3 = new Label();
            btnSelectCustomer = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnViewCustomer = new Button();
            dtpPawnDate = new DateTimePicker();
            label12 = new Label();
            label5 = new Label();
            cbItemType = new ComboBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            gbJewelry = new GroupBox();
            btnJewelryCompute = new Button();
            gbWeight = new GroupBox();
            tbWeight = new TextBox();
            gbQualityFactor = new GroupBox();
            tbQualityFactor = new TextBox();
            gbPurity = new GroupBox();
            tbPurity = new TextBox();
            lblMarketPrice = new Label();
            tbMarketPrice = new TextBox();
            cbMaterialType = new ComboBox();
            cbWeightType = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            gbOtherItem = new GroupBox();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            gbJewelry.SuspendLayout();
            gbWeight.SuspendLayout();
            gbQualityFactor.SuspendLayout();
            gbPurity.SuspendLayout();
            gbOtherItem.SuspendLayout();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.FlatStyle = FlatStyle.Flat;
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(517, 291);
            btnCreate.Margin = new Padding(4, 3, 4, 3);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(115, 43);
            btnCreate.TabIndex = 25;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 19);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 20;
            label4.Text = "Description *";
            // 
            // tbItemValue
            // 
            tbItemValue.Location = new Point(14, 74);
            tbItemValue.Margin = new Padding(4, 3, 4, 3);
            tbItemValue.Name = "tbItemValue";
            tbItemValue.Size = new Size(185, 23);
            tbItemValue.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 55);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 16;
            label2.Text = "Item Value *";
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(7, 37);
            rtbDescription.Margin = new Padding(4, 3, 4, 3);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(245, 129);
            rtbDescription.TabIndex = 15;
            rtbDescription.Text = "";
            // 
            // tbItemName
            // 
            tbItemName.Location = new Point(14, 29);
            tbItemName.Margin = new Padding(4, 3, 4, 3);
            tbItemName.Name = "tbItemName";
            tbItemName.Size = new Size(185, 23);
            tbItemName.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 13;
            label1.Text = "Item Name *";
            // 
            // tbCustomerID
            // 
            tbCustomerID.Enabled = false;
            tbCustomerID.Location = new Point(14, 118);
            tbCustomerID.Margin = new Padding(4, 3, 4, 3);
            tbCustomerID.Name = "tbCustomerID";
            tbCustomerID.Size = new Size(185, 23);
            tbCustomerID.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 100);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 27;
            label3.Text = "Customer ID *";
            // 
            // btnSelectCustomer
            // 
            btnSelectCustomer.AutoSize = true;
            btnSelectCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSelectCustomer.Location = new Point(4, 3);
            btnSelectCustomer.Margin = new Padding(4, 3, 4, 3);
            btnSelectCustomer.Name = "btnSelectCustomer";
            btnSelectCustomer.Size = new Size(48, 25);
            btnSelectCustomer.TabIndex = 29;
            btnSelectCustomer.Text = "Select";
            btnSelectCustomer.UseVisualStyleBackColor = true;
            btnSelectCustomer.Click += btnSelectCustomer_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSelectCustomer);
            flowLayoutPanel1.Controls.Add(btnViewCustomer);
            flowLayoutPanel1.Location = new Point(14, 147);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(185, 30);
            flowLayoutPanel1.TabIndex = 30;
            // 
            // btnViewCustomer
            // 
            btnViewCustomer.AutoSize = true;
            btnViewCustomer.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnViewCustomer.Location = new Point(60, 3);
            btnViewCustomer.Margin = new Padding(4, 3, 4, 3);
            btnViewCustomer.Name = "btnViewCustomer";
            btnViewCustomer.Size = new Size(42, 25);
            btnViewCustomer.TabIndex = 30;
            btnViewCustomer.Text = "View";
            btnViewCustomer.UseVisualStyleBackColor = true;
            btnViewCustomer.Click += btnViewCustomer_Click;
            // 
            // dtpPawnDate
            // 
            dtpPawnDate.Location = new Point(14, 198);
            dtpPawnDate.Name = "dtpPawnDate";
            dtpPawnDate.Size = new Size(185, 23);
            dtpPawnDate.TabIndex = 46;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(14, 180);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(71, 15);
            label12.TabIndex = 45;
            label12.Text = "Pawn Date *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(207, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 47;
            label5.Text = "Item Type *";
            // 
            // cbItemType
            // 
            cbItemType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbItemType.FormattingEnabled = true;
            cbItemType.Location = new Point(207, 29);
            cbItemType.Name = "cbItemType";
            cbItemType.Size = new Size(205, 23);
            cbItemType.TabIndex = 48;
            cbItemType.SelectedIndexChanged += cbItemType_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(gbJewelry);
            flowLayoutPanel2.Controls.Add(gbOtherItem);
            flowLayoutPanel2.Location = new Point(207, 55);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(447, 230);
            flowLayoutPanel2.TabIndex = 49;
            // 
            // gbJewelry
            // 
            gbJewelry.AutoSize = true;
            gbJewelry.Controls.Add(btnJewelryCompute);
            gbJewelry.Controls.Add(gbWeight);
            gbJewelry.Controls.Add(gbQualityFactor);
            gbJewelry.Controls.Add(gbPurity);
            gbJewelry.Controls.Add(lblMarketPrice);
            gbJewelry.Controls.Add(tbMarketPrice);
            gbJewelry.Controls.Add(cbMaterialType);
            gbJewelry.Controls.Add(cbWeightType);
            gbJewelry.Controls.Add(label8);
            gbJewelry.Controls.Add(label7);
            gbJewelry.Dock = DockStyle.Fill;
            gbJewelry.Location = new Point(3, 3);
            gbJewelry.Name = "gbJewelry";
            gbJewelry.Size = new Size(422, 222);
            gbJewelry.TabIndex = 1;
            gbJewelry.TabStop = false;
            gbJewelry.Text = "Jewelry";
            gbJewelry.Visible = false;
            // 
            // btnJewelryCompute
            // 
            btnJewelryCompute.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnJewelryCompute.Location = new Point(18, 175);
            btnJewelryCompute.Margin = new Padding(4, 3, 4, 3);
            btnJewelryCompute.Name = "btnJewelryCompute";
            btnJewelryCompute.Size = new Size(67, 25);
            btnJewelryCompute.TabIndex = 60;
            btnJewelryCompute.Text = "Compute";
            btnJewelryCompute.UseVisualStyleBackColor = true;
            btnJewelryCompute.Click += btnJewelryCompute_Click;
            // 
            // gbWeight
            // 
            gbWeight.AutoSize = true;
            gbWeight.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbWeight.Controls.Add(tbWeight);
            gbWeight.Location = new Point(11, 107);
            gbWeight.Name = "gbWeight";
            gbWeight.Size = new Size(199, 67);
            gbWeight.TabIndex = 59;
            gbWeight.TabStop = false;
            gbWeight.Text = "Weight *";
            // 
            // tbWeight
            // 
            tbWeight.Location = new Point(7, 22);
            tbWeight.Margin = new Padding(4, 3, 4, 3);
            tbWeight.Name = "tbWeight";
            tbWeight.Size = new Size(185, 23);
            tbWeight.TabIndex = 55;
            // 
            // gbQualityFactor
            // 
            gbQualityFactor.AutoSize = true;
            gbQualityFactor.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbQualityFactor.Controls.Add(tbQualityFactor);
            gbQualityFactor.Location = new Point(216, 16);
            gbQualityFactor.Name = "gbQualityFactor";
            gbQualityFactor.Size = new Size(199, 67);
            gbQualityFactor.TabIndex = 58;
            gbQualityFactor.TabStop = false;
            gbQualityFactor.Text = "Quality Factor (ex. 1.0) *";
            gbQualityFactor.Visible = false;
            // 
            // tbQualityFactor
            // 
            tbQualityFactor.Location = new Point(7, 22);
            tbQualityFactor.Margin = new Padding(4, 3, 4, 3);
            tbQualityFactor.Name = "tbQualityFactor";
            tbQualityFactor.Size = new Size(185, 23);
            tbQualityFactor.TabIndex = 55;
            // 
            // gbPurity
            // 
            gbPurity.AutoSize = true;
            gbPurity.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbPurity.Controls.Add(tbPurity);
            gbPurity.Location = new Point(216, 89);
            gbPurity.Name = "gbPurity";
            gbPurity.Size = new Size(199, 67);
            gbPurity.TabIndex = 57;
            gbPurity.TabStop = false;
            gbPurity.Text = "Purity (ex. 95.0) *";
            gbPurity.Visible = false;
            // 
            // tbPurity
            // 
            tbPurity.Location = new Point(7, 22);
            tbPurity.Margin = new Padding(4, 3, 4, 3);
            tbPurity.Name = "tbPurity";
            tbPurity.Size = new Size(185, 23);
            tbPurity.TabIndex = 55;
            // 
            // lblMarketPrice
            // 
            lblMarketPrice.AutoSize = true;
            lblMarketPrice.Location = new Point(216, 159);
            lblMarketPrice.Margin = new Padding(4, 0, 4, 0);
            lblMarketPrice.Name = "lblMarketPrice";
            lblMarketPrice.Size = new Size(81, 15);
            lblMarketPrice.TabIndex = 54;
            lblMarketPrice.Text = "Market Price *";
            // 
            // tbMarketPrice
            // 
            tbMarketPrice.Location = new Point(216, 177);
            tbMarketPrice.Margin = new Padding(4, 3, 4, 3);
            tbMarketPrice.Name = "tbMarketPrice";
            tbMarketPrice.Size = new Size(199, 23);
            tbMarketPrice.TabIndex = 53;
            // 
            // cbMaterialType
            // 
            cbMaterialType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbMaterialType.FormattingEnabled = true;
            cbMaterialType.Location = new Point(11, 34);
            cbMaterialType.Name = "cbMaterialType";
            cbMaterialType.Size = new Size(199, 23);
            cbMaterialType.TabIndex = 52;
            cbMaterialType.SelectedIndexChanged += cbMaterialType_SelectedIndexChanged;
            // 
            // cbWeightType
            // 
            cbWeightType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbWeightType.Enabled = false;
            cbWeightType.FormattingEnabled = true;
            cbWeightType.Location = new Point(11, 78);
            cbWeightType.Name = "cbWeightType";
            cbWeightType.Size = new Size(199, 23);
            cbWeightType.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 60);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 23;
            label8.Text = "Weight Type *";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 16);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 21;
            label7.Text = "Material Type *";
            // 
            // gbOtherItem
            // 
            gbOtherItem.AutoSize = true;
            gbOtherItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            gbOtherItem.Controls.Add(label4);
            gbOtherItem.Controls.Add(rtbDescription);
            gbOtherItem.Dock = DockStyle.Fill;
            gbOtherItem.Location = new Point(3, 231);
            gbOtherItem.Name = "gbOtherItem";
            gbOtherItem.Size = new Size(259, 188);
            gbOtherItem.TabIndex = 0;
            gbOtherItem.TabStop = false;
            gbOtherItem.Text = "Other Item";
            gbOtherItem.Visible = false;
            // 
            // FormItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(664, 342);
            Controls.Add(flowLayoutPanel2);
            Controls.Add(cbItemType);
            Controls.Add(label5);
            Controls.Add(dtpPawnDate);
            Controls.Add(label12);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tbCustomerID);
            Controls.Add(label3);
            Controls.Add(btnCreate);
            Controls.Add(tbItemValue);
            Controls.Add(label2);
            Controls.Add(tbItemName);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormItem";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Item";
            Load += FormItem_Load;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            gbJewelry.ResumeLayout(false);
            gbJewelry.PerformLayout();
            gbWeight.ResumeLayout(false);
            gbWeight.PerformLayout();
            gbQualityFactor.ResumeLayout(false);
            gbQualityFactor.PerformLayout();
            gbPurity.ResumeLayout(false);
            gbPurity.PerformLayout();
            gbOtherItem.ResumeLayout(false);
            gbOtherItem.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtbDescription;
        private System.Windows.Forms.TextBox tbItemName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCustomerID;
        private System.Windows.Forms.Label label3;
        private Button btnSelectCustomer;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnViewCustomer;
        private DateTimePicker dtpPawnDate;
        private Label label12;
        private Label label5;
        private ComboBox cbItemType;
        private FlowLayoutPanel flowLayoutPanel2;
        private GroupBox gbOtherItem;
        private GroupBox gbJewelry;
        private Label label8;
        private Label label7;
        private ComboBox cbWeightType;
        private Label lblMarketPrice;
        private TextBox tbMarketPrice;
        private ComboBox cbMaterialType;
        private TextBox tbPurity;
        private GroupBox gbPurity;
        private GroupBox gbQualityFactor;
        private TextBox tbQualityFactor;
        private GroupBox gbWeight;
        private TextBox tbWeight;
        private Button btnJewelryCompute;
    }
}