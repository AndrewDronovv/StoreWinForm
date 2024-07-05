using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public Product()
        {
        }
        public Product(int categoryId, string name, decimal price, int quantity)
        {
            CategoryId = categoryId;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}
