using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var persona = new Persona("Pepe Gotera", 54);

            //ViewBag.Nombre = "Fortunata";
            //ViewBag.Edad = 99;
            //return View("Index", "Elsa Pato");
            return View(persona);
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
