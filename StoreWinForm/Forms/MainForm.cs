using Microsoft.Extensions.DependencyInjection;
using Store.Domain;
using StoreWinForm.Forms;

namespace StoreWinFrom.Forms
{
    public partial class MainForm : FormBase
    {
        private Form activeForm;
        public MainForm(IServiceProvider serviceProvider, AppDbContext context) : base(serviceProvider, context)
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCatalogMainForm_Click(object sender, EventArgs e)
        {
            var catalogForm = ServiceProvider.GetService<CatalogForm>();
            OpenChildForm(catalogForm);
        }
        private void btnEmployeeMainFrom_Click(object sender, EventArgs e)
        {
            var employeeForm = ServiceProvider.GetService<EmployeeForm>();
            OpenChildForm(employeeForm);
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            activeForm.TopLevel = false;
            activeForm.Dock = DockStyle.Fill;
            activeForm.FormBorderStyle = FormBorderStyle.None;

            panelBody.Controls.Add(activeForm);
            panelBody.Tag = activeForm;

            activeForm.BringToFront();
            activeForm.Show();
        }
    }
}
