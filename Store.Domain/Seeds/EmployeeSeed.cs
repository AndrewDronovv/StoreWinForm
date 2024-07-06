using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Seeds
{
    internal class EmployeeSeed : BaseSeed
    {
        public EmployeeSeed(AppDbContext context) : base(context)
        {
        }

        public override void Seed()
        {
            var roleId = Context.Roles.First(r => r.Name == "Администратор").Id;
            var employees = new List<Employee>
            {
                new Employee
                {
                    RoleId = roleId,
                    Name = "Андрей",
                    LastName = "Хабаров",
                    Patronymic = "Владимирович",
                    DateOnly = new DateOnly(1989,09,29),
                    Phone = "8(965)-298-10-85",
                    PathToPhoto = null,
                    Username = "admin",
                    Password = "admin"
                },
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
