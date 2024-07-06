using Microsoft.Data.SqlClient;
using Store.Domain;
using Store.Domain.Entities;
using StoreWinFrom.Forms;

namespace StoreWinFrom
{

    public partial class LoginForm : Form
    {
        private readonly AppDbContext _context;
        public LoginForm(AppDbContext context)
        {
            
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            _context = context;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPasswordInput.PasswordChar = '*';
            txtLoginInput.MaxLength = 50;
            txtPasswordInput.MaxLength = 50;
        }
        private void btnEscapeLogForm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы хотите выйти из приложения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                this.Show();
            }
        }

        private void btnEnterLogForm_Click(object sender, EventArgs e)
        {
            var username = txtLoginInput.Text;
            var password = txtPasswordInput.Text;

            var isEmployeeExist = _context.Employees.Any(u => u.Username == username && u.Password == password);
            if (isEmployeeExist)
            {
                new MainForm().Show();
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }
    }
}
