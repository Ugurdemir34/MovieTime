using MovieTime.Core.Utilities.Results;
using MovieTime.Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Business.Abstract
{
    public interface IMovieService
    {
        Task<IDataResult<MovieListDto>> GetAll();
    }
}
