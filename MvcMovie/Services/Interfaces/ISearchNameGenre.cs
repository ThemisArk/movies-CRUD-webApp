using MvcMovie.Models;

namespace MvcMovie.Services.Interfaces
{
    public interface ISearchNameGenre
    {
        Task<MovieGenreViewModel> SearchNameGenreTwo(string movieGenre, string searchString);
    }
}