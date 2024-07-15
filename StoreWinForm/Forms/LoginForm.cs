using Microsoft.Extensions.DependencyInjection;
using Store.Domain;
using StoreWinForm.Forms;
using StoreWinFrom.Forms;
using System.Text.RegularExpressions;

namespace StoreWinFrom
{

    public partial class LoginForm : FormBase
    {
        public LoginForm(IServiceProvider serviceProvider, AppDbContext context) : base(serviceProvider, context)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPasswordInput.UseSystemPasswordChar = true;
            txtLoginInput.MaxLength = 50;
            txtPasswordInput.MaxLength = 50;
        }

        private void btnEscapeLogForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("�� ������ ����� �� ����������?", "�����", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                Close();
            }
            else
            {
                Show();
            }
        }

        private void btnEnterLogForm_Click(object sender, EventArgs e)
        {
            var username = txtLoginInput.Text;
            var password = txtPasswordInput.Text;

            /*
             * �������� �� ���� ���� ���� � ���� � ������ � ������
             */
            string pattern = @"^[a-zA-Z0-9]*$";
            if (!Regex.IsMatch(username, pattern) || !Regex.IsMatch(password, pattern))
            {
                MessageBox.Show("����� ������� ������ ���������� ����� � �����.", "������", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtLoginInput.Text = Regex.Replace(username, "[^a-zA-Z0-9]", "");
                txtPasswordInput.Text = Regex.Replace(password, "[^a-zA-Z0-9]", "");
                return;
            }

            /*
             * �������� ������ � ������ � ������� � ��
             */
            var isEmployeeExist = Context.Employees.Any(u => u.Username == username && u.Password == password);
            if (isEmployeeExist)
            {
                var mainForm = ServiceProvider.GetService<MainForm>();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("�������� ������, ���������� ��� ���", "������ �����������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }


        /*
         * ��������� ������ ����� � ����������� ������
         */
        private void btnVisiblePassword_Click(object sender, EventArgs e)
        {
            btnInvisiblePassword.Visible = true;
            btnVisiblePassword.Visible = false;
            txtPasswordInput.UseSystemPasswordChar = false;
        }
        private void btnInvisiblePassword_Click(object sender, EventArgs e)
        {
            btnInvisiblePassword.Visible = false;
            btnVisiblePassword.Visible = true;
            txtPasswordInput.UseSystemPasswordChar = true;
        }
    }
}
