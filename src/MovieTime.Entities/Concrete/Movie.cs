using MovieTime.Core.Entities;
using MovieTime.Entities.Shared;
using System;
using System.Collections.Generic;
namespace MovieTime.Entities.Concrete
{
    public class Movie : BaseEntity,IEntity
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime Date { get; set; }
        public double Imdb { get; set; }
        public string Actors { get; set; }
        public string Thumbnail { get; set; }
        //Navigation Property
        public virtual ICollection<MovieCategory> MovieCategories { get; set; }
        public virtual ICollection<MovieTag> MovieTags { get; set; }
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
