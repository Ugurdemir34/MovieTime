using MovieTime.Core.Entities;
using MovieTime.Entities.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

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
        public virtual List<Category> Categories { get; set; }    
        public virtual List<Tag> Tags { get; set; }      
        public virtual List<Genre> Genres { get; set; }
        public virtual List<Comment> Comments { get; set; }
        public virtual Admin Admin { get; set; }
    }
}
