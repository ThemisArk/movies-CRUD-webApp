using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;
using MvcMovie.Services.Interfaces;

namespace MvcMovie.Services
{
    public class SearchNameGenre : ISearchNameGenre
    {
        private readonly MvcMovieContext _context;

        public SearchNameGenre(MvcMovieContext context) {

            _context = context;
        }

        public async Task<MovieGenreViewModel> SearchNameGenreTwo(string movieGenre, string searchString)
        {
            var genreQuery = _context.Movie
                                 .OrderBy(movie => movie.Genre)
                                 .Select(movie => movie.Genre);

            var movies = _context.Movie.Select(movie => movie);


            if (!string.IsNullOrEmpty(searchString))
            {
                movies = movies.Where(s => s.Title!.ToUpper().Contains(searchString.ToUpper()));
            }

            if (!string.IsNullOrEmpty(movieGenre))
            {
                movies = movies.Where(x => x.Genre == movieGenre);
            }

            var movieGenreVM = new MovieGenreViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                Movies = await movies.ToListAsync()
            };
            return movieGenreVM;
        }
    }
}