using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using System.Collections.Generic;
using System.Linq;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    public class ODataPruebaController : ODataController
    {
        private List<Persona> personas = new List<Persona>
        {
            new Persona { Id = 1,Nombre = "Juan", Apellido = "Perez", Edad = 30, Ciudad = "Bogota" },
            new Persona { Id = 2 ,Nombre = "Maria", Apellido = "Gomez", Edad = 25, Ciudad = "Medellin" },
            new Persona { Id = 3 ,Nombre = "Fernando", Apellido = "Gomez", Edad = 33, Ciudad = "Medellin" },
            new Persona { Id = 4 ,Nombre = "Alejo", Apellido = "Torres", Edad = 25, Ciudad = "Bogota" },
            new Persona { Id = 5 ,Nombre = "Alex", Apellido = "Torres", Edad = 40, Ciudad = "Cali" },
            new Persona { Id = 6 ,Nombre = "Mario", Apellido = "Ruiz", Edad = 11, Ciudad = "Monteria" }
        };


        [HttpGet]
        [EnableQuery]
        [Route("Get")]
        public IActionResult Get(ODataQueryOptions<Persona> options)
        {

            if (options.Top == null)
            {
                return BadRequest("Por favor, incluya el parámetro $top para limitar los resultados");
            }

            int topValue;
            if (!int.TryParse(options.Top.RawValue, out topValue))
            {
                return BadRequest("El valor de $top no es válido");
            }

            if (topValue < 0 || topValue > 1000)
            {
                return BadRequest("El parámetro $top debe ser entre 0 y 1000");
            }


            return Ok(personas.AsQueryable());
        }
    }


}
