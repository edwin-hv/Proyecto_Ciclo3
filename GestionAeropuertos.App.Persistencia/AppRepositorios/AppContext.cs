using Microsoft.EntityFrameworkCore;
using GestionAeropuertos.App.Dominio;
 
namespace GestionAeropuertos.App.Persistencia
{
    public class AppContext: DbContext{
        public DbSet<Aeropuerto> aeropuertos { get; set; }
        public DbSet<Avion> Aviones { get; set; }
        public DbSet<Ruta> rutas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = GestionAeropuertosData");
            }
        }
    } 
}
