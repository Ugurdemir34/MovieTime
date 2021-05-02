using MovieTime.Core.Entities;
using MovieTime.Entities.Shared;
using System.Collections.Generic;
namespace MovieTime.Entities.Concrete
{
    public class Tag:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public ICollection<MovieTag> MovieTags { get; set; }
    }
}
