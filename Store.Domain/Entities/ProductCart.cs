using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain.Entities
{
    public class ProductCart : Entity
    {
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }
        public int CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; }
        public int QuantityProduct { get; set; }
    }
}
