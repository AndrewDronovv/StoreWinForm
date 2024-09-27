using Microsoft.Extensions.DependencyInjection;
using Store.Domain;
using StoreWinForm.Forms;

namespace StoreWinFrom
{
    public partial class CatalogForm : FormBase
    {
        private readonly BindingSource _catalogBindingSourse;
        public CatalogForm(IServiceProvider serviceProvider, AppDbContext context) : base(serviceProvider, context)
        {
            InitializeComponent();
            _catalogBindingSourse = new BindingSource();
            CreateProductCards();
        }

        private void btnAddCatalogForm_Click(object sender, EventArgs e)
        {
            var productForm = ServiceProvider.GetService<ProductForm>();
            productForm.Show();
        }

        public void CreateProductCards()
        {
            int x = 27;
            int y = 150;
            int cardWidth = 200;
            int cardHeight = 150;
            int margin = 10;

            var productList = Context.Products.Select(p => p).ToList();

            foreach (var product in productList)
            {
                Panel card = new Panel()
                {
                    Width = cardWidth,
                    Height = cardHeight,
                    BorderStyle = BorderStyle.FixedSingle,
                };

                Label nameLabel = new Label()
                {
                    Text = $"Name: {product.Name}",
                    Location = new Point(20, 20),
                    AutoSize = true,
                };
                card.Controls.Add(nameLabel);

                Label priceLabel = new Label()
                {
                    Text = $"Price: ${product.Price:F2}",
                    Location = new Point(10, 40),
                    AutoSize = true,
                };
                card.Controls.Add(priceLabel);

                card.Location = new Point(x, y);
                this.Controls.Add(card);

                x += cardWidth + margin;

                if (x + cardWidth > this.Width)
                {
                    x = 10;
                    y += cardHeight + margin;
                }

            }
        }

        private void btnExitCatForm_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
