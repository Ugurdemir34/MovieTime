using System;

namespace MovieTime.Entities.Concrete
{
    public class MovieTag
    {
        public Guid MovieId { get; set; }
        public Guid TagId { get; set; }
        public Movie Movie { get; set; }
        public Tag Tag { get; set; }
    }
}
