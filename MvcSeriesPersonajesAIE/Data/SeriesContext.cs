using Microsoft.EntityFrameworkCore;
using MvcSeriesPersonajesAIE.Models;

namespace MvcSeriesPersonajesAIE.Data
{
    public class SeriesContext : DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options):base (options) { }

        public DbSet<Serie> Series { get; set; }
        public DbSet<Personaje> Personaje { get; set; } 

    }
}
