using System;
using System.Text.Json.Serialization;

namespace MovieTime.Entities.Concrete
{
    public class MovieGenre
    {
        public Guid MovieId { get; set; }
        public Guid GenreId { get; set; }
        [JsonIgnore]   
        public Movie Movie { get; set; }  
        public Genre Genre { get; set; }
    }
}
