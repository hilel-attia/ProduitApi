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
    public class FournisseursController : ControllerBase
    {
        private readonly ProduitContext _context;

        public FournisseursController(ProduitContext context)
        {
            _context = context;
        }

        // GET: api/Fournisseurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fournisseur>>> GetFourniseurs()
        {
            return await _context.Fourniseurs.ToListAsync();
        }

        // GET: api/Fournisseurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fournisseur>> GetFournisseur(Guid id)
        {
            var fournisseur = await _context.Fourniseurs.FindAsync(id);

            if (fournisseur == null)
            {
                return NotFound();
            }

            return fournisseur;
        }

        // PUT: api/Fournisseurs/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFournisseur(Guid id, Fournisseur fournisseur)
        {
            if (id != fournisseur.IdFO)
            {
                return BadRequest();
            }

            _context.Entry(fournisseur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FournisseurExists(id))
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

        // POST: api/Fournisseurs
        [HttpPost]
        public async Task<ActionResult<Fournisseur>> PostFournisseur(Fournisseur fournisseur)
        {
            _context.Fourniseurs.Add(fournisseur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFournisseur", new { id = fournisseur.IdFO }, fournisseur);
        }

        // DELETE: api/Fournisseurs/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Fournisseur>> DeleteFournisseur(Guid id)
        {
            var fournisseur = await _context.Fourniseurs.FindAsync(id);
            if (fournisseur == null)
            {
                return NotFound();
            }

            _context.Fourniseurs.Remove(fournisseur);
            await _context.SaveChangesAsync();

            return fournisseur;
        }

        private bool FournisseurExists(Guid id)
        {
            return _context.Fourniseurs.Any(e => e.IdFO == id);
        }
    }
}
