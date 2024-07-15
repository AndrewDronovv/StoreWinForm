namespace StoreWinForm.Forms
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            label6 = new Label();
            txtName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cmbCategory = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSaveProdForm = new Button();
            btnEscapeProdForm = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 18F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(26, 38);
            label6.Name = "label6";
            label6.Size = new Size(346, 29);
            label6.TabIndex = 10;
            label6.Text = "Окно добавления продукта";
            // 
            // txtName
            // 
            txtName.Location = new Point(235, 203);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 23);
            txtName.TabIndex = 11;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(235, 249);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(166, 23);
            txtPrice.TabIndex = 12;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(235, 293);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(166, 23);
            txtQuantity.TabIndex = 13;
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(235, 158);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(166, 23);
            cmbCategory.TabIndex = 14;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(132, 203);
            label2.Name = "label2";
            label2.Size = new Size(97, 23);
            label2.TabIndex = 15;
            label2.Text = "Название";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 14F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(128, 158);
            label1.Name = "label1";
            label1.Size = new Size(101, 23);
            label1.TabIndex = 16;
            label1.Text = "Категория";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 14F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(174, 249);
            label3.Name = "label3";
            label3.Size = new Size(55, 23);
            label3.TabIndex = 17;
            label3.Text = "Цена";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 14F);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(113, 293);
            label4.Name = "label4";
            label4.Size = new Size(116, 23);
            label4.TabIndex = 18;
            label4.Text = "Количество";
            // 
            // btnSaveProdForm
            // 
            btnSaveProdForm.BackColor = Color.Transparent;
            btnSaveProdForm.FlatAppearance.BorderSize = 0;
            btnSaveProdForm.FlatStyle = FlatStyle.Flat;
            btnSaveProdForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnSaveProdForm.ForeColor = Color.WhiteSmoke;
            btnSaveProdForm.Location = new Point(260, 332);
            btnSaveProdForm.Name = "btnSaveProdForm";
            btnSaveProdForm.Size = new Size(121, 37);
            btnSaveProdForm.TabIndex = 21;
            btnSaveProdForm.Text = "Сохранить";
            btnSaveProdForm.UseVisualStyleBackColor = false;
            btnSaveProdForm.Click += btnSaveProdForm_Click;
            // 
            // btnEscapeProdForm
            // 
            btnEscapeProdForm.BackColor = Color.Transparent;
            btnEscapeProdForm.FlatAppearance.BorderSize = 0;
            btnEscapeProdForm.FlatStyle = FlatStyle.Flat;
            btnEscapeProdForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnEscapeProdForm.ForeColor = Color.WhiteSmoke;
            btnEscapeProdForm.Location = new Point(260, 375);
            btnEscapeProdForm.Name = "btnEscapeProdForm";
            btnEscapeProdForm.Size = new Size(121, 37);
            btnEscapeProdForm.TabIndex = 22;
            btnEscapeProdForm.Text = "Отмена";
            btnEscapeProdForm.UseVisualStyleBackColor = false;
            btnEscapeProdForm.Click += btnEscapeProdForm_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 531);
            Controls.Add(btnEscapeProdForm);
            Controls.Add(btnSaveProdForm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(cmbCategory);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtName);
            Controls.Add(label6);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProductForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox txtName;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox cmbCategory;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnSaveProdForm;
        private Button btnEscapeProdForm;
    }
}