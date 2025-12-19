using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Portafolio.Models;

namespace Portafolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var persona = new Persona()
            {
                Nombre = "Jacinta",
                Edad = 99,
            };
            //ViewBag.Nombre = "Fortunata";
            //ViewBag.Edad = 99;
            //return View("Index", "Elsa Pato");
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
