using Microsoft.Extensions.DependencyInjection;
using Store.Domain;
using StoreWinForm.Forms;

namespace StoreWinFrom.Forms
{
    public partial class EmployeeForm : FormBase
    {
        private readonly BindingSource _employeeBindingSource;
        public EmployeeForm(IServiceProvider serviceProvider, AppDbContext context) : base(serviceProvider, context)
        {
            InitializeComponent();
            _employeeBindingSource = new BindingSource();
            dataGridEmployee.DataSource = _employeeBindingSource;
            _employeeBindingSource.DataSource = context.Employees.ToList();

            dataGridEmployee.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridEmployee.ReadOnly = false;
            dataGridEmployee.EditMode = DataGridViewEditMode.EditOnEnter;

            dataGridEmployee.CellBeginEdit += dataGridEmployee_CellBeginEdit;
            dataGridEmployee.CellEndEdit += dataGridEmployee_CellEndEdit;


            dataGridEmployee.CellClick += dataGridEmployee_CellClick;

            ShowColumnName();
        }

        private void btnAddEmployeeForm_Click(object sender, EventArgs e)
        {
            var registerForm = ServiceProvider.GetService<RegisterForm>();
            registerForm.Show();
            registerForm.FormClosed += (sender, e) =>
            {
                _employeeBindingSource.DataSource = Context.Employees.ToList();
            };
        }

        public void ShowColumnName()
        {
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            dataGridEmployee.Columns[0].HeaderText = "Id роли";
            dataGridEmployee.Columns[1].HeaderText = "Роль";
            dataGridEmployee.Columns[2].HeaderText = "Имя";
            dataGridEmployee.Columns[3].HeaderText = "Фамилия";
            dataGridEmployee.Columns[4].HeaderText = "ФИО";
            dataGridEmployee.Columns[5].HeaderText = "Отчество";
            dataGridEmployee.Columns[6].HeaderText = "Дата рождения";
            dataGridEmployee.Columns[7].HeaderText = "Телефон";
            dataGridEmployee.Columns[8].HeaderText = "Путь к фото";
            dataGridEmployee.Columns[9].HeaderText = "Логин";
            dataGridEmployee.Columns[10].HeaderText = "Пароль";
            dataGridEmployee.Columns[11].Name = "Id";
            dataGridEmployee.Columns[8].Name = "PathToPhoto";
        }

        private void btnExitEmployeeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteEmployeeForm_Click(object sender, EventArgs e)
        {
            if (dataGridEmployee.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridEmployee.SelectedRows[0];
                if (selectedRow.Cells["Id"].Value != null)
                {
                    try
                    {
                        int entityId = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                        dataGridEmployee.Rows.Remove(selectedRow);

                        var entity = Context.Employees.Find(entityId);
                        if (entity != null)
                        {
                            Context.Employees.Remove(entity);
                            Context.SaveChanges();
                        }
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Пожалуйста выберите строку для удаления");
                    }
                }
            }
        }

        private void dataGridEmployee_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var cellValue = dataGridEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
        }

        private void dataGridEmployee_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            object newValue = dataGridEmployee.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

            int employeeId = (int)dataGridEmployee.Rows[e.RowIndex].Cells["Id"].Value;


            var employee = Context.Employees.Find(employeeId);
            if (employeeId != null)
            {
                if (dataGridEmployee.Columns[e.ColumnIndex].Name == "Name")
                {
                    employee.Name = newValue.ToString();
                }
                else if (dataGridEmployee.Columns[e.ColumnIndex].Name == "Lastname")
                {
                    employee.LastName = newValue.ToString();
                }
                else if (dataGridEmployee.Columns[e.ColumnIndex].Name == "Patronymic")
                {
                    employee.Patronymic = newValue.ToString();
                }
                //else if (dataGridEmployee.Columns[e.ColumnIndex].Name == "DateOnly")
                //{
                //    employee.DateOnly = newValue;
                //}
                //else if (dataGridEmployee.Columns[e.ColumnIndex].Name == "RoleId")
                //{
                //    employee.RoleId = newValue;
                //}
                else if (dataGridEmployee.Columns[e.ColumnIndex].Name == "Phone")
                {
                    employee.Phone = newValue.ToString();
                }
                else if (dataGridEmployee.Columns[e.ColumnIndex].Name == "PathToPhoto")
                {
                    employee.PathToPhoto = newValue.ToString();
                }
                else if (dataGridEmployee.Columns[e.ColumnIndex].Name == "Username")
                {
                    employee.Username = newValue.ToString();
                }
                else if (dataGridEmployee.Columns[e.ColumnIndex].Name == "Password")
                {
                    employee.Password = newValue.ToString();
                }
                Context.SaveChanges();
            }
        }

        private void dataGridEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex <= dataGridEmployee.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridEmployee.Rows[e.RowIndex];


                string imagePath = selectedRow?.Cells["PathToPhoto"]?.Value?.ToString() ?? string.Empty;
                if (!string.IsNullOrEmpty(imagePath))
                {

                    ShowImage(imagePath);
                }
            }
        }

        private void ShowImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                Image image = Image.FromFile(imagePath);

                pictureBox1.Image = null;
                pictureBox1.Image = image;
            }
        }
    }
}
