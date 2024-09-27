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

            dataGridEmployee.CellClick += dataGridEmployee_CellClick;

            InitColumnNames();
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

        private void InitColumnNames()
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
            dataGridEmployee.Columns[8].Name = "PathToPhoto";
            dataGridEmployee.Columns[11].Name = "Id";
        }

        private void btnExitEmployeeForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDeleteEmployeeForm_Click(object sender, EventArgs e)
        {
            if (dataGridEmployee.SelectedRows.Count <= 0)
            {
                return;
            }

            DataGridViewRow selectedRow = dataGridEmployee.SelectedRows[0];
            if (selectedRow.Cells["Id"].Value == null)
            {
                return;
            }



            int entityId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
            dataGridEmployee.Rows.Remove(selectedRow);
            var entity = Context.Employees.Find(entityId);

            if (entity != null)
            {
                Context.Employees.Remove(entity);
                Context.SaveChanges();
            }
        }      


        /*
         * В зависимости какая строка в datagridview выбрана, 
         * считывает путь в столбце PathToPhoto и при помощи метода ShowImage
         * отображает фото
         */
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

        /*
         * Метод отображает фото сотрудника в picturebox
         */
        private void ShowImage(string imagePath)
        {
            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                Image image = Image.FromFile(imagePath);

                pictureBox1.Image = null;
                pictureBox1.Image = image;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchEmployee = txtSearchBox.Text;

            var employeeSearched = Context.Employees.Where(p => p.LastName.Contains(searchEmployee)).ToList();

            foreach (var employee in employeeSearched)
            {
                MessageBox.Show($"{employee.LastName}");

                foreach (DataGridViewRow row in dataGridEmployee.Rows)
                {
                    if (row.Cells["Id"].Value != null && (int)row.Cells["Id"].Value == employee.Id)
                    {
                        row.Selected = false;
                        row.Selected = true;
                        dataGridEmployee.FirstDisplayedScrollingRowIndex = row.Index;
                        break;
                    }
                }
            }
        }
    }
}
