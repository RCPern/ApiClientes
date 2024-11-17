using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ClientesAPI.Models;

namespace ClientesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private readonly ClientesContext _context;

        public ClientesController(ClientesContext context)
        {
            _context = context;
        }

        [HttpPost("CrearCliente")]
        public async Task<IActionResult> CrearCliente(Cliente cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();
            return Ok(cliente);
        }

        [HttpPost("CrearInformacion")]
        public async Task<IActionResult> CrearInformacion(InformacionCliente info)
        {
            _context.InformacionClientes.Add(info);
            await _context.SaveChangesAsync();
            return Ok(info);
        }

        [HttpGet("ListadoGeneral")]
        public async Task<IActionResult> ListadoGeneral()
        {
            var result = await _context.Clientes
                .Include(c => c.InformacionClientes)
                .OrderBy(c => c.Apellidos)
                .ThenBy(c => c.InformacionClientes.Max(i => i.FechaCreacion))
                .ToListAsync();

            return Ok(result);
        }
    }
}
