using Portafolio.Models;

namespace Portafolio.Controllers
{
    //Normalmente esta clase se utiliza para realizar conexiones con la BD, 
    // en este caso, mandaremos informacion entre las distintas partes de nuestro proyecto.
    public class RepositorioProyectos
    {
        //Funcion para mostrar los proyectos (tenemos que ponerlo public para
        //poder acceder al método desde fuera de la clase)
        public List<ProyectoDTO> ObtenerProyectos()
        {
            return new List<ProyectoDTO>()
            {
                new ProyectoDTO
                {
                    Titulo = "ProyectoWebF1",
                    Descripcion = "Página para consultar las últimas novedades de la Fórmula1 y comprar merchandising oficial",
                    Link = "https://github.com/javierfajardo01/Portafolio.git",
                    ImagenURL = "/img/logoF1.png"
                },
                new ProyectoDTO
                {
                    Titulo = "ProyectoMigracion",
                    Descripcion = "Página para consultar las últimas novedades de la Fórmula1 y comprar merchandising oficial",
                    Link = "https://github.com/javierfajardo01/Portafolio.git",
                    ImagenURL = "/img/GitHub-Logo.png"
                },
                new ProyectoDTO
                {
                    Titulo = "ProyectoWebAzure",
                    Descripcion = "Página para consultar las últimas novedades de la Fórmula1 y comprar merchandising oficial",
                    Link = "https://github.com/javierfajardo01/Portafolio.git",
                    ImagenURL = "/img/GitLab.png"},
            };
        }
    }
}
