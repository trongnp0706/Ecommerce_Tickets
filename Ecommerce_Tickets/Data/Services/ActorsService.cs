using Ecommerce_Tickets.Data.Base;
using Ecommerce_Tickets.Models;

using Microsoft.EntityFrameworkCore;

using System;

namespace Ecommerce_Tickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(ApplicationDbContext context) : base(context) { }
    }
}
