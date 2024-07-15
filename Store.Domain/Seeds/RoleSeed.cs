using Store.Domain.Entities;

namespace Store.Domain.Seeds
{
    public class RoleSeed : BaseSeed
    {
        public RoleSeed(AppDbContext context) : base(context)
        {
        }

        public override void Seed()
        {
            var roles = new[] { "Администратор", "Менеджер по продажам" };
            foreach (var roleName in roles)
            {
                var role = Context.Roles.FirstOrDefault(r => r.Name == roleName);
                if (role == null)
                {
                    Context.Roles.Add(new Role(roleName));
                }
            }
            Context.SaveChanges();
        }
    }
}
