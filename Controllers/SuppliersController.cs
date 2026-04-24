using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductApi.Models;
using ProductApi.Data;

namespace ProductApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public SuppliersController(ApplicationDbContext context) => _context = context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Supplier>>> Get() => await _context.Suppliers.ToListAsync();

        [HttpGet("{id}")]
        public async Task<ActionResult<Supplier>> Get(int id) => await _context.Suppliers.FindAsync(id) is Supplier item ? item : NotFound();

        [HttpPost]
        public async Task<ActionResult<Supplier>> Post(Supplier item)
        {
            _context.Suppliers.Add(item);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Supplier item)
        {
            if (id != item.Id) return BadRequest();
            _context.Entry(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.Suppliers.FindAsync(id);
            if (item == null) return NotFound();
            _context.Suppliers.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}