using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Models.Enuns;


namespace RpgApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]

    public class PersonagensExemploController : ControllerBase
    {
         private static List<Personagem> personagens = new List<Personagem>()
        {
            //Colar os objetos da lista do chat aqui
            new Personagem() { Id = 1, Nome = "Frodo", PontosVida=100, Forca=17, Defesa=23, Inteligencia=33, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 2, Nome = "Sam", PontosVida=100, Forca=15, Defesa=25, Inteligencia=30, Classe=ClasseEnum.Cavaleiro},
            new Personagem() { Id = 3, Nome = "Galadriel", PontosVida=100, Forca=18, Defesa=21, Inteligencia=35, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 4, Nome = "Gandalf", PontosVida=100, Forca=18, Defesa=18, Inteligencia=37, Classe=ClasseEnum.Mago },
            new Personagem() { Id = 5, Nome = "Hobbit", PontosVida=100, Forca=20, Defesa=17, Inteligencia=31, Classe=ClasseEnum.Cavaleiro },
            new Personagem() { Id = 6, Nome = "Celeborn", PontosVida=100, Forca=21, Defesa=13, Inteligencia=34, Classe=ClasseEnum.Clerigo },
            new Personagem() { Id = 7, Nome = "Radagast", PontosVida=100, Forca=25, Defesa=11, Inteligencia=35, Classe=ClasseEnum.Mago }
        };

        //VISUALIZAR PRIMEIRO PERSONAGEM
        [HttpGet("Get")]       
        public IActionResult GetFirst()
        {
            //Personagem p = personagens [0];
            return Ok (personagens [0]);
        }
        
        //VISUALIZAR TODOS PERSONAGENS
        [HttpGet("GetAll")]
        public IActionResult Get()
        {
            return Ok (personagens);
        }

        //VISUALIZAR PERSONAGEM PELO ID
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id)
        {
            return Ok(personagens.FirstOrDefault(pe => pe.Id == id));
        }

        //ADICIONAR NOVO PERSONAGEM
        [HttpPost]
        public IActionResult AddPersonagem(Personagem novoPesrsonagem){
            personagens.Add(novoPesrsonagem);
            return Ok(personagens);
        }

        // [HttpPost]  POST COM BADREQUEST DE VALIDAÇÂO
        // public IActionResult AddPersonagem(Personagem novoPesrsonagem){
        //     if (novoPesrsonagem.Inteligencia == 0)
        //         return BadRequest("Inteligencia não pode ter o valor igual ou menor que 0 (zero)");
            
        //     personagens.Add(novoPesrsonagem);
        //     return Ok(personagens);
        // }

        //VISUALIZAR PERSONAGENS ORDENADOS PELA FORÇA
        [HttpGet("GetOrdenado")]
        public IActionResult GetOrdem(){
            List<Personagem> listaFinal = personagens.OrderBy(p=> p.Forca).ToList();
            return Ok(listaFinal);
        }

        //VISUALIZAR QUANTIDADE DE FUNCIONARIOS
        [HttpGet("GetContagem")]
        public IActionResult GetQauntidade(){
            return Ok("Quantidade de personagens: " + personagens.Count);
        }

        //VISUALIZAR SOMA DA FORÇA PERSONAGENS
        [HttpGet("GetSomaForca")]
        public IActionResult GetSomaForca(){
            return Ok(personagens.Sum(p => p.Forca));
        }

        //VISUALIZAR LISTA SEM EXIBIR CLASSE CAVALEIROS
        [HttpGet("GetSemCavaleiro")]
        public IActionResult GetSemCavaleiro(){
            List<Personagem> listaBusca = personagens.FindAll(p => p.Classe != ClasseEnum.Cavaleiro);
            return Ok(listaBusca);
        }
    
        //VISUALIZAR PERSONAGEM POR NOME
        [HttpGet("GetByNomeAproximado/{nome}")]
        public IActionResult GetByNomeAproximado(string nome){
            List<Personagem> listaBusca = personagens.FindAll(p => p.Nome.Contains(nome));
            return Ok(listaBusca);
        }

        //VISUALIZAR PERSONAGENS REMOVENDO CLASSE MAGO
        [HttpGet("GetRemovendoMago")]
        public IActionResult GetRemovendoMago(){
            Personagem pRemove = personagens.Find(p => p.Classe == ClasseEnum.Mago);
            personagens.Remove(pRemove);
            return Ok("Personagens removidos: " + pRemove.Nome);
        }

        //VISUALIZAR PERSONAGEM PELA FORÇA
        [HttpGet("GetByForca/{forca}")]
        public IActionResult get(int forca){
            List<Personagem> listaFinal = personagens.FindAll(p => p.Forca == forca);
            return Ok(listaFinal);
        }

    }
}