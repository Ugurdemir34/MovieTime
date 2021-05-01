using System;

namespace MovieTime.Entities.Concrete
{
    public class MovieCategory
    {
        public Guid MovieId { get; set; }
        public Guid CategoryId { get; set; }
        public Movie Movie { get; set; }
        public Category Category { get; set; }
    }
}
