using Ecommerce_Tickets.Models;

namespace Ecommerce_Tickets.Data.Services
{
    public class IActorsService
    {
        Task<IEnumerable<Actor>> GetAll();
        Actor GetById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
