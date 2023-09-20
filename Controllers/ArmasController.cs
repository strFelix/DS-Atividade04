using Microsoft.AspNetCore.Mvc;
using RpgApi.Models;
using RpgApi.Data;
using Microsoft.EntityFrameworkCore;

namespace DS_Atividade04.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ArmasController : ControllerBase
    {   
        private readonly DataContext _context; //variavel global    

        public ArmasController(DataContext context){
            _context = context; //construtor instanciando o objeto
        }

        
        [HttpGet("GetAll")] //Mostrar todas as armas
        public async Task<IActionResult> Get(){
            try{
                List<Armas> lista = await _context.TB_ARMAS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpPost] //Adocionando arma
        public async Task<IActionResult> Add(Armas novaArma){
            
            await _context.TB_ARMAS.AddAsync(novaArma);
            await _context.SaveChangesAsync();

            return Ok(novaArma.Id);
        }

        [HttpPut] //alterando arma pelo ID
        public async Task<IActionResult> Update(Armas novaArma){
            try{
                _context.TB_ARMAS.Update(novaArma);
                int linhasAfetadas = await _context.SaveChangesAsync();
            
                return Ok(linhasAfetadas);
            }
            catch(System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")] //Listando arma por ID
        public async Task<IActionResult> GetSingle(int id){
            try{
                Armas a = await _context.TB_ARMAS.FirstOrDefaultAsync(aBusca => aBusca.Id == id);
                return Ok(a);
            }
            catch (System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

        
        [HttpDelete("{id}")] //deletando arma pelo ID
        public async Task<IActionResult> Delete(int id){
            try{
                Armas aRemover = await _context.TB_ARMAS.FirstOrDefaultAsync(a => a.Id == id);
                _context.TB_ARMAS.Remove(aRemover);
                int linhasAfetadas = await _context.SaveChangesAsync();
                return Ok(linhasAfetadas);
            }
            catch(System.Exception ex){
                return BadRequest(ex.Message);
            }
        }

    }
}


    

