namespace StoreWinFrom.Forms
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            label1 = new Label();
            panel1 = new Panel();
            empPictureBox = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbRole = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            btnSaveRegForm = new Button();
            btnEscapeRegForm = new Button();
            txtLastName = new TextBox();
            txtName = new TextBox();
            txtPatronymic = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            btnAddPhoto = new Button();
            pickerDateOfBirth = new DateTimePicker();
            mskPhone = new MaskedTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Roboto", 14F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(482, 45);
            label1.Name = "label1";
            label1.Size = new Size(163, 23);
            label1.TabIndex = 4;
            label1.Text = "Фото сотрудника";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(empPictureBox);
            panel1.Location = new Point(482, 71);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 320);
            panel1.TabIndex = 5;
            // 
            // empPictureBox
            // 
            empPictureBox.Location = new Point(17, 16);
            empPictureBox.Name = "empPictureBox";
            empPictureBox.Size = new Size(287, 288);
            empPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            empPictureBox.TabIndex = 0;
            empPictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Roboto", 14F);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(146, 113);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 5;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Roboto", 14F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(190, 155);
            label3.Name = "label3";
            label3.Size = new Size(48, 23);
            label3.TabIndex = 6;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Roboto", 14F);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(145, 193);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Roboto", 14F);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(90, 230);
            label5.Name = "label5";
            label5.Size = new Size(148, 23);
            label5.TabIndex = 8;
            label5.Text = "Дата рождения";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 18F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(22, 39);
            label6.Name = "label6";
            label6.Size = new Size(383, 29);
            label6.TabIndex = 9;
            label6.Text = "Окно регистрации сотрудника";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Roboto", 14F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(151, 269);
            label7.Name = "label7";
            label7.Size = new Size(87, 23);
            label7.TabIndex = 11;
            label7.Text = "Телефон";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Roboto", 14F);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(184, 307);
            label8.Name = "label8";
            label8.Size = new Size(54, 23);
            label8.TabIndex = 12;
            label8.Text = "Роль";
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Location = new Point(244, 307);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(161, 23);
            cmbRole.TabIndex = 13;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Roboto", 14F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(174, 345);
            label9.Name = "label9";
            label9.Size = new Size(64, 23);
            label9.TabIndex = 15;
            label9.Text = "Логин";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Roboto", 14F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(161, 385);
            label10.Name = "label10";
            label10.Size = new Size(77, 23);
            label10.TabIndex = 17;
            label10.Text = "Пароль";
            // 
            // btnSaveRegForm
            // 
            btnSaveRegForm.BackColor = Color.Transparent;
            btnSaveRegForm.FlatAppearance.BorderSize = 0;
            btnSaveRegForm.FlatStyle = FlatStyle.Flat;
            btnSaveRegForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnSaveRegForm.ForeColor = Color.WhiteSmoke;
            btnSaveRegForm.Location = new Point(263, 422);
            btnSaveRegForm.Name = "btnSaveRegForm";
            btnSaveRegForm.Size = new Size(121, 37);
            btnSaveRegForm.TabIndex = 18;
            btnSaveRegForm.Text = "Сохранить";
            btnSaveRegForm.UseVisualStyleBackColor = false;
            btnSaveRegForm.Click += btnSaveRegForm_Click;
            // 
            // btnEscapeRegForm
            // 
            btnEscapeRegForm.BackColor = Color.Transparent;
            btnEscapeRegForm.FlatAppearance.BorderSize = 0;
            btnEscapeRegForm.FlatStyle = FlatStyle.Flat;
            btnEscapeRegForm.Font = new Font("Roboto", 14F, FontStyle.Bold);
            btnEscapeRegForm.ForeColor = Color.WhiteSmoke;
            btnEscapeRegForm.Location = new Point(263, 473);
            btnEscapeRegForm.Name = "btnEscapeRegForm";
            btnEscapeRegForm.Size = new Size(121, 37);
            btnEscapeRegForm.TabIndex = 19;
            btnEscapeRegForm.Text = "Отмена";
            btnEscapeRegForm.UseVisualStyleBackColor = false;
            btnEscapeRegForm.Click += btnEscapeRegForm_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(244, 113);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(161, 23);
            txtLastName.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new Point(244, 155);
            txtName.Name = "txtName";
            txtName.Size = new Size(161, 23);
            txtName.TabIndex = 21;
            // 
            // txtPatronymic
            // 
            txtPatronymic.Location = new Point(244, 193);
            txtPatronymic.Name = "txtPatronymic";
            txtPatronymic.Size = new Size(161, 23);
            txtPatronymic.TabIndex = 22;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(244, 345);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(161, 23);
            txtUserName.TabIndex = 25;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(244, 385);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(161, 23);
            txtPassword.TabIndex = 26;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.BackColor = Color.Transparent;
            btnAddPhoto.FlatAppearance.BorderSize = 0;
            btnAddPhoto.FlatStyle = FlatStyle.Flat;
            btnAddPhoto.Font = new Font("Roboto", 10F, FontStyle.Bold);
            btnAddPhoto.ForeColor = Color.WhiteSmoke;
            btnAddPhoto.Location = new Point(705, 397);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(97, 33);
            btnAddPhoto.TabIndex = 29;
            btnAddPhoto.Text = "Открыть";
            btnAddPhoto.UseVisualStyleBackColor = false;
            btnAddPhoto.Click += btnAddPhoto_Click;
            // 
            // pickerDateOfBirth
            // 
            pickerDateOfBirth.Format = DateTimePickerFormat.Short;
            pickerDateOfBirth.Location = new Point(244, 230);
            pickerDateOfBirth.MinDate = new DateTime(1930, 1, 1, 0, 0, 0, 0);
            pickerDateOfBirth.Name = "pickerDateOfBirth";
            pickerDateOfBirth.Size = new Size(161, 23);
            pickerDateOfBirth.TabIndex = 30;
            pickerDateOfBirth.Value = new DateTime(2006, 1, 1, 0, 0, 0, 0);
            pickerDateOfBirth.ValueChanged += pickerDateOfBirth_ValueChanged;
            // 
            // mskPhone
            // 
            mskPhone.Location = new Point(244, 269);
            mskPhone.Mask = "+7(999) 000-00-00";
            mskPhone.Name = "mskPhone";
            mskPhone.Size = new Size(161, 23);
            mskPhone.TabIndex = 31;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 531);
            Controls.Add(mskPhone);
            Controls.Add(pickerDateOfBirth);
            Controls.Add(btnAddPhoto);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtPatronymic);
            Controls.Add(txtName);
            Controls.Add(txtLastName);
            Controls.Add(label1);
            Controls.Add(btnEscapeRegForm);
            Controls.Add(btnSaveRegForm);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(cmbRole);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)empPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbRole;
        private Label label9;
        private Label label10;
        private Button btnSaveRegForm;
        private Button btnEscapeRegForm;
        private TextBox txtLastName;
        private TextBox txtName;
        private TextBox txtPatronymic;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private PictureBox empPictureBox;
        private Button btnAddPhoto;
        private DateTimePicker pickerDateOfBirth;
        private MaskedTextBox mskPhone;
    }
}