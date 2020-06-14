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
    public class Commande_frsController : ControllerBase
    {
        private readonly ProduitContext _context;

        public Commande_frsController(ProduitContext context)
        {
            _context = context;
        }

        // GET: api/Commande_frs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Commande_frs>>> GetCommande_frss()
        {
            return await _context.Commande_frss.ToListAsync();
        }

        // GET: api/Commande_frs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Commande_frs>> GetCommande_frs(Guid id)
        {
            var commande_frs = await _context.Commande_frss.FindAsync(id);

            if (commande_frs == null)
            {
                return NotFound();
            }

            return commande_frs;
        }

        // PUT: api/Commande_frs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommande_frs(Guid id, Commande_frs commande_frs)
        {
            if (id != commande_frs.IdCO)
            {
                return BadRequest();
            }

            _context.Entry(commande_frs).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Commande_frsExists(id))
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

        // POST: api/Commande_frs
        [HttpPost]
        public async Task<ActionResult<Commande_frs>> PostCommande_frs(Commande_frs commande_frs)
        {
            _context.Commande_frss.Add(commande_frs);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommande_frs", new { id = commande_frs.IdCO }, commande_frs);
        }

        // DELETE: api/Commande_frs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Commande_frs>> DeleteCommande_frs(Guid id)
        {
            var commande_frs = await _context.Commande_frss.FindAsync(id);
            if (commande_frs == null)
            {
                return NotFound();
            }

            _context.Commande_frss.Remove(commande_frs);
            await _context.SaveChangesAsync();

            return commande_frs;
        }

        private bool Commande_frsExists(Guid id)
        {
            return _context.Commande_frss.Any(e => e.IdCO == id);
        }
    }
}
