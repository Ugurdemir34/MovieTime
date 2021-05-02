using Autofac;
using MovieTime.Business.Abstract;
using MovieTime.Business.Concrete;
using MovieTime.DataAccess.Abstract;
using MovieTime.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTime.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<MovieManager>().As<IMovieService>();
            builder.RegisterType<EfMovieDal>().As<IMovieDal>();
        }
    }
}
