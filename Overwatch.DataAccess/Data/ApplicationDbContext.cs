using Microsoft.EntityFrameworkCore;
using Overwatch.Models;

namespace Overwatch.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Organisation> Organisations { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<ProjectDetail> ProjectDetails { get; set; }
    }
}
