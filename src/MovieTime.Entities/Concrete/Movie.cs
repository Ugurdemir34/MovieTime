using MovieTime.Core.Entities;
using MovieTime.Entities.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Entities.Concrete
{
    public class Movie : BaseEntity,IEntity
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime Date { get; set; }
        public double Imdb { get; set; }
        public string Actors { get; set; }
        //Navigation Property
        public List<Category> Categories { get; set; }
        public List<MovieType> MovieTypes { get; set; }
        public List<MovieTag> MovieTags { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
