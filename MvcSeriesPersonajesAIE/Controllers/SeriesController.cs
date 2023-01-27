using Microsoft.AspNetCore.Mvc;
using MvcSeriesPersonajesAIE.Models;
using MvcSeriesPersonajesAIE.Repositories;

namespace MvcSeriesPersonajesAIE.Controllers
{
    public class SeriesController : Controller
    {
        private RepositorySeries repo;
        public SeriesController(RepositorySeries repo)
        {
            this.repo = repo;
        }

        public IActionResult ListadoSeries()
        {
            List<Serie> series = this.repo.GetSeries();
            return View(series);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Serie serie)
        {
            this.repo.InsertarSerie(serie);
            return RedirectToAction("ListadoSeries");
        }

        public IActionResult Details(int id)
        {
            Serie serie = this.repo.FindSerie(id);
            return View(serie);
        }

        public IActionResult PersonajesSerie(int id)
        {
            List<Personaje> personajes = this.repo.GetPersonajesSerie(id);
            return View(personajes);
        }
    }
}
