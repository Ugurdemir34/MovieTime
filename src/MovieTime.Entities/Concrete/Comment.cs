using MovieTime.Core.Entities;
using MovieTime.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Entities.Concrete
{
    public class Comment:IEntity
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string UserComment { get; set; }
        public DateTime Date { get; set; }
    }
}
