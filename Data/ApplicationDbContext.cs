using Microsoft.EntityFrameworkCore;
using TekhnikaSite.Models;

namespace TekhnikaSite.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options) { }

        DbSet<Truck> Trucks { get; set; }
        DbSet<Materials> Materials { get; set; }
    }
}
