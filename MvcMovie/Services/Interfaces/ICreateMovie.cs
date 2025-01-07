using MvcMovie.Models;

namespace MvcMovie.Services.Interfaces
{
    public interface ICreateMovie
    {
        public Task<bool> CreateEntry(Movie movie);
    }
}