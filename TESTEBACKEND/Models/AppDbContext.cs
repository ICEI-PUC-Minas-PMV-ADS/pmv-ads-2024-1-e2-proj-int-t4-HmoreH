using Microsoft.EntityFrameworkCore;

namespace TESTEBACKEND.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Clinica> Clinicas { get; set; }

        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }
    }



}
