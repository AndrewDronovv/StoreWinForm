using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain.Entities
{
    public class Product : Entity
    {
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category? Category { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
