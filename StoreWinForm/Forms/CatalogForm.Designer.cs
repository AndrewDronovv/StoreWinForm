namespace StoreWinFrom
{
    partial class CatalogForm
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
            label6 = new Label();
            btnAddCatalogForm = new Button();
            btnExitCatForm = new Button();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 18F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(31, 48);
            label6.Name = "label6";
            label6.Size = new Size(111, 29);
            label6.TabIndex = 11;
            label6.Text = "Каталог";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAddCatalogForm
            // 
            btnAddCatalogForm.BackColor = Color.Transparent;
            btnAddCatalogForm.FlatAppearance.BorderSize = 0;
            btnAddCatalogForm.FlatStyle = FlatStyle.Flat;
            btnAddCatalogForm.Font = new Font("Roboto", 10F, FontStyle.Bold);
            btnAddCatalogForm.ForeColor = Color.WhiteSmoke;
            btnAddCatalogForm.Location = new Point(1270, 49);
            btnAddCatalogForm.Name = "btnAddCatalogForm";
            btnAddCatalogForm.Size = new Size(92, 35);
            btnAddCatalogForm.TabIndex = 23;
            btnAddCatalogForm.Text = "Добавить";
            btnAddCatalogForm.TextAlign = ContentAlignment.MiddleRight;
            btnAddCatalogForm.UseVisualStyleBackColor = false;
            btnAddCatalogForm.Click += btnAddCatalogForm_Click;
            // 
            // btnExitCatForm
            // 
            btnExitCatForm.BackColor = Color.Transparent;
            btnExitCatForm.FlatAppearance.BorderSize = 0;
            btnExitCatForm.FlatStyle = FlatStyle.Flat;
            btnExitCatForm.Font = new Font("Roboto", 10F, FontStyle.Bold);
            btnExitCatForm.ForeColor = Color.WhiteSmoke;
            btnExitCatForm.Location = new Point(1295, 89);
            btnExitCatForm.Name = "btnExitCatForm";
            btnExitCatForm.Size = new Size(67, 37);
            btnExitCatForm.TabIndex = 24;
            btnExitCatForm.Text = "Выход";
            btnExitCatForm.TextAlign = ContentAlignment.MiddleRight;
            btnExitCatForm.UseVisualStyleBackColor = false;
            btnExitCatForm.Click += btnExitCatForm_Click;
            // 
            // CatalogForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1384, 961);
            Controls.Add(btnExitCatForm);
            Controls.Add(btnAddCatalogForm);
            Controls.Add(label6);
            Name = "CatalogForm";
            Text = "CatalogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnAddCatalogForm;
        private Button btnExitCatForm;
    }
}