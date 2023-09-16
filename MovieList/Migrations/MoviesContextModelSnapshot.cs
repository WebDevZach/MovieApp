﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieList.Models;

#nullable disable

namespace MovieList.Migrations
{
    [DbContext(typeof(MoviesContext))]
    partial class MoviesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MovieList.Models.Genre", b =>
                {
                    b.Property<string>("genreId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("genreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            genreId = "A",
                            name = "Action"
                        },
                        new
                        {
                            genreId = "C",
                            name = "Comedy"
                        },
                        new
                        {
                            genreId = "D",
                            name = "Drama"
                        },
                        new
                        {
                            genreId = "H",
                            name = "Horror"
                        },
                        new
                        {
                            genreId = "M",
                            name = "Musical"
                        },
                        new
                        {
                            genreId = "R",
                            name = "RomCom"
                        },
                        new
                        {
                            genreId = "S",
                            name = "SciFi"
                        });
                });

            modelBuilder.Entity("MovieList.Models.Movie", b =>
                {
                    b.Property<int>("movieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("movieId"));

                    b.Property<string>("genreId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("rating")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("movieId");

                    b.HasIndex("genreId");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            movieId = 1,
                            genreId = "D",
                            rating = 5,
                            title = "Casablanca",
                            year = 1942
                        },
                        new
                        {
                            movieId = 2,
                            genreId = "A",
                            rating = 3,
                            title = "Wonder Woman",
                            year = 2017
                        },
                        new
                        {
                            movieId = 3,
                            genreId = "R",
                            rating = 4,
                            title = "Moonstruck",
                            year = 1988
                        });
                });

            modelBuilder.Entity("MovieList.Models.Movie", b =>
                {
                    b.HasOne("MovieList.Models.Genre", "Genre")
                        .WithMany()
                        .HasForeignKey("genreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Genre");
                });
#pragma warning restore 612, 618
        }
    }
}