namespace StoreWinFrom.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnCatalogMForm = new Button();
            btnUserMForm = new Button();
            btnBasketMForm = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnCatalogMForm);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 985);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Roboto", 16F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 920);
            button2.Name = "button2";
            button2.Size = new Size(240, 65);
            button2.TabIndex = 4;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Roboto", 16F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 65);
            button1.Name = "button1";
            button1.Size = new Size(240, 65);
            button1.TabIndex = 3;
            button1.Text = "Сотрудники";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnCatalogMForm
            // 
            btnCatalogMForm.BackColor = SystemColors.MenuHighlight;
            btnCatalogMForm.Dock = DockStyle.Top;
            btnCatalogMForm.FlatAppearance.BorderSize = 0;
            btnCatalogMForm.Font = new Font("Roboto", 16F, FontStyle.Bold);
            btnCatalogMForm.ForeColor = Color.White;
            btnCatalogMForm.Location = new Point(0, 0);
            btnCatalogMForm.Name = "btnCatalogMForm";
            btnCatalogMForm.Size = new Size(240, 65);
            btnCatalogMForm.TabIndex = 2;
            btnCatalogMForm.Text = "Каталог";
            btnCatalogMForm.UseVisualStyleBackColor = false;
            // 
            // btnUserMForm
            // 
            btnUserMForm.BackColor = Color.Transparent;
            btnUserMForm.BackgroundImage = (Image)resources.GetObject("btnUserMForm.BackgroundImage");
            btnUserMForm.BackgroundImageLayout = ImageLayout.Stretch;
            btnUserMForm.FlatStyle = FlatStyle.Popup;
            btnUserMForm.Location = new Point(1170, 41);
            btnUserMForm.Name = "btnUserMForm";
            btnUserMForm.Size = new Size(55, 55);
            btnUserMForm.TabIndex = 1;
            btnUserMForm.UseVisualStyleBackColor = false;
            // 
            // btnBasketMForm
            // 
            btnBasketMForm.BackColor = Color.Transparent;
            btnBasketMForm.BackgroundImage = (Image)resources.GetObject("btnBasketMForm.BackgroundImage");
            btnBasketMForm.BackgroundImageLayout = ImageLayout.Stretch;
            btnBasketMForm.FlatStyle = FlatStyle.Popup;
            btnBasketMForm.Location = new Point(1170, 122);
            btnBasketMForm.Name = "btnBasketMForm";
            btnBasketMForm.Size = new Size(55, 55);
            btnBasketMForm.TabIndex = 2;
            btnBasketMForm.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1264, 985);
            Controls.Add(btnBasketMForm);
            Controls.Add(btnUserMForm);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnUserMForm;
        private Button btnCatalogMForm;
        private Button btnBasketMForm;
        private Button button1;
        private Button button2;
    }
}