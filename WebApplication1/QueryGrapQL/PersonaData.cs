using WebApplication1.Entity;

namespace WebApplication1.QueryGrapQL
{
    public class PersonaData
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

        private List<Contrato> contratos = new List<Contrato>
        {
            new Contrato {Id = 1,PersonaId = 5,Descripcion = "Contrato para hacer un trabajo x",DuracionDias = 5},
            new Contrato {Id = 2,PersonaId = 2,Descripcion = "Contrato para hacer un trabajo t",DuracionDias = 9},
            new Contrato {Id = 3,PersonaId = 2,Descripcion = "Contrato para hacer un trabajo y",DuracionDias = 10},
            new Contrato {Id = 4,PersonaId = 6,Descripcion = "Contrato para hacer un trabajo y",DuracionDias = 2}
        };

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public List<Persona> GetPersonas()
        {
            return personas;
        }

        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public List<Contrato> GetContratos()
        {
            return contratos;
        }

    }
}
