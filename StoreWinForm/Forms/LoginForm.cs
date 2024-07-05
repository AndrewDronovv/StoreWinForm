using Microsoft.Data.SqlClient;
using Store.Domain;
using Store.Domain.Entities;
using StoreWinFrom.Forms;

namespace StoreWinFrom
{

    public partial class LoginForm : Form
    {
        AppDbContext appDbContext;
        List<Employee> employeeList;
        MainForm mainForm = new MainForm();
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            appDbContext = new AppDbContext();
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
    }
}
