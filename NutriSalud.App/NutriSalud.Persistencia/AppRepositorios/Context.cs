using Microsoft.EntityFrameworkCore;
using NutriSalud.Dominio;

namespace NutriSalud.Persitencia
{
    public class Context : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Nutricionista> Nutricionistas { get; set; }
        public DbSet<Coach> Coachs { get; set; }
        public DbSet<HistoricoPaciente> HistoricoPacientes { get; set; }
        public DbSet<Recomendacion> Recomendaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =NutriSaludDBB");
            }
        }
    }
}