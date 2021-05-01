using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Entities.Shared
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
        //public DateTime ModifiedDate { get; set; }
    }
}
