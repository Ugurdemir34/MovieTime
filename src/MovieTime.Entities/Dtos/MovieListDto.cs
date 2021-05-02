using MovieTime.Core.Entities;
using MovieTime.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Entities.Dtos
{
    public class MovieListDto:IDto
    {
        public List<Movie> Movies { get; set; }
    }
}
