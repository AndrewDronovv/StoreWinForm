using Microsoft.EntityFrameworkCore.Storage;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Seeds
{
    public class CategorySeed : BaseSeed
    {
        public CategorySeed(AppDbContext context) : base(context)
        {
        }

        public override void Seed()
        {
            var categories = new[] { "Хирургия", "Терапевтия", "Ортопедия", "Анестезия"};
            foreach (var categoryName in categories)
            {
                var category = Context.Categories.FirstOrDefault(c => c.Name == categoryName);
                if (category == null)
                {
                    Context.Categories.Add(new Category(categoryName));
                }
            }
            Context.SaveChanges();
        }
    }
}
