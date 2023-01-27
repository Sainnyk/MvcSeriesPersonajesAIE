using MvcSeriesPersonajesAIE.Data;
using MvcSeriesPersonajesAIE.Models;

namespace MvcSeriesPersonajesAIE.Repositories
{
    public class RepositorySeries
    {
        private SeriesContext context;

        public RepositorySeries(SeriesContext context)
        {
            this.context = context;
        }

        public List<Serie> GetSeries()
        {
            var consulta = from datos in this.context.Series select datos;
            return consulta.ToList();
        }

        public void InsertarSerie(Serie serie)
        {
            this.context.Add(serie);
            this.context.SaveChanges();
        }

        public Serie FindSerie(int id)
        {
            var consulta = from datos in this.context.Series where datos.IdSerie == id select datos;
            return consulta.FirstOrDefault();
        }
        
        public List<Personaje> GetPersonajesSerie(int id)
        {
            var consulta = from datos in this.context.Personaje where datos.IdSerie == id select datos;
            return consulta.ToList();
        }
    }
}
