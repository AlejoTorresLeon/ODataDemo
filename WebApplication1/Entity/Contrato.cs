using System.Text.Json.Serialization;

namespace WebApplication1.Entity
{
    public class Contrato
    {        
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string Descripcion { get; set; }
        public int DuracionDias {  get; set; }

        // Navegación a Persona
        [JsonIgnore]
        public Persona Persona { get; set; }
        // Aquí puedes agregar más propiedades para el contrato        
    }
}
