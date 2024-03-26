using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KonyvtarNo2.Data;
using KonyvtarNo2Library.Models;

namespace KonyvtarNo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KolcsonzesController : ControllerBase
    {
        private readonly KonyvtarNo2Context _context;

        public KolcsonzesController(KonyvtarNo2Context context)
        {
            _context = context;
        }

        // GET: api/Kolcsonzes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kolcsonzes>>> GetKolcsonzes()
        {
          if (_context.Kolcsonzes == null)
          {
              return NotFound();
          }
            return await _context.Kolcsonzes.ToListAsync();
        }

        // GET: api/Kolcsonzes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kolcsonzes>> GetKolcsonzes(int id)
        {
          if (_context.Kolcsonzes == null)
          {
              return NotFound();
          }
            var kolcsonzes = await _context.Kolcsonzes.FindAsync(id);

            if (kolcsonzes == null)
            {
                return NotFound();
            }

            return kolcsonzes;
        }

        // PUT: api/Kolcsonzes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKolcsonzes(int id, Kolcsonzes kolcsonzes)
        {
            if (id != kolcsonzes.Id)
            {
                return BadRequest();
            }

            _context.Entry(kolcsonzes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KolcsonzesExists(id))
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

        // POST: api/Kolcsonzes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kolcsonzes>> PostKolcsonzes(Kolcsonzes kolcsonzes)
        {
          if (_context.Kolcsonzes == null)
          {
              return Problem("Entity set 'KonyvtarNo2Context.Kolcsonzes'  is null.");
          }
            _context.Kolcsonzes.Add(kolcsonzes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKolcsonzes", new { id = kolcsonzes.Id }, kolcsonzes);
        }

        // DELETE: api/Kolcsonzes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKolcsonzes(int id)
        {
            if (_context.Kolcsonzes == null)
            {
                return NotFound();
            }
            var kolcsonzes = await _context.Kolcsonzes.FindAsync(id);
            if (kolcsonzes == null)
            {
                return NotFound();
            }

            _context.Kolcsonzes.Remove(kolcsonzes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KolcsonzesExists(int id)
        {
            return (_context.Kolcsonzes?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
