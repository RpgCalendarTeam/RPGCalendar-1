using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RPGCalendar.Models;

namespace RPGCalendar.Models
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameObjectsController : ControllerBase
    {
        private readonly ApplicationDBContext _context;

        public GameObjectsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: api/GameObjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GameObject>>> GetGameObjects()
        {
            return await _context.GameObjects.ToListAsync();
        }

        // GET: api/GameObjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GameObject>> GetGameObject(int id)
        {
            var gameObject = await _context.GameObjects.FindAsync(id);

            if (gameObject == null)
            {
                return NotFound();
            }

            return gameObject;
        }

        // PUT: api/GameObjects/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGameObject(int id, GameObject gameObject)
        {
            if (id != gameObject.Id)
            {
                return BadRequest();
            }

            _context.Entry(gameObject).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameObjectExists(id))
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

        // POST: api/GameObjects
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<GameObject>> PostGameObject(GameObject gameObject)
        {
            _context.GameObjects.Add(gameObject);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGameObject", new { id = gameObject.Id }, gameObject);
        }

        // DELETE: api/GameObjects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<GameObject>> DeleteGameObject(int id)
        {
            var gameObject = await _context.GameObjects.FindAsync(id);
            if (gameObject == null)
            {
                return NotFound();
            }

            _context.GameObjects.Remove(gameObject);
            await _context.SaveChangesAsync();

            return gameObject;
        }

        private bool GameObjectExists(int id)
        {
            return _context.GameObjects.Any(e => e.Id == id);
        }
    }
}
