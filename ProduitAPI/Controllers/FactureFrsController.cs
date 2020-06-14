using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProduitAPI.Models;

namespace ProduitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactureFrsController : ControllerBase
    {
        private readonly ProduitContext _context;

        public FactureFrsController(ProduitContext context)
        {
            _context = context;
        }

        // GET: api/FactureFrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FactureFrs>>> GetFactureFrs()
        {
            return await _context.FactureFrs.ToListAsync();
        }

        // GET: api/FactureFrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FactureFrs>> GetFactureFrs(Guid id)
        {
            var factureFrs = await _context.FactureFrs.FindAsync(id);

            if (factureFrs == null)
            {
                return NotFound();
            }

            return factureFrs;
        }

        // PUT: api/FactureFrs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFactureFrs(Guid id, FactureFrs factureFrs)
        {
            if (id != factureFrs.IdFac)
            {
                return BadRequest();
            }

            _context.Entry(factureFrs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FactureFrsExists(id))
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

        // POST: api/FactureFrs
        [HttpPost]
        public async Task<ActionResult<FactureFrs>> PostFactureFrs(FactureFrs factureFrs)
        {
            _context.FactureFrs.Add(factureFrs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFactureFrs", new { id = factureFrs.IdFac }, factureFrs);
        }

        // DELETE: api/FactureFrs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FactureFrs>> DeleteFactureFrs(Guid id)
        {
            var factureFrs = await _context.FactureFrs.FindAsync(id);
            if (factureFrs == null)
            {
                return NotFound();
            }

            _context.FactureFrs.Remove(factureFrs);
            await _context.SaveChangesAsync();

            return factureFrs;
        }

        private bool FactureFrsExists(Guid id)
        {
            return _context.FactureFrs.Any(e => e.IdFac == id);
        }
    }
}
