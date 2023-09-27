using RpgApi.Models.Enuns;
using System.Text.Json.Serialization;
using RpgApi.Models;


namespace RpgApi.Models
{
    
    public class Personagem 
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int PontosVida { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int Inteligencia { get; set; }
        public ClasseEnum Classe { get; set; }
        public byte[]? FotoPersonagem {get;  set; }

        [JsonIgnore]
        public Usuario? Usuario {get; set; }
       
        [JsonIgnore]
        public Armas Arma { get; set; }

    }
}