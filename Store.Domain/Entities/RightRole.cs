using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class RightRole : Entity
    {
        public int RoleId { get; set; }
        public int RightId { get; set; }
    }
}
