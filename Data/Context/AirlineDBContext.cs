using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class AirlineDBContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Flight> Flight { get; set; }
        public DbSet<Ticket> Ticket { get; set; }
    }
}
