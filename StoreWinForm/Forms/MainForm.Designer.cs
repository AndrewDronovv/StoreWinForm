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
            btnEmployeeMainFrom = new Button();
            btnCatalogMainForm = new Button();
            btnProfile = new Button();
            btnCart = new Button();
            panelBody = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnEmployeeMainFrom);
            panel1.Controls.Add(btnCatalogMainForm);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(240, 1069);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Roboto", 16F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 1004);
            button2.Name = "button2";
            button2.Size = new Size(240, 65);
            button2.TabIndex = 4;
            button2.Text = "Выход";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // btnEmployeeMainFrom
            // 
            btnEmployeeMainFrom.BackColor = SystemColors.MenuHighlight;
            btnEmployeeMainFrom.Dock = DockStyle.Top;
            btnEmployeeMainFrom.FlatAppearance.BorderSize = 0;
            btnEmployeeMainFrom.Font = new Font("Roboto", 16F, FontStyle.Bold);
            btnEmployeeMainFrom.ForeColor = Color.White;
            btnEmployeeMainFrom.Location = new Point(0, 65);
            btnEmployeeMainFrom.Name = "btnEmployeeMainFrom";
            btnEmployeeMainFrom.Size = new Size(240, 65);
            btnEmployeeMainFrom.TabIndex = 3;
            btnEmployeeMainFrom.Text = "Сотрудники";
            btnEmployeeMainFrom.UseVisualStyleBackColor = false;
            btnEmployeeMainFrom.Click += btnEmployeeMainFrom_Click;
            // 
            // btnCatalogMainForm
            // 
            btnCatalogMainForm.BackColor = SystemColors.MenuHighlight;
            btnCatalogMainForm.Dock = DockStyle.Top;
            btnCatalogMainForm.FlatAppearance.BorderSize = 0;
            btnCatalogMainForm.Font = new Font("Roboto", 16F, FontStyle.Bold);
            btnCatalogMainForm.ForeColor = Color.White;
            btnCatalogMainForm.Location = new Point(0, 0);
            btnCatalogMainForm.Name = "btnCatalogMainForm";
            btnCatalogMainForm.Size = new Size(240, 65);
            btnCatalogMainForm.TabIndex = 2;
            btnCatalogMainForm.Text = "Каталог";
            btnCatalogMainForm.UseVisualStyleBackColor = false;
            btnCatalogMainForm.Click += btnCatalogMainForm_Click;
            // 
            // btnProfile
            // 
            btnProfile.BackColor = Color.Transparent;
            btnProfile.BackgroundImage = (Image)resources.GetObject("btnProfile.BackgroundImage");
            btnProfile.BackgroundImageLayout = ImageLayout.Stretch;
            btnProfile.FlatStyle = FlatStyle.Popup;
            btnProfile.Location = new Point(1694, 41);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(55, 55);
            btnProfile.TabIndex = 1;
            btnProfile.UseVisualStyleBackColor = false;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnCart
            // 
            btnCart.BackColor = Color.Transparent;
            btnCart.BackgroundImage = (Image)resources.GetObject("btnCart.BackgroundImage");
            btnCart.BackgroundImageLayout = ImageLayout.Stretch;
            btnCart.FlatStyle = FlatStyle.Popup;
            btnCart.Location = new Point(1694, 121);
            btnCart.Name = "btnCart";
            btnCart.Size = new Size(55, 55);
            btnCart.TabIndex = 2;
            btnCart.UseVisualStyleBackColor = false;
            btnCart.Click += btnCart_Click;
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.Transparent;
            panelBody.Location = new Point(273, 41);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1400, 1000);
            panelBody.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1784, 1069);
            Controls.Add(panelBody);
            Controls.Add(btnCart);
            Controls.Add(btnProfile);
            Controls.Add(panel1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnProfile;
        private Button btnCatalogMainForm;
        private Button btnCart;
        private Button btnEmployeeMainFrom;
        private Button button2;
        private Panel panelBody;
    }
}