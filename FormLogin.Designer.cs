namespace PawnShop
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            tbAccessCode = new TextBox();
            label2 = new Label();
            btnAccess = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbAccessCode
            // 
            tbAccessCode.Font = new Font("Lucida Console", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbAccessCode.Location = new Point(331, 135);
            tbAccessCode.Margin = new Padding(4, 3, 4, 3);
            tbAccessCode.Name = "tbAccessCode";
            tbAccessCode.PasswordChar = '*';
            tbAccessCode.Size = new Size(208, 31);
            tbAccessCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Console", 18F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(327, 104);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(175, 24);
            label2.TabIndex = 3;
            label2.Text = "Access Code";
            // 
            // btnAccess
            // 
            btnAccess.Font = new Font("Lucida Console", 18F, FontStyle.Bold | FontStyle.Italic);
            btnAccess.Location = new Point(331, 178);
            btnAccess.Margin = new Padding(4, 3, 4, 3);
            btnAccess.Name = "btnAccess";
            btnAccess.Size = new Size(209, 32);
            btnAccess.TabIndex = 4;
            btnAccess.Text = "Access";
            btnAccess.UseVisualStyleBackColor = true;
            btnAccess.Click += btnAccess_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkGoldenrod;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 209);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("MS Gothic", 15F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(229, 96);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(515, 20);
            label3.TabIndex = 9;
            label3.Text = "The PAWNSHOP where you can Buy, Sell, And Loan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Console", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(251, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(415, 24);
            label1.TabIndex = 8;
            label1.Text = "The Golden Key And Exchange";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbAccessCode);
            panel1.Controls.Add(btnAccess);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 226);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(923, 329);
            panel1.TabIndex = 11;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(923, 555);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Access";
            Load += FormLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbAccessCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAccess;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}