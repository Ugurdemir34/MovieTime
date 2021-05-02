using Microsoft.EntityFrameworkCore;
using MovieTime.DataAccess.Concrete.Mappings;
using MovieTime.Entities.Concrete;
namespace MovieTime.DataAccess.Concrete.Contexts
{
    public class MovieTimeContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Tag> Tags { get; set; }
        //public DbSet<MovieTag> MovieTags { get; set; }
        //public DbSet<MovieCategory> MovieCategories { get; set; }
        //public DbSet<MovieGenre> MovieGenres { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-D77PTSR\UGUR;Database=MovieDB;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(left => left.Movies)
                .WithMany(right => right.Categories)
                .UsingEntity(join => join.ToTable("MovieCategories"));

            modelBuilder.Entity<Genre>()
              .HasMany(left => left.Movies)
              .WithMany(right => right.Genres)
              .UsingEntity(join => join.ToTable("MovieGenres"));

            modelBuilder.Entity<Tag>()
              .HasMany(left => left.Movies)
              .WithMany(right => right.Tags)
              .UsingEntity(join => join.ToTable("MovieTags"));
            ///*Movie Category*/
            //modelBuilder.Entity<MovieCategory>()
            //    .HasKey(x => new { x.CategoryId, x.MovieId });

            //modelBuilder.Entity<MovieCategory>()
            //    .HasOne<Category>(mc => mc.Category)
            //    .WithMany(m => m.MovieCategories)
            //    .HasForeignKey(mc => mc.CategoryId);

            //modelBuilder.Entity<MovieCategory>()
            //    .HasOne<Movie>(mc => mc.Movie)
            //    .WithMany(m => m.MovieCategories)
            //    .HasForeignKey(mc => mc.MovieId);
            ///*Movie Category*/

            ///*Movie Genre*/
            //modelBuilder.Entity<MovieGenre>()
            //    .HasKey(x => new { x.GenreId, x.MovieId });

            //modelBuilder.Entity<MovieGenre>()
            //    .HasOne<Genre>(mg => mg.Genre)
            //    .WithMany(m => m.MovieGenres)
            //    .HasForeignKey(mg => mg.GenreId);

            //modelBuilder.Entity<MovieGenre>()
            //    .HasOne<Movie>(mc => mc.Movie)
            //    .WithMany(m => m.MovieGenres)
            //    .HasForeignKey(mg => mg.MovieId);

            ///*Movie Genre*/

            ///*Movie Tag*/
            //modelBuilder.Entity<MovieTag>()
            //    .HasKey(x => new { x.TagId, x.MovieId });

            //modelBuilder.Entity<MovieTag>()
            //    .HasOne<Tag>(mg => mg.Tag)
            //    .WithMany(m => m.MovieTags)
            //    .HasForeignKey(mg => mg.TagId);

            //modelBuilder.Entity<MovieTag>()
            //    .HasOne<Movie>(mc => mc.Movie)
            //    .WithMany(m => m.MovieTags)
            //    .HasForeignKey(mg => mg.MovieId);

            ///*Movie Tag*/

            modelBuilder.ApplyConfiguration(new MovieMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new CommentMap());
            modelBuilder.ApplyConfiguration(new GenreMap());
            modelBuilder.ApplyConfiguration(new TagMap());
            modelBuilder.ApplyConfiguration(new AdminMap());
        }
    }
}
