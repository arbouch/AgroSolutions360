using AgroSolutions360.Models.Models;
using Microsoft.EntityFrameworkCore;
using AgroSolutions360.Models.Dtos.Vache;

namespace AgroSolutions360.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Vache> Vaches { get; set; }
        public DbSet<AgroSolutions360.Models.Dtos.Vache.VacheDto>? VacheDto { get; set; }

 
    }
}
