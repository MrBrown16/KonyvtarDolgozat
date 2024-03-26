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
    public class KolcsonzoesController : ControllerBase
    {
        private readonly KonyvtarNo2Context _context;

        public KolcsonzoesController(KonyvtarNo2Context context)
        {
            _context = context;
        }

        // GET: api/Kolcsonzoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kolcsonzo>>> GetKolcsonzo()
        {
          if (_context.Kolcsonzo == null)
          {
              return NotFound();
          }
            return await _context.Kolcsonzo.Include(x=>x.Kolcsonzes).ToListAsync();
            //return await _context.Kolcsonzo.ToListAsync();
        }

        // GET: api/Kolcsonzoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kolcsonzo>> GetKolcsonzo(int id)
        {
          if (_context.Kolcsonzo == null)
          {
              return NotFound();
          }
            var kolcsonzo = await _context.Kolcsonzo.Where(x=>x.Id==id).Include(x=>x.Kolcsonzes).FirstOrDefaultAsync();
            //var kolcsonzo = await _context.Kolcsonzo.FindAsync(id);

            if (kolcsonzo == null)
            {
                return NotFound();
            }

            return kolcsonzo;
        }

        // PUT: api/Kolcsonzoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKolcsonzo(int id, Kolcsonzo kolcsonzo)
        {
            if (id != kolcsonzo.Id)
            {
                return BadRequest();
            }

            _context.Entry(kolcsonzo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KolcsonzoExists(id))
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

        // POST: api/Kolcsonzoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Kolcsonzo>> PostKolcsonzo(Kolcsonzo kolcsonzo)
        {
          if (_context.Kolcsonzo == null)
          {
              return Problem("Entity set 'KonyvtarNo2Context.Kolcsonzo'  is null.");
          }
            _context.Kolcsonzo.Add(kolcsonzo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKolcsonzo", new { id = kolcsonzo.Id }, kolcsonzo);
        }

        // DELETE: api/Kolcsonzoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKolcsonzo(int id)
        {
            if (_context.Kolcsonzo == null)
            {
                return NotFound();
            }
            var kolcsonzo = await _context.Kolcsonzo.FindAsync(id);
            if (kolcsonzo == null)
            {
                return NotFound();
            }

            _context.Kolcsonzo.Remove(kolcsonzo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KolcsonzoExists(int id)
        {
            return (_context.Kolcsonzo?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
