using Store.Domain;
using Store.Domain.Entities;
using StoreWinForm.Forms;

namespace StoreWinFrom.Forms
{
    public partial class RegisterForm : FormBase
    {
        private string pathtopicture;
        private bool dateChanged = false;
        public RegisterForm(IServiceProvider serviceProvider, AppDbContext context) : base(serviceProvider, context)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ShowEployeeRole();
            pickerDateOfBirth.ValueChanged += pickerDateOfBirth_ValueChanged;
        }

        private void btnSaveRegForm_Click(object sender, EventArgs e)
        {
            int roleid = cmbRole.SelectedIndex + 1;
            string name = txtName.Text;
            string lastname = txtLastName.Text;
            string patronymic = txtPatronymic.Text;
            DateOnly dateOnly = new DateOnly();
            dateOnly = DateOnly.Parse(pickerDateOfBirth.Text);
            string phone = mskPhone.Text;
            string photopath = pathtopicture;
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(lastname))
            {
                txtLastName.BackColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Заполните фамилию сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                txtName.BackColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Заполните имя сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dateChanged == false)
            {
                pickerDateOfBirth.CalendarForeColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Дата не была изменена", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (roleid == 0)
            {
                cmbRole.BackColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Заполните роль сотрудника", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                txtUserName.BackColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Заполните логин пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                txtPassword.BackColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Заполните необходимые поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            try
            {
                Employee employee = new()
                {
                    RoleId = roleid,
                    Name = name,
                    LastName = lastname,
                    Patronymic = patronymic,
                    DateOnly = dateOnly,
                    Phone = phone,
                    PathToPhoto = photopath,
                    Username = username,
                    Password = password,
                };
                Context.Employees.Add(employee);
                Context.SaveChanges();
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Заполните все необходимые поля", "Ошибка");
                return;
            }
        }

        /*
         * Ищет в бд id роли в зависимости какую выбрали
         */
        //private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    int roleid = (int)cmbRole.SelectedIndex;
        //    Role role = Context.Roles.Find(roleid);
        //    Context.Roles.Find(roleid);
        //}

        /*
         * Метод который отображает в комбобокс роли сотрудников
         */
        public void ShowEployeeRole()
        {
            List<Role> roles = Context.Roles.Select(r => r).ToList();

            foreach (var role in roles)
            {
                cmbRole.Items.Add(role.Name);
            }
        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = "C:\\Users\\Андрей\\source\\repos\\StoreWinForm\\Supplements\\images";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    empPictureBox.Image = new Bitmap(openFileDialog.FileName);
                    pathtopicture = openFileDialog.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Неверный формат файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEscapeRegForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pickerDateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            dateChanged = true;
        }
    }
}
