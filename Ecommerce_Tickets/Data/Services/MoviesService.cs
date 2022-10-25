using Ecommerce_Tickets.Data.Base;
using Ecommerce_Tickets.Models;
using System;

namespace Ecommerce_Tickets.Data.Services
{
    public class MoviesService : EntityBaseRepository<Movie>, IMoviesService
    {
        public MoviesService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
