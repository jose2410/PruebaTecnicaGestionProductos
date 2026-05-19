using BackendProductos.Data;
using BackendProductos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendProductos.Controllers
{
    [Route("api/productos")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/productos
        [HttpGet]
        public async Task<IActionResult> GetProductos()
        {
            var productos = await _context.Productos.ToListAsync();
            return Ok(productos);
        }

        // POST: api/productos
        [HttpPost]
        public async Task<IActionResult> PostProducto([FromBody] Producto producto)
        {
            _context.Productos.Add(producto);
            await _context.SaveChangesAsync();

            return Ok(producto);
        }
    }
}