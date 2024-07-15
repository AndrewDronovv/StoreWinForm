using Store.Domain.Entities;

namespace Store.Domain.Seeds
{
    internal class EmployeeSeed : BaseSeed
    {
        public EmployeeSeed(AppDbContext context) : base(context)
        {
        }

        public override void Seed()
        {
            var roleIdAdmin = Context.Roles.First(r => r.Name == "Администратор").Id;
            var roleIdManager = Context.Roles.First(r => r.Name == "Менеджер по продажам").Id;
            var employees = new List<Employee>
            {
                new Employee
                {
                    RoleId = roleIdAdmin,
                    Name = "Василий",
                    LastName = "Теплов",
                    Patronymic = "Кириллович",
                    DateOnly = new DateOnly(1991,05,17),
                    Phone = "+7(977)-210-15-70",
                    PathToPhoto = "C:\\Users\\Андрей\\source\\repos\\StoreWinForm\\Supplements\\images\\image1.jpg",
                    Username = "admin",
                    Password = "admin"
                },
                new Employee
                {
                    RoleId = roleIdManager,
                    Name = "Сергей",
                    LastName = "Петров",
                    Patronymic = "Иванович",
                    DateOnly = new DateOnly(1995,10,08),
                    Phone = "+7(963)-155-37-75",
                    PathToPhoto = "C:\\Users\\Андрей\\source\\repos\\StoreWinForm\\Supplements\\images\\image2.jpg",
                    Username = "manager",
                    Password = "manager"
                }
            };

            foreach (var employeeList in employees)
            {
                var employee = Context.Employees.FirstOrDefault(e => e.Username == employeeList.Username);
                if (employee == null)
                {
                    Context.Employees.Add(employeeList);
                }
            }
            Context.SaveChanges();
        }
    }
}
