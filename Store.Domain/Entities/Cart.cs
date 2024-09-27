using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain.Entities
{
    public class Cart : Entity
    {
        public int EmployeeId { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        public Employee Employee { get; set; }
        public decimal Price { get; set; }
        public bool IsPaid { get; set; }
    }
}
