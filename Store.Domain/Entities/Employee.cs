using System.ComponentModel.DataAnnotations.Schema;

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
        public string? Patronymic { get; set; }
        public DateOnly DateOnly { get; set; }
        public string? Phone { get; set; }
        public string? PathToPhoto { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
    }
}
