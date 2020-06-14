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
    public class PaquetsController : ControllerBase
    {
        private readonly ProduitContext _context;

        public PaquetsController(ProduitContext context)
        {
            _context = context;
        }

        // GET: api/Paquets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paquet>>> GetPaquets()
        {
            return await _context.Paquets.ToListAsync();
        }

        // GET: api/Paquets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Paquet>> GetPaquet(Guid id)
        {
            var paquet = await _context.Paquets.FindAsync(id);

            if (paquet == null)
            {
                return NotFound();
            }

            return paquet;
        }

        // PUT: api/Paquets/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPaquet(Guid id, Paquet paquet)
        {
            if (id != paquet.IdPA)
            {
                return BadRequest();
            }

            _context.Entry(paquet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PaquetExists(id))
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

        // POST: api/Paquets
        [HttpPost]
        public async Task<ActionResult<Paquet>> PostPaquet(Paquet paquet)
        {
            _context.Paquets.Add(paquet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPaquet", new { id = paquet.IdPA }, paquet);
        }

        // DELETE: api/Paquets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Paquet>> DeletePaquet(Guid id)
        {
            var paquet = await _context.Paquets.FindAsync(id);
            if (paquet == null)
            {
                return NotFound();
            }

            _context.Paquets.Remove(paquet);
            await _context.SaveChangesAsync();

            return paquet;
        }

        private bool PaquetExists(Guid id)
        {
            return _context.Paquets.Any(e => e.IdPA == id);
        }
    }
}
