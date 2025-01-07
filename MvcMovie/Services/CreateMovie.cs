using MvcMovie.Data;
using MvcMovie.Models;
using MvcMovie.Services.Interfaces;


namespace MvcMovie.Services
{
    public class CreateMovie : ICreateMovie
    {
        private readonly MvcMovieContext _context;
        public CreateMovie(MvcMovieContext context)
        {
            _context = context;
        }
        public async Task<bool> CreateEntry(Movie movie)
        {
            _context.Add(movie);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}