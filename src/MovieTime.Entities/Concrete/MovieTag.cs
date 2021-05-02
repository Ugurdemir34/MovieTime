using System;
using System.Text.Json.Serialization;

namespace MovieTime.Entities.Concrete
{
    public class MovieTag
    {
        public Guid MovieId { get; set; }
        public Guid TagId { get; set; }
        [JsonIgnore]
        public Movie Movie { get; set; }
        public Tag Tag { get; set; }
    }
}
