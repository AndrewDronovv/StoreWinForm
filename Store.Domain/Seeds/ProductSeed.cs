using Store.Domain.Entities;

namespace Store.Domain.Seeds
{
    public class ProductSeed : BaseSeed
    {
        public ProductSeed(AppDbContext context) : base(context)
        {
        }

        public override void Seed()
        {
            var categoryFirst = Context.Categories.First(n => n.Name == "Хирургия").Id;
            var categorySecond = Context.Categories.First(n => n.Name == "Терапевтия").Id;
            var cetegoryThird = Context.Categories.First(n => n.Name == "Ортопедия").Id;
            var categoryFourth = Context.Categories.First(n => n.Name == "Анестезия").Id;
            var products = new List<Product>
            {
                new Product
                {
                    CategoryId = categoryFirst,
                    Name = "Bio-Gide Perio (16х22мм) мембрана",
                    Price = 13325, Quantity = 20
                },
                new Product
                {
                    CategoryId = categorySecond,
                    Name = "Bright Light Flow цв.A2 (2шпр.х 2г)-жидкотекучий",
                    Price = 819,
                    Quantity = 70
                },
                new Product
                {
                    CategoryId = cetegoryThird,
                    Name = "Speedex Putty - Спидекс база (910мл), Coltene",
                    Price = 2142,
                    Quantity = 1200
                },
                new Product
                {
                    CategoryId = categoryFourth,
                    Name = "УЛЬТРАКАИН ДС ФОРТЕ - ULTRACAIN D-S FORTE 1:100 000",
                    Price = 19181,
                    Quantity = 500
                },

            };

            foreach (var productList in products)
            {
                var product = Context.Products.FirstOrDefault(p => p.Name == productList.Name);
                if (product == null)
                {
                    Context.Products.Add(productList);
                }
            }
            Context.SaveChanges();
        }
    }
}
