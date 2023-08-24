namespace RpgApi.obj.Models.Enuns
{
    
     public class Personagem
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string PontosVida { get; set; }
        public string Forca { get; set; }
        public string Defesa { get; set; }
        public string Inteligencia { get; set; }
        public ClasseEnuns Classe{ get; set; }
    }
}
