using MovieTime.Business.Abstract;
using MovieTime.Business.Constants;
using MovieTime.Core.Utilities.Results;
using MovieTime.DataAccess.Abstract;
using MovieTime.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Business.Concrete
{
    public class MovieManager : IMovieService
    {
        private readonly IMovieDal _movieDal;
        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;
        }
        public async Task<IDataResult<MovieListDto>> GetAll()
        {
             var movieList =await _movieDal.GetListAsync(null, m=>m.Admin,m=>m.Comments, m => m.Tags, m => m.Categories, m => m.Genres);
             if (movieList.Count>-1)
             {
                 return  new SuccessDataResult<MovieListDto>(new MovieListDto
                 {
                     Movies = movieList.ToList(),                    
                 },Messages.MovieList);              
             }
             return new ErrorDataResult<MovieListDto>();
            
        }
    }
}
