using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain.Entities
{
    public class Category : Entity
    {
        //TODO: сделать в будущем required
        public string Name { get; set; }

        public Category(string name)
        {
            Name = name;
        }
    }
}
