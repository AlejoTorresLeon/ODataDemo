using System.Text.Json.Serialization;

namespace WebApplication1.Entity
{
    public class Persona
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Ciudad { get; set; }

//        [JsonIgnore]
        public Contrato? Contrato  { get; set; }
    }

}
