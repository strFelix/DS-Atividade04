using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;


namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class PersonagensExerciciosController : ControllerBase
    {
        private static List<Personagem> personagens = new List<Personagem>()
        {
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=90, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=65, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=85, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=60, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        //lista todos
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok(personagens);
        }
        
        //A - get pelo nome
        [HttpGet("GetByNome/{nome}")]
        public IActionResult GetByName(string nome){
            List<Personagem> personagemBuscas = personagens.FindAll(pers => pers.Nome == nome);
             
            if(personagemBuscas.Count == 0){
                return BadRequest("ERRO: Nome não encontrado!");
            }
            else{
                return Ok(personagemBuscas);
            }
        }

        //B - Adicionando funcionario com validação
        [HttpPost("AdcionarPersonagem")]
        public IActionResult PostValidacao(Personagem novoPersonagem){
            if(novoPersonagem.Defesa < 10 || novoPersonagem.Inteligencia > 30){
                return BadRequest("ERRO: Parametros de personagem errados");
            }
            else{
                personagens.Add(novoPersonagem);
                return Ok(personagens);
            }
        }

        //C - Validação inteligencia para magos
        [HttpPost("ValidarMago")]
        public IActionResult ValidarMago(Personagem novoPersonagem){
            
            if(novoPersonagem.Classe == ClasseEnum.Mago && novoPersonagem.Classe == novoPersonagem.Inteligencia < 35){
                return BadRequest("ERRO: O mago não pode ter menos que 35 de int.");
            }
            else{
                personagens.Add(novoPersonagem);
                return Ok(personagens);
            }
            
        }

        //D - Get Clerigos e Magos
        [HttpGet("ClerigoMago")]
        public IActionResult ClerigoMago(){
            // personagens.RemoveAll(pers => pers.Classe ==  ClasseEnum.Cavaleiro);
            // return Ok(personagens.OrderByDescending(pers => pers.PontosVida));

            List<Personagem> RemoveCavaleiro = personagens.FindAll(p => p.Classe != ClasseEnum.Cavaleiro);

            List<Personagem> OrdenadoPontosVida = RemoveCavaleiro.OrderByDescending(x => x.PontosVida).ToList();

            return Ok(OrdenadoPontosVida);  
        }

        //E - Qunatidade de personagens e somatória da inteligência
        [HttpGet("Estatisticas")]
        public IActionResult Estatisticas(){
            int quantidadePersonagens = personagens.Count();
            int somaInteligencia = personagens.Sum(pers => pers.Inteligencia);
            string outputGet = $"Quatidade de personagens: {quantidadePersonagens} \nSomatória inteligência: {somaInteligencia}";

            return Ok(outputGet);
        }

        //F - Get pela classe 
        [HttpGet("SelecionarPorClasse/{idClasse}")]
        public IActionResult selecionarPorClasse(int idClasse){

            if(idClasse == 1){
                List<Personagem> personagemBuscas = personagens.FindAll(pers => pers.Classe == ClasseEnum.Cavaleiro);
                return Ok(personagemBuscas);
            }
            else if(idClasse == 2){
                List<Personagem> personagemBuscas = personagens.FindAll(pers => pers.Classe == ClasseEnum.Mago);
                return Ok(personagemBuscas);
            }
            else if(idClasse == 3){
                List<Personagem> personagemBuscas = personagens.FindAll(pers => pers.Classe == ClasseEnum.Clerigo);
                return Ok(personagemBuscas);
            }
            else{
                return BadRequest("ERRO: Código de classe não existente");
            }
        }
    }
}