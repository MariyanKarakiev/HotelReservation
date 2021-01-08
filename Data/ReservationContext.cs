using Data.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ReservationDbContext : DbContext
    {
        public ReservationDbContext()
            : base("name=ReservationDb")
        {

        }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
