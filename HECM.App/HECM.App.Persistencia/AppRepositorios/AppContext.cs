using Microsoft.EntityFrameworkCore;
using HECM.App.Dominio;

namespace HECM.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Persona> Personas {get;set;}
        public DbSet<Mascota> Mascotas {get;set;}
        public DbSet<Veterinario> Veterinarios {get;set;}
        public DbSet<PropietarioDesignado> PropietariosDesignados  {get;set;}
        public DbSet<SignoVital> SignosVitales {get;set;}
        public DbSet<Historia> Historias {get;set;}
        public DbSet<SugerenciaCuidado> SugerenciaCuidados {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HECM.Data");
                }
            }
    }
}