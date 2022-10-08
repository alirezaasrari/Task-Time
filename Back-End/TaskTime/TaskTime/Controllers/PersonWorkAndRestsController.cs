using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskTime.Data;
using TaskTime.Models;

namespace TaskTime.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonWorkAndRestsController : ControllerBase
    {
        private readonly DataContext _context;

        public PersonWorkAndRestsController(DataContext context)
        {
            _context = context;
        }

        // GET: api/PersonWorkAndRests
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonWorkAndRest>>> GetPersonWorkAndRests()
        {
            return await _context.PersonWorkAndRests.ToListAsync();
        }

        // GET: api/PersonWorkAndRests/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonWorkAndRest>> GetPersonWorkAndRest(int id)
        {
            var personWorkAndRest = await _context.PersonWorkAndRests.FindAsync(id);

            if (personWorkAndRest == null)
            {
                return NotFound();
            }

            return personWorkAndRest;
        }

        // PUT: api/PersonWorkAndRests/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonWorkAndRest(int id, PersonWorkAndRest personWorkAndRest)
        {
            if (id != personWorkAndRest.Id)
            {
                return BadRequest();
            }

            _context.Entry(personWorkAndRest).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonWorkAndRestExists(id))
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

        // POST: api/PersonWorkAndRests
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonWorkAndRest>> PostPersonWorkAndRest(PersonWorkAndRest personWorkAndRest)
        {
            _context.PersonWorkAndRests.Add(personWorkAndRest);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonWorkAndRest", new { id = personWorkAndRest.Id }, personWorkAndRest);
        }

        // DELETE: api/PersonWorkAndRests/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonWorkAndRest(int id)
        {
            var personWorkAndRest = await _context.PersonWorkAndRests.FindAsync(id);
            if (personWorkAndRest == null)
            {
                return NotFound();
            }

            _context.PersonWorkAndRests.Remove(personWorkAndRest);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonWorkAndRestExists(int id)
        {
            return _context.PersonWorkAndRests.Any(e => e.Id == id);
        }
    }
}
