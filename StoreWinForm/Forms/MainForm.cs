using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreWinFrom.Forms
{
    public partial class MainForm : Form
    {
        private Form activeForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCatalogMForm_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CatalogForm());
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

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm());
        }
    }
}
