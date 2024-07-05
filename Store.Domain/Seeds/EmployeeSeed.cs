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
            var employees = new List<Employee>
            {
                new Employee{RoleId = Context.Roles.FirstOrDefault(r => r.Name == "Администратор").Id, Name = "Андрей", LastName = "Хабаров", Patronymic = "Владимирович",
                    DateOnly = new DateOnly(1989,09,29), Phone = "8(965)-298-10-85",
                    PathToPhoto = "C:\\Photo", Username = "admin", Password = "admin"},
            };
            foreach (var employeeList in employees)
            {
                var employee = Context.Employees.FirstOrDefault(e => e.RoleId == employeeList.RoleId && e.Name == employeeList.Name && e.LastName == employeeList.LastName &&
                e.Patronymic == employeeList.Patronymic && e.PathToPhoto == employeeList.PathToPhoto && e.Username == employeeList.Username && e.Password == employeeList.Password);
                if (employee == null)
                {
                    Context.Employees.Add(employeeList);
                }
            }
            Context.SaveChanges();
        }
    }
}
