using Microsoft.EntityFrameworkCore;
using Overwatch.Models;

namespace Overwatch.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
    }
}
