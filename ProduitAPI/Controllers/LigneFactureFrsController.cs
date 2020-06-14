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
    public class LigneFactureFrsController : ControllerBase
    {
        private readonly ProduitContext _context;

        public LigneFactureFrsController(ProduitContext context)
        {
            _context = context;
        }

        // GET: api/LigneFactureFrs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LigneFactureFrs>>> GetLigneFactureFrs()
        {
            return await _context.LigneFactureFrs.ToListAsync();
        }

        // GET: api/LigneFactureFrs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LigneFactureFrs>> GetLigneFactureFrs(Guid id)
        {
            var ligneFactureFrs = await _context.LigneFactureFrs.FindAsync(id);

            if (ligneFactureFrs == null)
            {
                return NotFound();
            }

            return ligneFactureFrs;
        }

        // PUT: api/LigneFactureFrs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLigneFactureFrs(Guid id, LigneFactureFrs ligneFactureFrs)
        {
            if (id != ligneFactureFrs.IdLi)
            {
                return BadRequest();
            }

            _context.Entry(ligneFactureFrs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LigneFactureFrsExists(id))
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

        // POST: api/LigneFactureFrs
        [HttpPost]
        public async Task<ActionResult<LigneFactureFrs>> PostLigneFactureFrs(LigneFactureFrs ligneFactureFrs)
        {
            _context.LigneFactureFrs.Add(ligneFactureFrs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLigneFactureFrs", new { id = ligneFactureFrs.IdLi }, ligneFactureFrs);
        }

        // DELETE: api/LigneFactureFrs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LigneFactureFrs>> DeleteLigneFactureFrs(Guid id)
        {
            var ligneFactureFrs = await _context.LigneFactureFrs.FindAsync(id);
            if (ligneFactureFrs == null)
            {
                return NotFound();
            }

            _context.LigneFactureFrs.Remove(ligneFactureFrs);
            await _context.SaveChangesAsync();

            return ligneFactureFrs;
        }

        private bool LigneFactureFrsExists(Guid id)
        {
            return _context.LigneFactureFrs.Any(e => e.IdLi == id);
        }
    }
}
