namespace StoreWinFrom
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            btnEnterLogForm = new Button();
            label3 = new Label();
            button2 = new Button();
            btnEscapeLogForm = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            txtLoginInput = new TextBox();
            txtPasswordInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 28F, FontStyle.Bold);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(177, 186);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(266, 46);
            label1.TabIndex = 0;
            label1.Text = "Авторизация";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(132, 283);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 1;
            label2.Text = "Логин";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEnterLogForm
            // 
            btnEnterLogForm.BackColor = Color.Transparent;
            btnEnterLogForm.Cursor = Cursors.Hand;
            btnEnterLogForm.FlatAppearance.BorderColor = Color.White;
            btnEnterLogForm.FlatAppearance.BorderSize = 0;
            btnEnterLogForm.FlatAppearance.MouseDownBackColor = Color.White;
            btnEnterLogForm.FlatAppearance.MouseOverBackColor = Color.White;
            btnEnterLogForm.FlatStyle = FlatStyle.Flat;
            btnEnterLogForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnEnterLogForm.ForeColor = Color.WhiteSmoke;
            btnEnterLogForm.Location = new Point(254, 373);
            btnEnterLogForm.Name = "btnEnterLogForm";
            btnEnterLogForm.Size = new Size(107, 37);
            btnEnterLogForm.TabIndex = 5;
            btnEnterLogForm.Text = "Войти";
            btnEnterLogForm.UseVisualStyleBackColor = false;
            btnEnterLogForm.Click += btnEnterLogForm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 14F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(119, 334);
            label3.Name = "label3";
            label3.Size = new Size(77, 23);
            label3.TabIndex = 2;
            label3.Text = "Пароль";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(406, 329);
            button2.Name = "button2";
            button2.Size = new Size(37, 28);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnEscapeLogForm
            // 
            btnEscapeLogForm.BackColor = Color.Transparent;
            btnEscapeLogForm.Cursor = Cursors.Hand;
            btnEscapeLogForm.FlatAppearance.BorderColor = Color.White;
            btnEscapeLogForm.FlatAppearance.BorderSize = 0;
            btnEscapeLogForm.FlatAppearance.MouseDownBackColor = Color.White;
            btnEscapeLogForm.FlatAppearance.MouseOverBackColor = Color.White;
            btnEscapeLogForm.FlatStyle = FlatStyle.Flat;
            btnEscapeLogForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnEscapeLogForm.ForeColor = Color.WhiteSmoke;
            btnEscapeLogForm.Location = new Point(254, 416);
            btnEscapeLogForm.Name = "btnEscapeLogForm";
            btnEscapeLogForm.Size = new Size(107, 37);
            btnEscapeLogForm.TabIndex = 7;
            btnEscapeLogForm.Text = "Выход";
            btnEscapeLogForm.UseVisualStyleBackColor = false;
            btnEscapeLogForm.Click += btnEscapeLogForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(254, 78);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(92, 92);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(202, 331);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(27, 26);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(205, 283);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(24, 23);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // txtLoginInput
            // 
            txtLoginInput.Location = new Point(235, 283);
            txtLoginInput.Name = "txtLoginInput";
            txtLoginInput.Size = new Size(165, 23);
            txtLoginInput.TabIndex = 12;
            // 
            // txtPasswordInput
            // 
            txtPasswordInput.Location = new Point(235, 334);
            txtPasswordInput.Name = "txtPasswordInput";
            txtPasswordInput.Size = new Size(165, 23);
            txtPasswordInput.TabIndex = 13;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(604, 581);
            Controls.Add(txtPasswordInput);
            Controls.Add(txtLoginInput);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnEscapeLogForm);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(btnEnterLogForm);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Form1";
            Load += LoginForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnEnterLogForm;
        private Label label3;
        private Button button2;
        private Button btnEscapeLogForm;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox txtLoginInput;
        private TextBox txtPasswordInput;
    }
}
