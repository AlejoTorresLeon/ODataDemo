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
        [Route("Get")]
        public IActionResult Get(ODataQueryOptions<Persona> options)
        {
            // Obtenemos el valor de $top si está presente en la consulta
            var topValue = options.Top?.Value;

            // Si $top no está presente o es mayor que 10, devolvemos un BadRequest
            if (!topValue.HasValue)
            {
                return BadRequest("Debe especificar un valor para $top");
            }
            else if (topValue > 10)
            {
                return BadRequest("Especifique un valor inferior a 10 en $top");
            }

            var settings = new ODataQuerySettings();

            IQueryable<Persona> result = options.ApplyTo(personas.AsQueryable(), settings) as IQueryable<Persona>;

            return Ok(result);
        }


    }
}
