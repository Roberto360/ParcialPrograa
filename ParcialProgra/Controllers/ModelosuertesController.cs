using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParcialProgra.Data;
using ParcialProgra.Models;

namespace ParcialProgra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelosuertesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ModelosuertesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Modelosuertes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Modelosuerte>>> GetModelosuerte()
        {
            return await _context.Modelosuerte.ToListAsync();
        }

        // GET: api/Modelosuertes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Modelosuerte>> GetModelosuerte(int id)
        {
            var modelosuerte = await _context.Modelosuerte.FindAsync(id);

            if (modelosuerte == null)
            {
                return NotFound();
            }

            return modelosuerte;
        }

        // PUT: api/Modelosuertes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutModelosuerte(int id, Modelosuerte modelosuerte)
        {
            if (id != modelosuerte.SuerteId)
            {
                return BadRequest();
            }

            _context.Entry(modelosuerte).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModelosuerteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Modelosuertes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Modelosuerte>> PostModelosuerte(Modelosuerte modelosuerte)
        {
            _context.Modelosuerte.Add(modelosuerte);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetModelosuerte", new { id = modelosuerte.SuerteId }, modelosuerte);
        }

        // DELETE: api/Modelosuertes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteModelosuerte(int id)
        {
            var modelosuerte = await _context.Modelosuerte.FindAsync(id);
            if (modelosuerte == null)
            {
                return NotFound();
            }

            _context.Modelosuerte.Remove(modelosuerte);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ModelosuerteExists(int id)
        {
            return _context.Modelosuerte.Any(e => e.SuerteId == id);
        }
    }
}
