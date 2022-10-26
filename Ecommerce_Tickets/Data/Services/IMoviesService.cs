using Ecommerce_Tickets.Data.Base;
using Ecommerce_Tickets.Data.ViewModels;
using Ecommerce_Tickets.Models;

namespace Ecommerce_Tickets.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
    }
}
