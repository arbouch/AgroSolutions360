using AgroSolutions360.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace AgroSolutions360.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Vache> Vaches { get; set; }

 
    }
}
