using System;
using System.Text.Json.Serialization;

namespace MovieTime.Entities.Concrete
{
    public class MovieCategory
    {
        public Guid MovieId { get; set; }
        public Guid CategoryId { get; set; }
        [JsonIgnore]
        public Movie Movie { get; set; }
        public Category Category { get; set; }
    }
}
