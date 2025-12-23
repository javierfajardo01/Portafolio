using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //var persona = new Persona("Pepe Gotera", 54);

            //ViewBag.Nombre = "Fortunata";
            //ViewBag.Edad = 99;
            //return View("Index", "Elsa Pato");
            var proyectos = ObtenerProyectos().Take(3).ToList();
            var modelo = new HomeIndexDTO() { Proyectos = proyectos };
            return View(modelo);
        }

        //Funcion para mostrar los proyectos
        private List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>() 
            {
                new ProyectoDTO
                {
                    Titulo = "ProyectoWebF1",
                    Descripcion = "Página para consultar las últimas novedades de la Fórmula1 y comprar merchandising oficial",
                    Link = "https://github.com/javierfajardo01/Portafolio.git",
                    ImagenURL = "/img/GitHub-Logo.png"
                },
                new ProyectoDTO
                {
                    Titulo = "ProyectoMigracion",
                    Descripcion = "Página para consultar las últimas novedades de la Fórmula1 y comprar merchandising oficial",
                    Link = "https://github.com/javierfajardo01/Portafolio.git",
                    ImagenURL = "/img/GitHub-Logo.png"},
                new ProyectoDTO
                {
                    Titulo = "ProyectoWebAzure",
                    Descripcion = "Página para consultar las últimas novedades de la Fórmula1 y comprar merchandising oficial",
                    Link = "https://github.com/javierfajardo01/Portafolio.git",
                    ImagenURL = "/img/GitLab.png"},
            };
        }

        public IActionResult Ejercicio7()
        {
            var persona = new Persona("Jonh Portfolio", 23);

            return View(persona);
        }

        public IActionResult Ejercicio8()
        {
            var persona = new Persona("Jonh Portfolio", 23);

            return View(persona);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
