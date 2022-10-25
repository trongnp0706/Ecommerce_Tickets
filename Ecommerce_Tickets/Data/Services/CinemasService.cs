using Ecommerce_Tickets.Data.Base;
using Ecommerce_Tickets.Models;
using System;

namespace Ecommerce_Tickets.Data.Services
{
    public class CinemasService : EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(ApplicationDbContext context) : base(context)
        {
        }
    }
}
