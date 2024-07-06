using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Employee : Entity
    {
        public int RoleId { get; set; }

        [ForeignKey(nameof(RoleId))]
        public Role? Role { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => $"{LastName} {Name} {Patronymic}";

        [Required(AllowEmptyStrings = true)]
        public string Patronymic { get; set; }
        public DateOnly DateOnly { get; set; }
        public string? Phone { get; set; }
        public string? PathToPhoto { get; set; }

        [Required, RegularExpression(@"^.*[a-zA-z]", ErrorMessage ="Введите верное значение")]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
