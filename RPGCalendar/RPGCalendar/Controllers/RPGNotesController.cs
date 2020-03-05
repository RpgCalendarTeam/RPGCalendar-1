using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPGCalendar.Models;

namespace RPGCalendar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RPGNotesController : ControllerBase
    {
        private readonly NoteContext _context;

        public RPGNotesController(NoteContext context)
        {
            _context = context;
        }

        // GET: api/RPGNotes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<RPGNote>>> GetRPGNotes()
        {
            return await _context.RPGNotes.ToListAsync();
        }

        // GET: api/RPGNotes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<RPGNote>> GetRPGNote(long id)
        {
            var rPGNote = await _context.RPGNotes.FindAsync(id);

            if (rPGNote == null)
            {
                return NotFound();
            }

            return rPGNote;
        }

        // PUT: api/RPGNotes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutRPGNote(long id, RPGNote rPGNote)
        {
            if (id != rPGNote.Id)
            {
                return BadRequest();
            }

            _context.Entry(rPGNote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RPGNoteExists(id))
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

        // POST: api/RPGNotes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<RPGNote>> PostRPGNote(RPGNote rPGNote)
        {
            _context.RPGNotes.Add(rPGNote);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetRPGNote", new { id = rPGNote.Id }, rPGNote);
        }

        // DELETE: api/RPGNotes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<RPGNote>> DeleteRPGNote(long id)
        {
            var rPGNote = await _context.RPGNotes.FindAsync(id);
            if (rPGNote == null)
            {
                return NotFound();
            }

            _context.RPGNotes.Remove(rPGNote);
            await _context.SaveChangesAsync();

            return rPGNote;
        }

        private bool RPGNoteExists(long id)
        {
            return _context.RPGNotes.Any(e => e.Id == id);
        }
    }
}
