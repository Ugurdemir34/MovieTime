using Microsoft.EntityFrameworkCore;
using MovieTime.DataAccess.Concrete.Mappings;
using MovieTime.Entities.Concrete;
namespace MovieTime.DataAccess.Concrete.Contexts
{
    public class MovieTimeContext :DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<MovieTag> MovieTags { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-D77PTSR\UGUR;Database=MovieDB;Trusted_Connection=true");           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>()
                .HasKey(x => new { x.CategoryId, x.MovieId });

            modelBuilder.Entity<MovieGenre>()
                .HasKey(x => new { x.GenreId, x.MovieId });

            modelBuilder.Entity<MovieTag>()
                .HasKey(x => new { x.TagId, x.MovieId });

            modelBuilder.ApplyConfiguration(new MovieMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new GenreMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new AdminMap());
        }
    }
}
