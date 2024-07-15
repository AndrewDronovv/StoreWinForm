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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatalogForm));
            label6 = new Label();
            btnAddCatalogForm = new Button();
            button2 = new Button();
            textBox1 = new TextBox();
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
            btnAddCatalogForm.Location = new Point(512, 92);
            btnAddCatalogForm.Name = "btnAddCatalogForm";
            btnAddCatalogForm.Size = new Size(92, 35);
            btnAddCatalogForm.TabIndex = 23;
            btnAddCatalogForm.Text = "Добавить";
            btnAddCatalogForm.TextAlign = ContentAlignment.MiddleRight;
            btnAddCatalogForm.UseVisualStyleBackColor = false;
            btnAddCatalogForm.Click += btnAddCatalogForm_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(1140, 89);
            button2.Name = "button2";
            button2.Size = new Size(35, 33);
            button2.TabIndex = 22;
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(833, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 21;
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
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Name = "CatalogForm";
            Text = "CatalogForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Button btnAddCatalogForm;
        private Button button2;
        private TextBox textBox1;
        private Button btnExitCatForm;
    }
}