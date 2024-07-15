using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
