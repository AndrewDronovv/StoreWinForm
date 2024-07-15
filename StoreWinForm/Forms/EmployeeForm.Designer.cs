namespace StoreWinFrom.Forms
{
    partial class EmployeeForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            label6 = new Label();
            textBox1 = new TextBox();
            button2 = new Button();
            btnAddEmployeeForm = new Button();
            dataGridEmployee = new DataGridView();
            roleIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            patronymicDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOnlyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            phoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pathToPhotoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            usernameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            passwordDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            btnExitEmployeeForm = new Button();
            btnDeleteEmployeeForm = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Roboto", 18F, FontStyle.Bold);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(31, 72);
            label6.Name = "label6";
            label6.Size = new Size(157, 29);
            label6.TabIndex = 10;
            label6.Text = "Сотрудники";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(791, 217);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(301, 23);
            textBox1.TabIndex = 11;
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
            button2.Location = new Point(1106, 212);
            button2.Name = "button2";
            button2.Size = new Size(35, 33);
            button2.TabIndex = 12;
            button2.UseVisualStyleBackColor = false;
            // 
            // btnAddEmployeeForm
            // 
            btnAddEmployeeForm.BackColor = Color.Transparent;
            btnAddEmployeeForm.FlatAppearance.BorderSize = 0;
            btnAddEmployeeForm.FlatStyle = FlatStyle.Flat;
            btnAddEmployeeForm.Font = new Font("Roboto", 10F, FontStyle.Bold);
            btnAddEmployeeForm.ForeColor = Color.WhiteSmoke;
            btnAddEmployeeForm.Location = new Point(364, 214);
            btnAddEmployeeForm.Name = "btnAddEmployeeForm";
            btnAddEmployeeForm.Size = new Size(91, 32);
            btnAddEmployeeForm.TabIndex = 20;
            btnAddEmployeeForm.Text = "Добавить";
            btnAddEmployeeForm.TextAlign = ContentAlignment.MiddleRight;
            btnAddEmployeeForm.UseVisualStyleBackColor = false;
            btnAddEmployeeForm.Click += btnAddEmployeeForm_Click;
            // 
            // dataGridEmployee
            // 
            dataGridEmployee.AutoGenerateColumns = false;
            dataGridEmployee.BackgroundColor = Color.WhiteSmoke;
            dataGridEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridEmployee.Columns.AddRange(new DataGridViewColumn[] { roleIdDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, fullNameDataGridViewTextBoxColumn, patronymicDataGridViewTextBoxColumn, dateOnlyDataGridViewTextBoxColumn, phoneDataGridViewTextBoxColumn, pathToPhotoDataGridViewTextBoxColumn, usernameDataGridViewTextBoxColumn, passwordDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn });
            dataGridEmployee.DataSource = employeeBindingSource;
            dataGridEmployee.Location = new Point(31, 261);
            dataGridEmployee.Name = "dataGridEmployee";
            dataGridEmployee.Size = new Size(1328, 667);
            dataGridEmployee.TabIndex = 21;
            dataGridEmployee.CellBeginEdit += dataGridEmployee_CellBeginEdit;
            dataGridEmployee.CellClick += dataGridEmployee_CellClick;
            dataGridEmployee.CellEndEdit += dataGridEmployee_CellEndEdit;
            // 
            // roleIdDataGridViewTextBoxColumn
            // 
            roleIdDataGridViewTextBoxColumn.DataPropertyName = "RoleId";
            roleIdDataGridViewTextBoxColumn.HeaderText = "RoleId";
            roleIdDataGridViewTextBoxColumn.Name = "roleIdDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patronymicDataGridViewTextBoxColumn
            // 
            patronymicDataGridViewTextBoxColumn.DataPropertyName = "Patronymic";
            patronymicDataGridViewTextBoxColumn.HeaderText = "Patronymic";
            patronymicDataGridViewTextBoxColumn.Name = "patronymicDataGridViewTextBoxColumn";
            // 
            // dateOnlyDataGridViewTextBoxColumn
            // 
            dateOnlyDataGridViewTextBoxColumn.DataPropertyName = "DateOnly";
            dateOnlyDataGridViewTextBoxColumn.HeaderText = "DateOnly";
            dateOnlyDataGridViewTextBoxColumn.Name = "dateOnlyDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // pathToPhotoDataGridViewTextBoxColumn
            // 
            pathToPhotoDataGridViewTextBoxColumn.DataPropertyName = "PathToPhoto";
            pathToPhotoDataGridViewTextBoxColumn.HeaderText = "PathToPhoto";
            pathToPhotoDataGridViewTextBoxColumn.Name = "pathToPhotoDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.DataSource = typeof(Store.Domain.Entities.Employee);
            // 
            // btnExitEmployeeForm
            // 
            btnExitEmployeeForm.BackColor = Color.Transparent;
            btnExitEmployeeForm.FlatAppearance.BorderSize = 0;
            btnExitEmployeeForm.FlatStyle = FlatStyle.Flat;
            btnExitEmployeeForm.Font = new Font("Roboto", 10F, FontStyle.Bold);
            btnExitEmployeeForm.ForeColor = Color.WhiteSmoke;
            btnExitEmployeeForm.Location = new Point(1293, 212);
            btnExitEmployeeForm.Name = "btnExitEmployeeForm";
            btnExitEmployeeForm.Size = new Size(66, 37);
            btnExitEmployeeForm.TabIndex = 22;
            btnExitEmployeeForm.Text = "Выход";
            btnExitEmployeeForm.TextAlign = ContentAlignment.MiddleRight;
            btnExitEmployeeForm.UseVisualStyleBackColor = false;
            btnExitEmployeeForm.Click += btnExitEmployeeForm_Click;
            // 
            // btnDeleteEmployeeForm
            // 
            btnDeleteEmployeeForm.BackColor = Color.Transparent;
            btnDeleteEmployeeForm.FlatAppearance.BorderSize = 0;
            btnDeleteEmployeeForm.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployeeForm.Font = new Font("Roboto", 10F, FontStyle.Bold);
            btnDeleteEmployeeForm.ForeColor = Color.WhiteSmoke;
            btnDeleteEmployeeForm.Location = new Point(496, 214);
            btnDeleteEmployeeForm.Name = "btnDeleteEmployeeForm";
            btnDeleteEmployeeForm.Size = new Size(78, 32);
            btnDeleteEmployeeForm.TabIndex = 23;
            btnDeleteEmployeeForm.Text = "Удалить";
            btnDeleteEmployeeForm.TextAlign = ContentAlignment.MiddleRight;
            btnDeleteEmployeeForm.UseVisualStyleBackColor = false;
            btnDeleteEmployeeForm.Click += btnDeleteEmployeeForm_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(18, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(791, 31);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 180);
            panel1.TabIndex = 25;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(1384, 961);
            Controls.Add(panel1);
            Controls.Add(btnDeleteEmployeeForm);
            Controls.Add(btnExitEmployeeForm);
            Controls.Add(dataGridEmployee);
            Controls.Add(btnAddEmployeeForm);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(label6);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            ((System.ComponentModel.ISupportInitialize)dataGridEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox textBox1;
        private Button button2;
        private Button btnAddEmployeeForm;
        private DataGridView dataGridEmployee;
        private BindingSource employeeBindingSource;
        private DataGridViewTextBoxColumn roleIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOnlyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pathToPhotoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private Button btnExitEmployeeForm;
        private Button btnDeleteEmployeeForm;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}