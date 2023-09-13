using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Data;
using Microsoft.EntityFrameworkCore;

namespace DS_Atividade04.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PersonagensController : ControllerBase
    {   
        private readonly DataContext _context; //variavel global    

        public PersonagensController(DataContext context){
            _context = context; //construtor instanciando o objeto
        }

        [HttpGet("{id}")] //Buscar por ID
        public async Task<IActionResult> GetSingle(int id){
            try{
                Personagem p = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(pBusca => pBusca.Id == id);
                return Ok(p);
            }
            catch (System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")] //Mostrar todos os personagens
        public async Task<IActionResult> Get(){
            try{
                List<Personagem> lista = await _context.TB_PERSONAGENS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPost] //Adocionando personagem
        public async Task<IActionResult> Add(Personagem novoPersonagem){
            try{
                if(novoPersonagem.PontosVida > 100){
                    throw new Exception("Pontos de vida não podem ser maior que 100");
                }
                await _context.TB_PERSONAGENS.AddAsync(novoPersonagem);
                await _context.SaveChangesAsync();

                return Ok(novoPersonagem.Id);

            }
            catch(System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPut] //alterando personagem pelo ID
        public async Task<IActionResult> Update(Personagem novoPersonagem){
            try{
                if(novoPersonagem.PontosVida > 100){
                    throw new System.Exception("Pontos de vida não podeser maior que 100");
                }
                _context.TB_PERSONAGENS.Update(novoPersonagem);
                int linhasAfetadas = await _context.SaveChangesAsync();
            
                return Ok(linhasAfetadas);
            }
            catch(System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")] //deletando pelo ID
        public async Task<IActionResult> Delete(int id){
            try{
                Personagem pRemover = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(p => p.Id == id);
                _context.TB_PERSONAGENS.Remove(pRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch(System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

    }
}