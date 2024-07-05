using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Seeds
{
    public static class AppDbContextInitializer
    {
        public static void Seed(AppDbContext context)
        {
            new CategorySeed(context).Seed();
            new RoleSeed(context).Seed();
            new ProductSeed(context).Seed();
            new EmployeeSeed(context).Seed();
        }
    }
}
