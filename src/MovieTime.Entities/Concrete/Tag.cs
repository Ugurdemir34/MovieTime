using MovieTime.Core.Entities;
using MovieTime.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Entities.Concrete
{
    public class Tag:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
