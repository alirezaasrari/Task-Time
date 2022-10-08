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
    public class SecondPagesController : ControllerBase
    {
        private readonly DataContext _context;

        public SecondPagesController(DataContext context)
        {
            _context = context;
        }

        // GET: api/SecondPages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SecondPage>>> GetSecondPages()
        {
            return await _context.SecondPages.ToListAsync();
        }

        // GET: api/SecondPages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SecondPage>> GetSecondPage(int id)
        {
            var secondPage = await _context.SecondPages.FindAsync(id);

            if (secondPage == null)
            {
                return NotFound();
            }

            return secondPage;
        }

        // PUT: api/SecondPages/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSecondPage(int id, SecondPage secondPage)
        {
            if (id != secondPage.Id)
            {
                return BadRequest();
            }

            _context.Entry(secondPage).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SecondPageExists(id))
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

        // POST: api/SecondPages
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SecondPage>> PostSecondPage(SecondPage secondPage)
        {
            _context.SecondPages.Add(secondPage);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSecondPage", new { id = secondPage.Id }, secondPage);
        }

        // DELETE: api/SecondPages/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSecondPage(int id)
        {
            var secondPage = await _context.SecondPages.FindAsync(id);
            if (secondPage == null)
            {
                return NotFound();
            }

            _context.SecondPages.Remove(secondPage);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SecondPageExists(int id)
        {
            return _context.SecondPages.Any(e => e.Id == id);
        }
    }
}
