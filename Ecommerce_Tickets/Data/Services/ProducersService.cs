using Ecommerce_Tickets.Data.Base;
using Ecommerce_Tickets.Models;
using System;

namespace Ecommerce_Tickets.Data.Services
{
    public class ProducersService : EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
