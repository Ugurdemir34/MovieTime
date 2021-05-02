﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieTime.DataAccess.Concrete.Contexts;

namespace MovieTime.DataAccess.Migrations
{
    [DbContext(typeof(MovieTimeContext))]
    partial class MovieTimeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CategoryMovie", b =>
                {
                    b.Property<Guid>("CategoriesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CategoriesId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("CategoryMovie");
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.Property<Guid>("GenresId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GenresId", "MoviesId");

                    b.HasIndex("MoviesId");

                    b.ToTable("GenreMovie");
                });

            modelBuilder.Entity("MovieTag", b =>
                {
                    b.Property<Guid>("MoviesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("TagsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MoviesId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("MovieTag");
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Admin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("2ccaeb78-b0ce-49e3-887e-18ddd7ae57e7"),
                            CreationDate = new DateTime(2021, 5, 2, 8, 10, 23, 106, DateTimeKind.Local).AddTicks(6189),
                            Description = "Yabancı Filmler",
                            Name = "Yabancı"
                        },
                        new
                        {
                            Id = new Guid("4ef02072-a4c8-441e-9c2a-b04c4a0f9ec1"),
                            CreationDate = new DateTime(2021, 5, 2, 8, 10, 23, 108, DateTimeKind.Local).AddTicks(662),
                            Description = "4K Filmler",
                            Name = "4K"
                        });
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Comment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("MovieId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UserComment")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("4b115b0e-8b02-4833-ae50-9b7b2a2f537d"),
                            CreationDate = new DateTime(2021, 5, 2, 8, 10, 23, 111, DateTimeKind.Local).AddTicks(1957),
                            Description = "Aile Filmleri",
                            Name = "Aile"
                        },
                        new
                        {
                            Id = new Guid("58412ea7-36eb-4c94-9032-c03860030df9"),
                            CreationDate = new DateTime(2021, 5, 2, 8, 10, 23, 111, DateTimeKind.Local).AddTicks(2555),
                            Description = "Fantastik Filmler",
                            Name = "Fantastik"
                        });
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Movie", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Actors")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<Guid?>("AdminId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Director")
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<double>("Imdb")
                        .HasColumnType("float");

                    b.Property<string>("Thumbnail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.HasIndex("AdminId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Tag", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.HasKey("Id");

                    b.ToTable("Tags");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ae9b7b9d-7888-4bca-827e-c50b2e5755a7"),
                            CreationDate = new DateTime(2021, 5, 2, 8, 10, 23, 112, DateTimeKind.Local).AddTicks(2076),
                            Description = "HarryPotter Tagi",
                            Name = "Harry Potter Serisi"
                        },
                        new
                        {
                            Id = new Guid("fe654997-0c93-4125-8bfb-8d550c9c80ef"),
                            CreationDate = new DateTime(2021, 5, 2, 8, 10, 23, 112, DateTimeKind.Local).AddTicks(2658),
                            Description = "HarryPotter Tagi2",
                            Name = "Harry Potter Filmleri İzle"
                        });
                });

            modelBuilder.Entity("CategoryMovie", b =>
                {
                    b.HasOne("MovieTime.Entities.Concrete.Category", null)
                        .WithMany()
                        .HasForeignKey("CategoriesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTime.Entities.Concrete.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GenreMovie", b =>
                {
                    b.HasOne("MovieTime.Entities.Concrete.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTime.Entities.Concrete.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieTag", b =>
                {
                    b.HasOne("MovieTime.Entities.Concrete.Movie", null)
                        .WithMany()
                        .HasForeignKey("MoviesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MovieTime.Entities.Concrete.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("MovieTime.Entities.Concrete.Movie", null)
                        .WithMany("Comments")
                        .HasForeignKey("MovieId");
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Movie", b =>
                {
                    b.HasOne("MovieTime.Entities.Concrete.Admin", "Admin")
                        .WithMany()
                        .HasForeignKey("AdminId");

                    b.Navigation("Admin");
                });

            modelBuilder.Entity("MovieTime.Entities.Concrete.Movie", b =>
                {
                    b.Navigation("Comments");
                });
#pragma warning restore 612, 618
        }
    }
}
