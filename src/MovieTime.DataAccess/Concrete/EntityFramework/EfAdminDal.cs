using MovieTime.Core.DataAccess.EntityFramework;
using MovieTime.DataAccess.Abstract;
using MovieTime.DataAccess.Concrete.Contexts;
using MovieTime.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.DataAccess.Concrete.EntityFramework
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, MovieTimeContext>, IAdminDal
    {
    }
}
