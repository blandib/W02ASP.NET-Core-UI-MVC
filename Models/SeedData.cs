using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

           
context.Movie.RemoveRange(context.Movie);

context.Movie.AddRange(
    new Movie
    {
        Title = "When Harry Met Sally",
        ReleaseDate = DateTime.Parse("1989-1-11"),
        Genre = "Romantic Comedy",
        Rating = "R",
        Price = 7.99M
    },
    new Movie
    {
        Title = "Ghostbusters",
        ReleaseDate = DateTime.Parse("1984-3-13"),
        Genre = "Comedy",
        Rating = "PG",
        Price = 8.99M
    },
    new Movie
    {
        Title = "Ghostbusters 2",
        ReleaseDate = DateTime.Parse("1989-2-23"),
        Genre = "Comedy",
        Rating = "PG",
        Price = 9.99M
    },
    new Movie
    {
        Title = "Rio Bravo",
        ReleaseDate = DateTime.Parse("1959-4-15"),
        Genre = "Western",
        Rating = "PG-13",
        Price = 3.99M
    },
    new Movie
    {
        Title = "Superman",
        ReleaseDate = DateTime.Parse("1978-12-15"),
        Genre = "Action",
        Rating = "PG",
        Price = 9.99M
    },
    new Movie
    {
        Title = "The Dark Knight",
        ReleaseDate = DateTime.Parse("2008-07-18"),
        Genre = "Action",
        Rating = "PG-13",
        Price = 12.99M
    },
    new Movie
    {
        Title = "Madea Goes to Jail",
        ReleaseDate = DateTime.Parse("2009-02-20"),
        Genre = "Comedy",
        Rating = "PG-13",
        Price = 8.99M
    }
);
context.SaveChanges();
        }
    }
}