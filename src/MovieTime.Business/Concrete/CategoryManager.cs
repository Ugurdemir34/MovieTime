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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public async Task<IDataResult<CategoryListDto>> GetAll()
        {
            var categoryList = await _categoryDal.GetListAsync(null);
            if (categoryList.Count > -1)
            {
                return new SuccessDataResult<CategoryListDto>(new CategoryListDto
                {
                    Categories = categoryList.ToList(),
                }, Messages.CategoryList);
            }
            return new ErrorDataResult<CategoryListDto>();
        }
    }
}
