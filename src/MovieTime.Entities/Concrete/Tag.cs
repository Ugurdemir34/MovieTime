using MovieTime.Core.Entities;
using MovieTime.Entities.Shared;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MovieTime.Entities.Concrete
{
    public class Tag:BaseEntity,IEntity
    {
        public string Name { get; set; }
        [JsonIgnore]
        public List<Movie> Movies { get; set; }
    }
}
