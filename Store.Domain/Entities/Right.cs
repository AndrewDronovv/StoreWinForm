using System.ComponentModel.DataAnnotations.Schema;

namespace Store.Domain.Entities
{
    public class Right : Entity
    {
        public int GroupRightId { get; set; }


        [ForeignKey(nameof(GroupRightId))]
        public GroupRight GroupRight { get; set; }
        public required string Name { get; set; }

    }
}
