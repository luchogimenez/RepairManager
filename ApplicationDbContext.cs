using Microsoft.EntityFrameworkCore;
using RepairManager.Entity;

namespace RepairManager
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
           
        }
        public DbSet<Ticket> Tickets { get; set; }

    }
}
