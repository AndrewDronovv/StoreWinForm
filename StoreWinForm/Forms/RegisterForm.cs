using Store.Domain;
using Store.Domain.Entities;
using StoreWinForm.Forms;
using System.Text.RegularExpressions;

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

            if (string.IsNullOrWhiteSpace(lastname) || (string.IsNullOrWhiteSpace(name) || roleid == 0 || 
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password)))
            {
                txtLastName.BackColor = Color.LightGoldenrodYellow;
                txtName.BackColor = Color.LightGoldenrodYellow;
                cmbRole.BackColor = Color.LightGoldenrodYellow;
                txtUserName.BackColor = Color.LightGoldenrodYellow;
                txtPassword.BackColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Заполните все подсвеченные поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (dateChanged == false)
            {
                pickerDateOfBirth.CalendarForeColor = Color.LightGoldenrodYellow;
                MessageBox.Show("Заполните поле дата рождения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string pattern = @"^[a-zA-Z0-9]*$";
            if (!Regex.IsMatch(username, pattern) || !Regex.IsMatch(password, pattern))
            {
                MessageBox.Show("Логин и пароль содержит \nтолько английские буквы и цифры.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserName.Text = Regex.Replace(username, "[^a-zA-Z0-9]", "");
                txtPassword.Text = Regex.Replace(password, "[^a-zA-Z0-9]", "");
                txtPassword.BackColor = Color.LightGoldenrodYellow;
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
        /*
         * Позволяет выбрать фото сотрудника, применяя шаблон расширений файлов, сохраняет 
         * в переменную путь до файла
         */
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
