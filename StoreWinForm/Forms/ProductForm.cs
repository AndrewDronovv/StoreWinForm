using Store.Domain;
using Store.Domain.Entities;
using System.Data;

namespace StoreWinForm.Forms
{
    public partial class ProductForm : FormBase
    {
        public ProductForm(IServiceProvider serviceProvider, AppDbContext context) : base(serviceProvider, context)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            ShowProductCategory();
        }

        private void btnEscapeProdForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int categoryid = cmbCategory.SelectedIndex;
            Category category = Context.Categories.Find(categoryid);
            Context.Categories.Find(categoryid);
        }

        public void ShowProductCategory()
        {
            List<Category> categories = Context.Categories.Select(c => c).ToList();
            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category.Name);
            }
        }

        private void btnSaveProdForm_Click(object sender, EventArgs e)
        {
            int categoryid = cmbCategory.SelectedIndex + 1;
            string name = txtName.Text;
            decimal price = int.Parse(txtPrice.Text);
            int quantity = int.Parse(txtQuantity.Text);

            Product product = new()
            {
                CategoryId = categoryid,
                Name = name,
                Price = price,
                Quantity = quantity,
            };

            Context.Products.Add(product);
            Context.SaveChanges();
            Close();
        }
    }
}
