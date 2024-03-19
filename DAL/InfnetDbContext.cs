using Microsoft.EntityFrameworkCore;
using GestaoDeLaboratorios.Models;
namespace GestaoDeLaboratorios.DAL
{
    public class InfnetDbContext : DbContext
    {
        public InfnetDbContext(DbContextOptions options) : base (options)
        {
            
        }
        public DbSet<Computadores> Computadores { get; set; }

    }
}
