using JuninViagens.Data;
using JuninViagens.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace JuninViagens.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly DataContext _dataContext;

        public ClienteController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cliente>>> GetCliente()
        {
            return await _dataContext.Clientes.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Cliente>> GetClienteById(int id)
        {
            var cliente = await _dataContext.Clientes.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }
    }

}